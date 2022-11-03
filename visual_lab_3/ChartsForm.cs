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

        bool isMoveLeftBoundary = false;
        bool isMoveRightBoundary = false;

        private int LeftBoundaryPos => leftBoundaryTrack.Value;
        private int RightBoundaryPos => rightBoundaryTrack.Value;

        int lastLeftBoundaryPos = 0;
        int lastRightBoundaryPos = 255;

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

        private void LeftBoundaryTrack_Scroll(object sender, EventArgs e)
        {
            MoveLeftBoundary(LeftBoundaryPos);
            //UpdateBoundaryPos(0, LeftBoundaryPos);
            //leftBoundaryValueTb.Text = LeftBoundaryPos.ToString();

            if (IsFixBoundaries())
            {
                int dx = LeftBoundaryPos - lastLeftBoundaryPos;
                rightBoundaryTrack.Value = RightBoundaryPos + dx;
                //UpdateBoundaryPos(1, RightBoundaryPos);
                //rightBoundaryValueTb.Text = RightBoundaryPos.ToString();
                MoveRightBoundary(RightBoundaryPos);

                lastRightBoundaryPos = RightBoundaryPos; // мб это тоже в методы Move...
            }

            lastLeftBoundaryPos = LeftBoundaryPos;

            // DEBUG
            label3.Text = amountBright[LeftBoundaryPos].ToString();
        }

        private void RightBoundaryTrack_Scroll(object sender, EventArgs e)
        {
            MoveRightBoundary(RightBoundaryPos);
            //UpdateBoundaryPos(1, RightBoundaryPos);
            //rightBoundaryValueTb.Text = RightBoundaryPos.ToString();

            if (IsFixBoundaries())
            {
                int dx = RightBoundaryPos - lastRightBoundaryPos;
                leftBoundaryTrack.Value = LeftBoundaryPos + dx;
                //UpdateBoundaryPos(0, LeftBoundaryPos);
                //leftBoundaryValueTb.Text = LeftBoundaryPos.ToString();
                MoveLeftBoundary(LeftBoundaryPos);

                lastLeftBoundaryPos = LeftBoundaryPos;
            }

            lastRightBoundaryPos = RightBoundaryPos;

            // DEBUG
            label4.Text = amountBright[RightBoundaryPos].ToString();
        }

        private void UpdateBoundaryPos(int index, int x)
        {
            brightAmountChart.ChartAreas[0].AxisX.StripLines[index].IntervalOffset = x;
        }

        private void MoveLeftBoundary(int x)
        {
            //leftBoundaryTrack.Value = x;
            brightAmountChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = x;
            leftBoundaryValueTb.Text = x.ToString(); // = LeftBoundaryPos;
        }

        private void MoveRightBoundary(int x)
        {
            //rightBoundaryTrack.Value = x;
            brightAmountChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = x;
            rightBoundaryValueTb.Text = x.ToString(); // = RightBoundaryPos;
        }

        private void BrightAmountChart_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            int xL = LeftBoundaryPos;
            int xR = RightBoundaryPos;
            isMoveLeftBoundary = (x > xL - 3) && (x < xL + 3);
            isMoveRightBoundary = (x > xR - 3) && (x < xR + 3);

            //// DEBUG
            //label5.Text = $"left: {isMoveLeftBoundary}, right: {isMoveRightBoundary}";
        }

        private void BrightAmountChart_MouseUp(object sender, MouseEventArgs e)
        {
            isMoveLeftBoundary = false;
            isMoveRightBoundary = false;

            //// DEBUG
            //label5.Text = $"left: {isMoveLeftBoundary}, right: {isMoveRightBoundary}";
        }

        private void BrightAmountChart_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);

            if (x >= 0 && x <= 255)
            {
                if (isMoveLeftBoundary)
                {
                    leftBoundaryTrack.Value = x;
                    MoveLeftBoundary(LeftBoundaryPos);
                }
                if (isMoveRightBoundary)
                {
                    rightBoundaryTrack.Value = x;
                    MoveRightBoundary(RightBoundaryPos);
                }

                if (IsFixBoundaries())
                {
                    int dx = Math.Abs(LeftBoundaryPos - RightBoundaryPos);

                    //int dxL = Math.Abs(x - leftBoundaryTrack.Value);
                    //int dxR = Math.Abs(x - rightBoundaryTrack.Value);
                    //int dx = (dxL > dxR) ? dxR : dxL;
                    //leftBoundaryTrack.Value += dx;
                    //rightBoundaryTrack.Value += dx;

                    // Это не работает если левая и правая границы поменялись местами
                    if (isMoveLeftBoundary)
                    {
                        //leftBoundaryTrack.Value = x;
                        //MoveLeftBoundary(LeftBoundaryPos);
                        rightBoundaryTrack.Value = x + dx;
                        MoveRightBoundary(RightBoundaryPos);

                        lastRightBoundaryPos = RightBoundaryPos; // ???
                    }
                    else if (isMoveRightBoundary)
                    {
                        leftBoundaryTrack.Value = x - dx;
                        MoveLeftBoundary(LeftBoundaryPos);
                        //rightBoundaryTrack.Value = x;
                        //MoveRightBoundary(RightBoundaryPos);

                        lastLeftBoundaryPos = LeftBoundaryPos; // ???
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
