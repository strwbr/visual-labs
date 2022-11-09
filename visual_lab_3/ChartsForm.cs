using System;
using System.Drawing;
using System.Windows.Forms;

namespace visual_lab_3
{
    public partial class ChartsForm : Form
    {
        // Количество различных яркостей в изображении
        int[] amountBright = new int[256];

        bool isMoveLeftBoundary = false;
        bool isMoveRightBoundary = false;

        public event Action<Bitmap> UpdateBright;

        FormController parentForm;
        Bitmap originImage;
        Bitmap newImage;

        private ushort LeftPos => (ushort)brightAmountChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset;
        private ushort RightPos => (ushort)brightAmountChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset;

        public ChartsForm()
        {
            InitializeComponent();
        }

        // ??? мб и конструктор без параметров подойдет
        public ChartsForm(FormController parent)
        {
            InitializeComponent();
            parentForm = parent;
            originImage = parent.CurrentImage;
            //UpdateChart(parentForm.CurrentImage);
            MoveLeftBoundary(LeftPos);
            MoveRightBoundary(RightPos);

            for (int i = 0; i < leftModesGb.Controls.Count; i++)
            {
                RadioButton rb = leftModesGb.Controls[i] as RadioButton;
                rb.CheckedChanged += LeftModeRb_CheckedChanged;
            }
            for (int i = 0; i < rightModesGb.Controls.Count; i++)
            {
                RadioButton rb = rightModesGb.Controls[i] as RadioButton;
                rb.CheckedChanged += RightModeRb_CheckedChanged;
            }
        }

        public void UpdateChart(Bitmap image)
        {
            originImage = image;
            amountBright = CountBright(image);
            BuildChart(CountBright(image));
        }

        private int[] CountBright(Bitmap image)
        {
            int[] temp = new int[256];
            for (int i = 0; i < image.Height; i++)
            {
                for (int k = 0; k < image.Width; k++)
                {
                    ushort bright = image.GetPixel(k, i).R;
                    temp[bright]++;
                }
            }
            return temp;
        }

        private void BuildChart(int[] amountBright)
        {
            if (brightAmountChart.Series[0].Points != null)
                brightAmountChart.Series[0].Points.Clear();

            for (int i = 0; i < amountBright.Length; i++)
            {
                brightAmountChart.Series[0].Points.AddXY(i, amountBright[i]);
            }
        }

        private void MoveLeftBoundary(int x)
        {
            brightAmountChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = x;
            leftBrightValueTb.Text = x.ToString();
            leftBrightAmountTb.Text = amountBright[x].ToString();
        }

        private void MoveRightBoundary(int x)
        {
            brightAmountChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = x;
            rightBrightValueTb.Text = x.ToString();
            rightBrightAmountTb.Text = amountBright[x].ToString();
        }

        public Bitmap UpdateImageBright(Bitmap image)
        {
            Bitmap updatedImage = null;

            if (NormalizeMode())
            {
                updatedImage = BrightController.NormalizeBright(image, LeftPos, RightPos);
            }
            else
            {
                ushort newLeftBright = GetNewLeftBrightValue();
                ushort newRightBright = GetNewRightBrightValue();

                if (newLeftBright != 9999 && newRightBright != 9999)
                {
                    updatedImage = BrightController.ChangeImageBright(
                                image,
                                LeftPos, newLeftBright,
                                RightPos, newRightBright);
                } // else (newRightBright == 9999 && newLeftBright!=9999) R = 255; ...
            }
            return updatedImage;
        }

        private int GetLeftMode()
        {
            int mode = -1;
            for (int i = 0; i < leftModesGb.Controls.Count; i++)
            {
                RadioButton rb = leftModesGb.Controls[i] as RadioButton;
                if (rb.Checked)
                    mode = i;
            }
            return mode;
        }

        private ushort GetNewLeftBrightValue()
        {
            ushort newBright = 0; // по умолчанию = 0
            int mode = GetLeftMode();
            switch (mode)
            {
                case -1: newBright = 9999; break;
                case 0: newBright = (ushort)LeftPos; break;
                case 1: newBright = 0; break;
                case 2: newBright = 0; break;
            }
            return newBright;
        }

        private int GetRightMode()
        {
            int mode = -1;
            for (int i = 0; i < rightModesGb.Controls.Count; i++)
            {
                RadioButton rb = rightModesGb.Controls[i] as RadioButton;
                if (rb.Checked)
                    mode = i;
            }
            return mode;
        }

        private ushort GetNewRightBrightValue()
        {
            ushort newBright = 0; // по умолчанию = 0
            int mode = GetRightMode();
            switch (mode)
            {
                case -1: newBright = 9999; break;
                case 0: newBright = (ushort)RightPos; break;
                case 1: newBright = 255; break;
                case 2: newBright = 0; break;
            }
            return newBright;
        }

