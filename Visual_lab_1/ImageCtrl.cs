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
            for (int i = 0; i < brightness.Length; i++)
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

        public static ushort[] NormalizeBrightness(ushort[] fragPixels)
        {
            // Вычисление минимальной и максимальной яркости пикселей фрагмента
            // Первоначально задаем, что яркость 1-го пикселя фрагмента минимальна и максимальна
            ushort min = fragPixels[0];
            ushort max = fragPixels[0];

            for (int i = 0; i < fragPixels.Length; i++)
            {
                if (min > fragPixels[i]) min = fragPixels[i];
                if (max < fragPixels[i]) max = fragPixels[i];
            }

            ushort[] normalizePixsels = new ushort[fragPixels.Length];
            for (int i = 0; i < normalizePixsels.Length; i++)
            {
                normalizePixsels[i] = (ushort)(255 * (fragPixels[i] - min) / (max - min));
            }

            //Bitmap normalizeFrag = new Bitmap(fragment.Width, fragment.Height);
            //for (int i = 0; i < fragment.Height; i++)
            //{
            //    for (int k = 0; k < fragment.Width; k++)
            //    {
            //        ushort color = fragment.GetPixel(k, i).R;
            //        color = (ushort)(255 * (color - min) / (max - min));
            //        normalizeFrag.SetPixel(k, i, Color.FromArgb(color, color, color));
            //    }
            //}
            return normalizePixsels;
        }

        public static ushort[] NearestNeighborScaling(ushort[] fragPixels, int size, int scale)
        {
            // Получение ширины и высоты изначального фрагмента
            int width = size;
            int height = size;

            // Вычисление новых значений ширины и высоты
            int newWidth = width * scale;
            int newHeight = height * scale;

            // Инициализация массива яркостей пикселей увеличенного фрагмента.
            // Размер массива равен количеству пикселей в фрагменте после увеличения.
            ushort[] scaledPixels = new ushort[newWidth * newHeight];

            int xRatio = ((width << 16) / newWidth) + 1;
            int yRatio = ((height << 16) / newHeight) + 1;

            int x2, y2;
            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    x2 = (k * xRatio) >> 16;
                    y2 = (i * yRatio) >> 16;

                    scaledPixels[i * newWidth + k] = fragPixels[y2 * width + x2];
                }
            }
            return scaledPixels;
        }

        public static ushort[] BilinearInterpolationScaling(ushort[] fragPixels, int size, int scale)
        {
            // Получение ширины и высоты изначального фрагмента
            int width = size;
            int height = size;

            // Вычисление новых значений ширины и высоты
            int newWidth = width * scale;
            int newHeight = height * scale;

            float xRatio = ((float)(width - 1)) / newWidth;
            float yRatio = ((float)(height - 1)) / newHeight;
            int offset = 0, index;

            // Инициализация массива яркостей пикселей увеличенного фрагмента.
            // Размер массива равен количеству пикселей в фрагменте после увеличения.
            ushort[] scaledPixels = new ushort[newWidth * newHeight];

            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    int x = (int)(xRatio * k);
                    int y = (int)(yRatio * i);
                    float xDif = xRatio * k - x;
                    float yDif = yRatio * i - y;
                    index = y * width + x;

                    int a = fragPixels[index];
                    int b = fragPixels[index + 1];
                    int c = fragPixels[index + width];
                    int d = fragPixels[index + width + 1];

                    scaledPixels[offset] =
                        (ushort)(a * (1 - xDif) * (1 - yDif) + b * xDif * (1 - yDif) + c * (1 - xDif) * yDif + d * xDif * yDif);
                    offset++;
                }
            }

            return scaledPixels;
        }

        //public static ushort[] OverviewImage(ImageInfo image)
        //{
        //    int m = 5;
        //    Bitmap overviewImage = new Bitmap(image.Width / m, image.Height / m);
        //    for (int i = 0, j = 0; i < image.Height; i += m, j++)
        //    {
        //        for (int k = 0, t = 0; k < image.Width; k += m, t++)
        //        {
        //            ushort color = image.GetPixel(k, i).R;
        //            overviewImage.SetPixel(t, j, Color.FromArgb(color, color, color));
        //        }
        //    }
        //    return overviewImage;
        //}

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
