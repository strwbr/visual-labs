using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_lab_3
{
    class BrightController
    {
        public static Bitmap NormalizeBright(Bitmap image, int L, int R)
        {
            for(int i = 0; i < image.Height; i++)
            {
                for(int k = 0; k < image.Width; k++)
                {
                    ushort bright = image.GetPixel(k, i).R; 
                    if(bright >=L && bright <=R)
                    {
                        ushort newBright = (ushort)(255 * (bright - L)/ (R - L));
                        image.SetPixel(k, i, Color.FromArgb(newBright, newBright, newBright));
                    }
                }
            }
            return image;
        }
    }
}