        private bool NormalizeMode()
        {
            return normalizeModeRb.Checked;
        }

        private void LeftModeRb_CheckedChanged(object sender, EventArgs e)
        {
            if (GetLeftMode() != -1)
            {
                DisableNormalizeMode();
                if (GetRightMode() == -1)
                    ((RadioButton)rightModesGb.Controls[0]).Checked = true;
            }
            //if (GetLeftMode() != -1 && GetRightMode() != -1)
            //    DisableNormalizeMode();
        }

        private void RightModeRb_CheckedChanged(object sender, EventArgs e)
        {
            if (GetRightMode() != -1)
            {
                DisableNormalizeMode();
                if (GetLeftMode() == -1)
                    ((RadioButton)leftModesGb.Controls[0]).Checked = true;

            }
            //if (GetLeftMode() != -1 && GetRightMode() != -1)
            //    DisableNormalizeMode();
        }

        private void UpdateBrightBtn_Click(object sender, EventArgs e)
        {
            //newImage = UpdateImageBright(parentForm.CurrentImage);
            // ЗАГЛУШКА
            //UpdateBright?.Invoke(newImage);
            Bitmap oldImg = originImage; //parentForm.CurrentImage;
            Bitmap newImg = UpdateImageBright(oldImg);
            parentForm?.SetImage(newImg);
        }

        private void NormalizeModeRb_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalizeMode())
            {
                DisableLeftMode();
                DisableRightMode();
            }
        }

        private void DisableLeftMode()
        {
            for (int i = 0; i < leftModesGb.Controls.Count; i++)
            {
                ((RadioButton)leftModesGb.Controls[i]).Checked = false;
            }
        }
        private void DisableRightMode()
        {
            for (int i = 0; i < rightModesGb.Controls.Count; i++)
            {
                ((RadioButton)rightModesGb.Controls[i]).Checked = false;
            }
        }
        private void DisableNormalizeMode()
        {
            normalizeModeRb.Checked = false;
        }

        private void BrightAmountChart_MouseDown(object sender, MouseEventArgs e)
        {
            double x = brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            int xL = LeftPos;
            int xR = RightPos;

            isMoveLeftBoundary = (x > xL - 5) && (x < xL + 5);
            isMoveRightBoundary = (x > xR - 5) && (x < xR + 5); // мб может что-то вылезти

            // Проверка случая, когда движки расположены близко друг к другу
            if (isMoveLeftBoundary && isMoveRightBoundary)
            {
                isMoveLeftBoundary = 255 - xR < 5;
                isMoveRightBoundary = !isMoveLeftBoundary;

                //isMoveLeftBoundary = isMoveRightBoundary = false;
                //if (xL < 5) isMoveRightBoundary = true;
                //else if (255 - xR < 5) isMoveLeftBoundary = true;
                //else isMoveRightBoundary = true;
            }
        }

        private void BrightAmountChart_MouseUp(object sender, MouseEventArgs e)
        {
            isMoveLeftBoundary = false;
            isMoveRightBoundary = false;
        }

        private void BrightAmountChart_MouseMove(object sender, MouseEventArgs e)
        {
            int x = -1;
            try
            {
                x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (isMoveLeftBoundary && x == -1)
                {
                    MoveLeftBoundary(0);
                }
                if (isMoveRightBoundary && x == 256)
                {
                    MoveRightBoundary(255);
                }
            }

            if (x >= 0 && x <= 255)
            {
                if (IsFixBoundaries())
                {
                    //int dx = Math.Abs(LeftBoundaryPos - RightBoundaryPos);
                    int dx = Math.Abs(LeftPos - RightPos);

                    if (isMoveLeftBoundary && x + dx <= 255)
                    {
                        //if (x + dx <= 255)
                        //{
                        MoveLeftBoundary(x);
                        MoveRightBoundary(x + dx);
                        //}
                    }
                    else if (isMoveRightBoundary && x - dx >= 0)
                    {
                        //if (x - dx >= 0)
                        //{
                        MoveLeftBoundary(x - dx);
                        MoveRightBoundary(x);
                        //}
                    }
                }
                else
                {
                    if (isMoveLeftBoundary && x <= RightPos)
                    {
                        //if (x <= RightPos)
                        //{
                        MoveLeftBoundary(x);
                        //}
                    }
                    if (isMoveRightBoundary && x >= LeftPos)
                    {
                        //if (x >= LeftPos)
                        //{
                        MoveRightBoundary(x);
                        //}
                    }
                }
            }
        }

        private bool IsFixBoundaries()
        {
            return fixCb.Checked;
        }

        private void ChartsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            parentForm.SetImage(originImage); // ПОД ВОПРОСОМ
            MoveLeftBoundary(0);
            MoveRightBoundary(255);
            this.Hide();
        }

        
    }
}
