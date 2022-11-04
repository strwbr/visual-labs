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

        private int LeftPos => (int)brightAmountChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset;
        private int RightPos => (int)brightAmountChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset;

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

            MoveLeftBoundary(LeftPos);
            MoveRightBoundary(RightPos);


        }

        private void LeftBoundaryTrack_Scroll(object sender, EventArgs e)
        {
            //MoveLeftBoundary(LeftBoundaryPos);
            ////UpdateBoundaryPos(0, LeftBoundaryPos);
            ////leftBoundaryValueTb.Text = LeftBoundaryPos.ToString();

            //if (IsFixBoundaries())
            //{
            //    int dx = Math.Abs(lastLeftBoundaryPos - RightBoundaryPos); //LeftBoundaryPos - lastLeftBoundaryPos;

            //    //if (LeftBoundaryPos + dx <= 255)
            //    //{
            //    //    rightBoundaryTrack.Value = LeftBoundaryPos + dx; //RightBoundaryPos + dx;
            //    //}
            //    //else
            //    //{
            //    //    rightBoundaryTrack.Value = 255;
            //    //}
            //    rightBoundaryTrack.Value = LeftBoundaryPos + dx; //RightBoundaryPos + dx;
            //    //UpdateBoundaryPos(1, RightBoundaryPos);
            //    //rightBoundaryValueTb.Text = RightBoundaryPos.ToString();
            //    MoveRightBoundary(RightBoundaryPos);

            //    lastRightBoundaryPos = RightBoundaryPos; // мб это тоже в методы Move...
            //}

            //lastLeftBoundaryPos = LeftBoundaryPos;

            //// DEBUG
            //label3.Text = amountBright[LeftBoundaryPos].ToString();
        }

        private void RightBoundaryTrack_Scroll(object sender, EventArgs e)
        {
            //MoveRightBoundary(RightBoundaryPos);
            ////UpdateBoundaryPos(1, RightBoundaryPos);
            ////rightBoundaryValueTb.Text = RightBoundaryPos.ToString();

            //if (IsFixBoundaries())
            //{
            //    int dx = Math.Abs(lastRightBoundaryPos - RightBoundaryPos); // RightBoundaryPos - lastRightBoundaryPos;
            //    leftBoundaryTrack.Value = RightBoundaryPos - dx; //LeftBoundaryPos + dx;
            //    //UpdateBoundaryPos(0, LeftBoundaryPos);
            //    //leftBoundaryValueTb.Text = LeftBoundaryPos.ToString();
            //    MoveLeftBoundary(LeftBoundaryPos);

            //    lastLeftBoundaryPos = LeftBoundaryPos;
            //}

            //lastRightBoundaryPos = RightBoundaryPos;

            //// DEBUG
            //label4.Text = amountBright[RightBoundaryPos].ToString();
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
            int xL = /*LeftBoundaryPos;*/  LeftPos;
            int xR = /*RightBoundaryPos;*/  RightPos;

            isMoveLeftBoundary = (x > xL - 5) && (x < xL + 5) && (xL != xR);
            isMoveRightBoundary = (x > xR - 5) && (x < xR + 5) && !isMoveLeftBoundary; // мб может что-то вылезти

        }

        private void BrightAmountChart_MouseUp(object sender, MouseEventArgs e)
        {
            isMoveLeftBoundary = false;
            isMoveRightBoundary = false;
        }

        private void BrightAmountChart_MouseMove(object sender, MouseEventArgs e)
        {
            int x = -99999;
            try
            {
                x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (x >= 0 && x <= 255)
            {
                if (IsFixBoundaries())
                {
                    //int dx = Math.Abs(LeftBoundaryPos - RightBoundaryPos);
                    int dx = Math.Abs(LeftPos - RightPos);

                    if (isMoveLeftBoundary)
                    {
                        if (x + dx <= 255)
                        {
                            MoveLeftBoundary(x);
                            MoveRightBoundary(x + dx);
                            //leftBoundaryTrack.Value = x;
                            //rightBoundaryTrack.Value = x + dx;
                        }
                        //MoveLeftBoundary(LeftBoundaryPos);
                        //MoveRightBoundary(RightBoundaryPos);

                        //lastRightBoundaryPos = RightBoundaryPos; // ???
                    }
                    else if (isMoveRightBoundary)
                    {
                        if (x - dx >= 0)
                        {
                            MoveLeftBoundary(x - dx);
                            MoveRightBoundary(x);
                            //leftBoundaryTrack.Value = x - dx;
                            //rightBoundaryTrack.Value = x;
                        }
                        //MoveLeftBoundary(LeftBoundaryPos);
                        //MoveRightBoundary(RightBoundaryPos);

                        //lastLeftBoundaryPos = LeftBoundaryPos; // ???
                    }
                }
                else
                {
                    if (isMoveLeftBoundary)
                    {
                        if (x <= RightPos)
                        {
                            //leftBoundaryTrack.Value = x;
                            //MoveLeftBoundary(LeftBoundaryPos);
                            MoveLeftBoundary(x);
                        }
                    }
                    if (isMoveRightBoundary)
                    {
                        if (x >= LeftPos)
                        {
                            //rightBoundaryTrack.Value = x;
                            //MoveRightBoundary(RightBoundaryPos);
                            MoveRightBoundary(x);
                        }
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
