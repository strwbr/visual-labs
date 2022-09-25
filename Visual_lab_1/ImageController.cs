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

            // Создание объекта Bitmap
            Bitmap image;
            // Заполнение пикселями - установка цветов
            FillBitmap(pixels, width, height, out image);

            return image;
        }

        private static void FillBitmap(ushort[] pixels, int width, int height, out Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(width, height);
            // Счетчик количества пикселей
            int pixelNum = 0;
            // Задание цветов у пикселей в bitmap
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    // Значения цветов R, G, B равны
                    temp.SetPixel(k, i, Color.FromArgb(pixels[pixelNum], pixels[pixelNum], pixels[pixelNum]));
                    pixelNum++;
                }
            }
            bitmap = temp;
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

            Bitmap scaledImage;
            FillBitmap(scaledPixels, newWidth, newHeight, out scaledImage);

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

            Bitmap scaledImage;
            FillBitmap(scaledPixels, newWidth, newHeight, out scaledImage);

            return scaledImage;
        }
    }
}
