using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace visual_lab_3
{
    public partial class ChartsForm : Form
    {
        // Количество различных яркостей в изображении
        int[] amountBright = new int[256];
        //StripLine leftBoundary = new StripLine();
        //StripLine rightBoundary = new StripLine();
        StripLine[] boundaries = new StripLine[2];

        bool moveLeftBoundary = false;
        bool moveRightBoundary = false;
        bool moveBoth = false;

        public ChartsForm()
        {
            InitializeComponent();
        }

        public ChartsForm(Bitmap pixels)
        {
            InitializeComponent();
            ushort[] temp = new ushort[pixels.Width * pixels.Height];
            int count = 0;
            for (int i = 0; i < pixels.Height; i++)
            {
                for (int k = 0; k < pixels.Width; k++)
                {
                    temp[count] = pixels.GetPixel(k, i).R;
                    count++;
                }
            }
            foreach(ushort val in temp)
            {
                amountBright[val]++;
            }

            for(int i = 0; i < boundaries.Length; i++)
            {
                boundaries[i] = new StripLine();
                boundaries[i].BackColor = Color.Red;
                boundaries[i].StripWidth = 2;
            }
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < amountBright.Length; i++)
            {
                brightAmountChart.Series[0].Points.AddXY(i, amountBright[i]);
            }

            int leftBoundaryPos = GetLeftBoundaryPos();
            boundaries[0] = UpdateBoundaryPos(boundaries[0], leftBoundaryPos);
            SetBoundary(boundaries[0]);
            leftBoundaryValueTb.Text = leftBoundaryPos.ToString();

            int rightBoundaryPos = GetRightBoundaryPos();
            boundaries[1] = UpdateBoundaryPos(boundaries[1], rightBoundaryPos);
            SetBoundary(boundaries[1]);
            rightBoundaryValueTb.Text = rightBoundaryPos.ToString();
        }

        private int GetLeftBoundaryPos()
        {
            return leftBoundaryTrack.Value;
        }

        private int GetRightBoundaryPos()
        {
            return rightBoundaryTrack.Value;
        }

        private void LeftBoundaryTrack_ValueChanged(object sender, EventArgs e)
        {
            int leftBoundaryPos = GetLeftBoundaryPos();
            boundaries[0] = UpdateBoundaryPos(boundaries[0],leftBoundaryPos);
            SetBoundaries();
            leftBoundaryValueTb.Text = leftBoundaryPos.ToString();
            
            label3.Text = amountBright[leftBoundaryPos].ToString();
        }

        private void RightBoundaryTrack_ValueChanged(object sender, EventArgs e)
        {
            int rightBoundaryPos = GetRightBoundaryPos();
            boundaries[1] = UpdateBoundaryPos(boundaries[1], rightBoundaryPos);
            SetBoundaries();
            rightBoundaryValueTb.Text = rightBoundaryPos.ToString();

            label4.Text = amountBright[rightBoundaryPos].ToString();
        }

        private void SetBoundaries()
        {
            brightAmountChart.ChartAreas[0].AxisX.StripLines.Clear();
            SetBoundary(boundaries[0]);
            SetBoundary(boundaries[1]);
        }

        private StripLine UpdateBoundaryPos(StripLine boundary, int x)
        {
            boundary.IntervalOffset = x;
            return boundary;
        }

        private void SetBoundary(StripLine boundary)
        {
            brightAmountChart.ChartAreas[0].AxisX.StripLines.Add(boundary);
        }

        private void BrightAmountChart_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            int xL = (int)boundaries[0].IntervalOffset;
            int xR = (int)boundaries[1].IntervalOffset;
            moveLeftBoundary = (x > xL - 3 && x < xL + 3);
            moveRightBoundary = (x > xR - 3 && x < xR + 3);

            // TODO обработать вариант когда они очень близко друг к другу
            label5.Text = $"left: {moveLeftBoundary}, right: {moveRightBoundary}, both: {moveBoth}";
        }

        private void BrightAmountChart_MouseUp(object sender, MouseEventArgs e)
        {
            moveLeftBoundary = false;
            moveRightBoundary = false;
            label5.Text = $"left: {moveLeftBoundary}, right: {moveRightBoundary}, both: {moveBoth}";

        }

        private void BrightAmountChart_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            if (moveBoth)
            {
                // REFACTOR
                leftBoundaryTrack.Value = x;
                rightBoundaryTrack.Value = x;
            }
            else
            {
                if (moveLeftBoundary)
                {
                    //boundaries[0] = UpdateBoundaryPos(boundaries[0], x);
                    leftBoundaryTrack.Value = x;
                }
                if (moveRightBoundary)
                {
                    rightBoundaryTrack.Value = x;
                    //boundaries[1] = UpdateBoundaryPos(boundaries[1], x);
                }
            }
        }

        private void brightAmountChart_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                moveBoth = true;
            }
            label5.Text = $"left: {moveLeftBoundary}, right: {moveRightBoundary}, both: {moveBoth}";

        }

        private void brightAmountChart_KeyUp(object sender, KeyEventArgs e)
        {
            moveBoth = false;
            label5.Text = $"left: {moveLeftBoundary}, right: {moveRightBoundary}, both: {moveBoth}";

        }
    }
}
