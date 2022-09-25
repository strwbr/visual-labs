using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Visual_lab_1
{
    // Класс, содержащий в себе методы для работы с изображением 
    class ImageController
    {
        /* Считывание байтов с файла 
         * Параметры: path - путь к файлу, с которого необходимо считать байты.
         * Возвращаемое значение: массив считанных байт.
         */
        public static byte[] ReadBytesFromFile(string path)
        {
            byte[] readBytes = File.ReadAllBytes(path);
            return readBytes;
        }

        /* Получение кодов яркости пикселей
         * Параметры: imageInfo - объект, содержащий информацию об изображении,
         *            shift - значение сдвига байтов,
         *            topLine - значение верхней границы изображения.
         * Возвращаемое значение: массив ushort (16-bit), содержащий коды яркости пикселей.
         */
        private static ushort[] GetPixels(ImageInfo imageInfo, int shift, int topLine)
        {
            // Инициализация массива пикселей
            // размер массива равен количеству пикселей с учетом значения верхней границы
            ushort[] pixels = new ushort[imageInfo.CountPixels - imageInfo.Width * topLine];
            // Временный массив, хранящий в себе байты, считанные с файла
            byte[] temp = imageInfo.ImageBytes;

            // Заполнение массива pixels, путем получения двух байт из 2-х соответствующих элементов массива temp
            // k - счетчик, начальное значение которого соответствует верхней границе, заданной пользователем
            for (int i = 0, k = imageInfo.Width * topLine * 2 + 4; k < temp.Length; i++, k += 2)
            {
                pixels[i] = (ushort)(GetTwoBytes(temp[k], temp[k + 1], shift) & 255);
            }

            return pixels;
        }

        /* Объединение двух байт
         * Параметры: first и second - байты, который необходимо объединить,
                      shift - байтовый сдвиг.
         * Возвращаемое значение: 16-битовое число - объединенные байты
         */
        private static ushort GetTwoBytes(byte first, byte second, int shift)
        {
            return (ushort)((first | (second << 8)) >> shift);
        }

        /* Создание объекта Bitmap из считанного файла со значениями сдвига и верхней границы, 
         * задаваемыми пользователем
         * Параметры: imageInfo - объект, содержащий информацию об изображении, из которого необходимо создать bitmap,
         *            shift - сдвиг байтов,
         *            topLine - верхняя граница.
         * Возвращаемое значение: объект Bitmap - созданное изображение
         */
        public static Bitmap CreateImage(ImageInfo imageInfo, int shift, int topLine)
        {
            // Получение ширины и высоты изображения,
            int width = imageInfo.Width;
            int height = imageInfo.Height - topLine;
            // Получение массива кодов яркостей пикселей
            ushort[] pixels = GetPixels(imageInfo, shift, topLine);

            // Создание объекта Bitmap с шириной width и высотой height.
            Bitmap image = new Bitmap(width, height);
            // Счетчик количества пикселей
            int pixelNum = 0;
            // Задание цветов у пикселей в bitmap
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    ushort color = pixels[pixelNum];
                    // Значения цветов R, G, B равны
                    image.SetPixel(k, i, Color.FromArgb(color, color, color));
                    //image.SetPixel(k, i, Color.FromArgb(pixels[pixelNum], pixels[pixelNum], pixels[pixelNum]));
                    pixelNum++;
                }
            }
            return image;
        }

        public static Bitmap NearestNeighborScaling(Bitmap fragment, int scale)
        {
            int width = fragment.Width;
            int height = fragment.Height;

            int newWidth = width * scale;
            int newHeight = height * scale;

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
                    scaledPixels[i * newWidth + k] = fragment.GetPixel(x2, y2).R;
                }
            }

            Bitmap scaledImage = new Bitmap(newWidth, newHeight);
            int pixelNum = 0;
            // Задание цветов у пикселей в bitmap
            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    ushort color = scaledPixels[pixelNum];
                    // Значения цветов R, G, B равны
                    scaledImage.SetPixel(k, i, Color.FromArgb(color, color, color));
                    //image.SetPixel(k, i, Color.FromArgb(pixels[pixelNum], pixels[pixelNum], pixels[pixelNum]));
                    pixelNum++;
                }
            }
            return scaledImage;
        }

        public static Bitmap BilinearInterpolationScaling(Bitmap fragment, int scale)
        {
            int width = fragment.Width;
            int height = fragment.Height;

            int newWidth = width * scale;
            int newHeight = height * scale;

            float xRatio = ((float)(width - 1)) / newWidth;
            float yRatio = ((float)(height - 1)) / newHeight;
            int offset = 0, index;

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

                    int a = fragment.GetPixel(x, y).R;
                    int b = fragment.GetPixel(x + 1, y).R;
                    int c = fragment.GetPixel(x, y + 1).R;
                    int d = fragment.GetPixel(x + 1, y + 1).R;

                    scaledPixels[offset] =
                        (ushort)(a * (1 - xDif) * (1 - yDif) + b * xDif * (1 - yDif) + c * (1 - xDif) * yDif + d * xDif * yDif);
                    offset++;
                }
            }

            Bitmap scaledImage = new Bitmap(newWidth, newHeight);
            int pixelNum = 0;
            // Задание цветов у пикселей в bitmap
            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    ushort color = scaledPixels[pixelNum];
                    // Значения цветов R, G, B равны
                    scaledImage.SetPixel(k, i, Color.FromArgb(color, color, color));
                    //image.SetPixel(k, i, Color.FromArgb(pixels[pixelNum], pixels[pixelNum], pixels[pixelNum]));
                    pixelNum++;
                }
            }
            return scaledImage;
        }


        // возвращать Bitmap
        public static void ResizeNN(ImageInfo imageInfo)
        {
            ushort[] origPix = GetPixels(imageInfo, 0, 2900);
            int w1 = 500, h1 = 100;
            int w2 = w1 * 10, h2 = h1 * 10;

            ushort[] resizePix = new ushort[w2 * h2];
            Bitmap resizeImg = new Bitmap(w2, h2);

            int x_ratio = (int)((w1 << 16) / w2) + 1;
            int y_ratio = (int)((h1 << 16) / h2) + 1;

            int x2, y2;
            for (int i = 0; i < h2; i++)
            {
                for (int j = 0; j < w2; j++)
                {
                    x2 = ((j * x_ratio) >> 16);
                    y2 = ((i * y_ratio) >> 16);
                    resizePix[(i * w2) + j] = origPix[(y2 * w1) + x2];
                }
            }
            int count1 = 0;

            // В отдельный метод вынести
            for (int i = 0; i < h2; i++)
            {
                for (int k = 0; k < w2; k++)
                {
                    resizeImg.SetPixel(k, i, Color.FromArgb(resizePix[count1], resizePix[count1], resizePix[count1]));
                    count1++;
                }
            }
            resizeImg.Save("imgResize.jpg", ImageFormat.Jpeg);
        }

        public static void ResizeBilinear(ImageInfo imageInfo)
        {
            ushort[] origPix = GetPixels(imageInfo, 0, 2900);

            ushort min = origPix[0], max = origPix[0];
            for (int i = 1; i < origPix.Length; i++)
            {
                if (max < origPix[i]) max = origPix[i];
                if (min > origPix[i]) min = origPix[i];
            }


            int w1 = 500, h1 = 100;
            int w2 = w1 * 10, h2 = h1 * 10;

            ushort[] resizePix = new ushort[w2 * h2];
            Bitmap resizeImg = new Bitmap(w2, h2);

            int A, B, C, D, x, y, index;
            ushort gray;
            float x_ratio = ((float)(w1 - 1)) / w2;
            float y_ratio = ((float)(h1 - 1)) / h2;
            float x_diff, y_diff, ya, yb;
            int offset = 0;
            for (int i = 0; i < h2; i++)
            {
                for (int j = 0; j < w2; j++)
                {
                    x = (int)(x_ratio * j);
                    y = (int)(y_ratio * i);
                    x_diff = (x_ratio * j) - x;
                    y_diff = (y_ratio * i) - y;
                    index = y * w1 + x;

                    // range is 0 to 255 thus bitwise AND with 0xff
                    D = origPix[index + w1 + 1];
                    A = origPix[index];
                    B = origPix[index + 1];
                    C = origPix[index + w1];


                    // Y = A(1-w)(1-h) + B(w)(1-h) + C(h)(1-w) + Dwh
                    gray = (ushort)(
                            A * (1 - x_diff) * (1 - y_diff) + B * (x_diff) * (1 - y_diff) +
                            C * (y_diff) * (1 - x_diff) + D * (x_diff * y_diff)
                            );

                    //gray = (ushort)(255 * ((resizePix[offset] - min) / (max - min)));

                    resizePix[offset++] = gray;
                }
            }

            int count1 = 0;

            // В отдельный метод вынести
            for (int i = 0; i < h2; i++)
            {
                for (int k = 0; k < w2; k++)
                {
                    resizeImg.SetPixel(k, i, Color.FromArgb(resizePix[count1], resizePix[count1], resizePix[count1]));
                    count1++;
                }
            }
            resizeImg.Save("imgBilinear.jpg", ImageFormat.Jpeg);
        }
    }
}
