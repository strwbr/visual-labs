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
        StripLine leftBoundary = new StripLine();
        StripLine rightBoundary = new StripLine();


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
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < amountBright.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, amountBright[i]);
            }
            UpdateStripLine(out rightBoundary, GetLeftBoundaryPos());
        }

        private void UpdateStripLine(out StripLine stripLine, int x)
        {
            StripLine temp = new StripLine();
            temp.BackColor = Color.Red;
            temp.IntervalOffset = x;
            temp.BorderWidth = 1;
            stripLine = temp;

            chart1.ChartAreas[0].AxisX.StripLines.Add(rightBoundary);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateStripLine(out rightBoundary, GetLeftBoundaryPos());

        }

        private int GetLeftBoundaryPos()
        {
            return trackBar1.Value;
        }

    }
}
