using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_lab_3
{
    public partial class ChartsForm : Form
    {
        Dictionary<ushort, int> data = new Dictionary<ushort, int>();

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
            int[] countPixs = new int[256];
            ushort brightValue = 0;
            foreach(ushort val in temp)
            {
                countPixs[val]++;
            }
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
        }


    }
}
