using System.Drawing;
using System.IO;

namespace Visual_lab_1
{
    class ImageCtrl
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

        /* Получение яркостей пикселей изображения с учетом верхней границы
         * Параметры: imageInfo - объект, хранящий в себе считанные с файла яркости пикселей,
         *            topLine - значение верхней границы
         * Возвращаемое значение: массив яркостей пикселей обрезанного изображения
         */
        public static ushort[] GetBrightness(ImageInfo imageInfo, int topLine)
        {
            // Инициализация массива с яркостями пикселей обрезанного изображения;
            // размер массива равен новому количеству пикселей в обрезанном изображении
            ushort[] brightness = new ushort[imageInfo.CountPixels - imageInfo.Width * topLine];

            // Заполнение массива яркостей обрезанного изображения
            // k - счетчик, начальное значение которого соответствует верхней границе, заданной пользователем
            for (int i = 0, k = imageInfo.Width * topLine; k < imageInfo.PixelBrightness.Length; i++, k++)
            {
                brightness[i] = imageInfo.PixelBrightness[k];
            }

            return brightness;
        }

        /* Создание изображения (объект Bitmap) с задаваемым размером сдвигом кодов из массива 2-байтных яркостей пикселей 
         * Параметры: pixels - 2-байтные яркости пикселей, из которых создается изображение,
         *            width - ширина создаваемого изображения,
         *            height - высота создаваемого изображения,
         *            shift - сдвиг кодов пикселей
         * Возвращаемое значение: построенное изображение (Bitmap)
         */
        public static Bitmap CreateImage(ushort[] pixels, int width, int height, int shift)
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
                    // Получение 8-битных яркостей пикселей (с учетом сдвига) из 2-байтных кодов
                    // путем сдвига 2-байтного кода вправо на shift битов и логического умножения на 255
                    ushort color = (ushort)((pixels[pixelNum] >> shift) & 255);
                    // Значения каналов R, G, B равны
                    temp.SetPixel(k, i, Color.FromArgb(color, color, color));
                    // Увеличение счетчика на 1
                    pixelNum++;
                }
            }
            return temp;
        }

        /* Нормирование яркостей пикселей
         * Параметр: pixels - пиксели, яркости которых надо нормировать
         * Возращаемое значение: массив нормированных яркостей
         */
        public static ushort[] NormalizeBrightness(ushort[] pixels)
        {
            // Вычисление диапазона яркостей в массиве
            // Первоначально яркость 1-го пикселя массива и минимальна и максимальна
            ushort min = pixels[0];
            ushort max = pixels[0];
            // Проход по массиву пикселей - получение минимальной и максимальной яркостей
            for (int i = 0; i < pixels.Length; i++)
            {
                if (min > pixels[i]) min = pixels[i];
                if (max < pixels[i]) max = pixels[i];
            }

            // Инициализация массива нормированных яркостей; размер массива равен размеру исходного массива
            ushort[] normalizePixels = new ushort[pixels.Length];
            // Получение новых, нормированных, значений яркостей
            for (int i = 0; i < normalizePixels.Length; i++)
            {
                // Приведение диапазона яркостей (от min до max) к новому (от 0 до 255)
                normalizePixels[i] = (ushort)(255 * (pixels[i] - min) / (max - min));
            }
            return normalizePixels;
        }

        /* Увеличение изображения в заданное число раз методом ближайшего соседа
         * Параметры: pixels - массив яркостей пикселей изображения, которое необходимо увеличить,
         *            size - первоначальный размер изображения (= длине = высот изображения),
         *            scale - значение увеличения
         * Возвращаемое значение: массив яркостей пикселей увеличенного изображения
         */
        public static ushort[] NearestNeighborScaling(ushort[] pixels, int size, int scale)
        {
            // Инициализация первоначальных значений ширины и высоты изображения
            // Т.к. фрагмент - квадратный, то они равны параметру size
            int oldWidth, oldHeight;
            oldWidth = oldHeight = size;

            // Вычисление новых значений ширины и высоты
            int newWidth = oldWidth * scale;
            int newHeight = oldHeight * scale;

            // Инициализация массива яркостей пикселей увеличенного фрагмента
            // Размер массива равен количеству пикселей в фрагменте после увеличения
            ushort[] scaledPixels = new ushort[newWidth * newHeight];

            int xRatio = ((oldWidth << 16) / newWidth) + 1;
            int yRatio = ((oldHeight << 16) / newHeight) + 1;

            int x2, y2;
            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    x2 = (k * xRatio) >> 16;
                    y2 = (i * yRatio) >> 16;

                    scaledPixels[i * newWidth + k] = pixels[y2 * oldWidth + x2];
                }
            }
            return scaledPixels;
        }

        /* Увеличение изображения в заданное число раз методом билинейной субпиксельной интерполяции
         * Параметры: pixels - массив яркостей пикселей изображения, которое необходимо увеличить,
         *            size - первоначальный размер изображения (= длине = высот изображения),
         *            scale - значение увеличения
         * Возвращаемое значение: массив яркостей пикселей увеличенного изображени
         */
        public static ushort[] BilinearInterpolationScaling(ushort[] pixels, int size, int scale)
        {
            // Получение ширины и высоты изначального фрагмента
            int oldWidth = size;
            int oldHeight = size;

            // Вычисление новых значений ширины и высоты
            int newWidth = oldWidth * scale;
            int newHeight = oldHeight * scale;

            float xRatio = ((float)(oldWidth - 1)) / newWidth;
            float yRatio = ((float)(oldHeight - 1)) / newHeight;
            int offset = 0, index;

            // Инициализация массива яркостей пикселей увеличенного фрагмента
            // Размер массива равен количеству пикселей в фрагменте после увеличения
            ushort[] scaledPixels = new ushort[newWidth * newHeight];

            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    int x = (int)(xRatio * k);
                    int y = (int)(yRatio * i);
                    float xDif = xRatio * k - x;
                    float yDif = yRatio * i - y;
                    index = y * oldWidth + x;

                    int a = pixels[index];
                    int b = pixels[index + 1];
                    int c = pixels[index + oldWidth];
                    int d = pixels[index + oldWidth + 1];

                    scaledPixels[offset] =
                        (ushort)(a * (1 - xDif) * (1 - yDif) + b * xDif * (1 - yDif) + c * (1 - xDif) * yDif + d * xDif * yDif);
                    offset++;
                }
            }
            return scaledPixels;
        }

        /* Получение массива яркостей обзорного изображения (ОИ)
         * Параметры: brightness - яркости пикселей изображения, для которого необходимо построить ОИ,
         *            width - ширина первоначального изображения,
         *            height - выоста первоначального изображения,
         *            m - значение прореживания (во сколько раз уменьшатся длина и высота исходного иозбражения)
         */
        public static ushort[] OverviewImage(ushort[] brightness, int width, int height, int m)
        {
            // Инициализация массива яркостей ОИ;
            // ширина и высота ОИ меньше исходных в m раз
            ushort[] overviewPixels = new ushort[width / m * height / m];
            // Счетчик количества пикселей
            int pixelNum = 0;
            // Прореживание исходного массива brightness
            // Берется каждая m-я строка, а в ней каждый m-й пиксель
            for (int i = 0, j = 0; i < height; i += m, j++)
            {
                for (int k = 0, t = 0; k < width; k += m, t++)
                {
                    overviewPixels[pixelNum] = brightness[i * width + k];
                    pixelNum++;
                }
            }
            return overviewPixels;
        }

        /* Получение 8-битных яркостей пикселей (с учетом сдвига) из 2-байтных кодов, считанных с файла
        * Параметры: brightness - 2-байтные яркости пикселей, считанные из файла,
        *            shift - сдвиг кодов пикселей
        * Возвращаемое значение: массив 8-битных яркостей пикселей
        */
        //private static ushort[] GetChannelsValues(ushort[] brightness, int shift)
        //{
        //    // Инициализация массива 8-битных яркостей; размер массива равен размеру массива brightness
        //    ushort[] channels = new ushort[brightness.Length];
        //    // Заполнение массива channels путем сдвига 2-байтного кода вправо на shift битов и логического умножения на 255 
        //    for (int i = 0; i < brightness.Length; i++)
        //    {
        //        channels[i] = (ushort)((brightness[i] >> shift) & 255);
        //    }
        //    return channels;
        //}

        //public static Bitmap CreateImage(ImageInfo imageInfo, ushort[] brightness, int shift, int topLine)
        //{
        //    int width = imageInfo.Width;
        //    int height = imageInfo.Height - topLine;

        //    ushort[] temp = GetChannelsValues(brightness, shift);
        //    return FillBitmap(temp, width, height);
        //}

        /* Создание изображения (объект Bitmap) с задаваемым размером сдвигом кодов из массива яркостей пикселей
         * Параметры: brightness - яркости пикселей, из которых создается изображение,
         *            width - ширина создаваемого изображения,
         *            height - высота создаваемого изображения,
         *            shift - сдвиг кодов пикселей
         * Возвращаемое значение: построенное изображение (Bitmap)
         */
        //public static Bitmap CreateImage(ushort[] brightness, int width, int height, int shift)
        //{
        //    // Получение 8-битных яркостей пикселей
        //    ushort[] temp = GetChannelsValues(brightness, shift);
        //    // Установка яркостей пикселей у изображения и возврат полученного изображения
        //    return FillBitmap(temp, width, height);
        //}

        //private static ushort[,] OneDimToTwoDim(ushort[] pix, int width, int height)
        //{
        //    int w = width, h = height;
        //    ushort[,] temp = new ushort[h, w];
        //    int count = 0;
        //    for (int i = 0; i < h; i++)
        //    {
        //        for (int k = 0; k < w; k++)
        //        {
        //            temp[i, k] = pix[count];
        //            count++;
        //        }
        //    }
        //    return temp;
        //}
    }
}
