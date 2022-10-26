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

        bool moveLeftBoundary = false;
        bool moveRightBoundary = false;
        bool moveBoth = false;

        private int LeftBoundaryPos => leftBoundaryTrack.Value;
        private int RightBoundaryPos => rightBoundaryTrack.Value;

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
            foreach (ushort val in temp)
            {
                amountBright[val]++;
            }
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < amountBright.Length; i++)
            {
                brightAmountChart.Series[0].Points.AddXY(i, amountBright[i]);
            }

            int leftBoundaryPos = LeftBoundaryPos;
            UpdateBoundaryPos(0, leftBoundaryPos);
            leftBoundaryValueTb.Text = leftBoundaryPos.ToString();

            int rightBoundaryPos = RightBoundaryPos;
            UpdateBoundaryPos(1, rightBoundaryPos);
            rightBoundaryValueTb.Text = rightBoundaryPos.ToString();
        }



        private void LeftBoundaryTrack_ValueChanged(object sender, EventArgs e)
        {
            int leftBoundaryPos = LeftBoundaryPos;
            UpdateBoundaryPos(0, leftBoundaryPos);
            leftBoundaryValueTb.Text = leftBoundaryPos.ToString();

            // DEBUG
            label3.Text = amountBright[leftBoundaryPos].ToString();
        }

        private void RightBoundaryTrack_ValueChanged(object sender, EventArgs e)
        {
            int rightBoundaryPos = RightBoundaryPos;
            UpdateBoundaryPos(1, rightBoundaryPos);
            rightBoundaryValueTb.Text = rightBoundaryPos.ToString();

            // DEBUG
            label4.Text = amountBright[rightBoundaryPos].ToString();
        }


        private void UpdateBoundaryPos(int index, int x)
        {
            brightAmountChart.ChartAreas[0].AxisX.StripLines[index].IntervalOffset = x;
        }

        private void BrightAmountChart_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            int xL = LeftBoundaryPos; //(int)boundaries[0].IntervalOffset;
            int xR = RightBoundaryPos; //(int)boundaries[1].IntervalOffset;
            moveLeftBoundary = (x > xL - 3) && (x < xL + 3);
            moveRightBoundary = (x > xR - 3) && (x < xR + 3);

            if (IsFixBoundaries())
                moveLeftBoundary = moveRightBoundary = true;

            // DEBUG
            label5.Text = $"left: {moveLeftBoundary}, right: {moveRightBoundary}, both: {moveBoth}";
        }

        private void BrightAmountChart_MouseUp(object sender, MouseEventArgs e)
        {
            moveLeftBoundary = false;
            moveRightBoundary = false;
            moveBoth = false;

            // DEBUG
            label5.Text = $"left: {moveLeftBoundary}, right: {moveRightBoundary}, both: {moveBoth}";
        }

        private void BrightAmountChart_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);

            if (x >= 0 && x <= 255)
            {
                if (IsFixBoundaries())
                {
                    //int dxL = Math.Abs(x - leftBoundaryTrack.Value);
                    //int dxR = Math.Abs(x - rightBoundaryTrack.Value);
                    //int dx = (dxL > dxR) ? dxR : dxL;
                    //leftBoundaryTrack.Value += dx;
                    //rightBoundaryTrack.Value += dx;

                    // Это не работает если левая и правая границы поменялись местами
                    if (moveLeftBoundary)
                    {
                        int dx = Math.Abs(LeftBoundaryPos - RightBoundaryPos);
                        leftBoundaryTrack.Value = x;
                        rightBoundaryTrack.Value = x + dx;
                    }
                    else if (moveRightBoundary)
                    {
                        int dx = Math.Abs(LeftBoundaryPos - RightBoundaryPos);
                        leftBoundaryTrack.Value = x - dx;
                        rightBoundaryTrack.Value = x;
                    }
                }
                else
                {
                    if (moveLeftBoundary)
                    {
                        leftBoundaryTrack.Value = x;
                    }
                    if (moveRightBoundary)
                    {
                        rightBoundaryTrack.Value = x;
                    }
                }
            }
        }

        private bool IsFixBoundaries()
        {
            return fixCb.Checked;
        }
    }
}
