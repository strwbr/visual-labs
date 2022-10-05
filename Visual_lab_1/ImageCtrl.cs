using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Visual_lab_1
{
    class ImageCtrl
    {
        public static byte[] ReadBytesFromFile(string path)
        {
            byte[] readBytes = File.ReadAllBytes(path);
            return readBytes;
        }

        public static ushort[] GetBrightness(ImageInfo imageInfo, int topLine)
        {
            ushort[] brightness = new ushort[imageInfo.CountPixels - imageInfo.Width * topLine];

            for (int i = 0, k = imageInfo.Width * topLine; k < imageInfo.PixelBrightness.Length; i++, k++)
            {
                brightness[i] = imageInfo.PixelBrightness[k];
            }

            return brightness;
        }


        public static Bitmap CreateImage(ImageInfo imageInfo, ushort[] brightness, int shift, int topLine)
        {
            int width = imageInfo.Width;
            int height = imageInfo.Height - topLine;

            ushort[] temp = GetChannelsValues(brightness, shift);
            return FillBitmap(temp, width, height);
        }

        public static Bitmap CreateImage(ushort[] brightness, int w, int h, int shift)
        {
            ushort[] temp = GetChannelsValues(brightness, shift);
            return FillBitmap(temp, w, h);
        }

        private static ushort[] GetChannelsValues(ushort[] brightness, int shift)
        {
            ushort[] channels = new ushort[brightness.Length];
            for(int i = 0; i < brightness.Length; i++)
            {
                channels[i] = (ushort)((brightness[i] >> shift) & 255);
            }
            return channels;
        }

        private static Bitmap FillBitmap(ushort[] pixels, int width, int height)
        {
            // Инициализация объекта типа Bitmap с шириной width и высотой height
            Bitmap temp = new Bitmap(width, height);
            // Счетчик количества пикселей
            int pixelNum = 0;
            // Задание яркостей пикселей в bitmap
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    // Значения каналов R, G, B равны
                    temp.SetPixel(k, i, Color.FromArgb(pixels[pixelNum], pixels[pixelNum], pixels[pixelNum]));
                    pixelNum++;
                }
            }
            return temp;
        }


        private static ushort[,] OneDimToTwoDim(ushort[] pix, int width, int height)
        {
            int w = width, h = height;
            ushort[,] temp = new ushort[h, w];
            int count = 0;
            for (int i = 0; i < h; i++)
            {
                for (int k = 0; k < w; k++)
                {
                    temp[i, k] = pix[count];
                    count++;
                }
            }
            return temp;
        }
    }
}
