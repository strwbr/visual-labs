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
            Bitmap temp = new Bitmap(image.Width, image.Height);
            for(int i = 0; i < image.Height; i++)
            {
                for(int k = 0; k < image.Width; k++)
                {
                    ushort bright = image.GetPixel(k, i).R;
                    temp.SetPixel(k, i, Color.FromArgb(bright, bright, bright));
                    if(bright >=L && bright <=R)
                    {
                        ushort newBright = (ushort)(255 * (bright - L)/ (R - L));
                        temp.SetPixel(k, i, Color.FromArgb(newBright, newBright, newBright));
                    }
                }
            }
            return temp;
        }

        public static Bitmap ChangeImageBright(Bitmap image, int L, int leftNewBright, int R, int rightNewBright)
        {
            Bitmap temp = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Height; i++)
            {
                for (int k = 0; k < image.Width; k++)
                {
                    ushort bright = image.GetPixel(k, i).R;
                    temp.SetPixel(k, i, Color.FromArgb(bright, bright, bright));

                    if (bright <= L)
                    {
                        temp.SetPixel(k, i, Color.FromArgb(leftNewBright, leftNewBright, leftNewBright));
                    }
                    if (bright >= R)
                    {
                        temp.SetPixel(k, i, Color.FromArgb(rightNewBright, rightNewBright, rightNewBright));
                    }
                }
            }
            return temp;
        }
    }
}
