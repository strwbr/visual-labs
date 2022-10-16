using System;
using System.Drawing;
using System.IO;

namespace Visual_lab_1
{
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

            // Если минимальная и максимальная яркости равны,
            // то нормирование яркостей не будет выполняться и метод вернет исходны массив
            if (min == max) return pixels;

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

        /* Масштабирование изображения в заданное число раз методом ближайшего соседа
         * Параметры: pixels - массив яркостей пикселей изображения, которое необходимо масштабировать,
         *            oldWidth - первоначальная длина изображения,
         *            oldHeight - первоначальная высота изображения,
         *            scale - значение масштабирования
         * Возвращаемое значение: массив яркостей пикселей масштабированного изображения
         */
        public static ushort[] NearestNeighborScaling(ushort[] pixels, int oldWidth, int oldHeight, int scale)
        {
            // Вычисление новых значений ширины и высоты
            int newWidth = oldWidth * scale;
            int newHeight = oldHeight * scale;

            // Инициализация массива яркостей пикселей масштабированного изображения
            // Размер массива равен количеству пикселей в изображении после масштабирования
            ushort[] scaledPixels = new ushort[newWidth * newHeight];

            // Соотношение по горизонтали между исходным изображением и новым
            double scaleX = oldWidth / (double)newWidth;
            // Соотношение по вертикали между исходным изображением и новым
            double scaleY = oldHeight / (double)newHeight;

            // Счетчик количества пикселй
            int pixelNum = 0;
            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    // Сопоставление координат с исходным изображением
                    double newX = Math.Floor(k * scaleX);
                    double newY = Math.Floor(i * scaleY);
                    // Добавление нового пикселя в массив по полученным координатам
                    scaledPixels[pixelNum] = pixels[(int)(newY * oldWidth + newX)];
                    // Увеличение счетчика на 1
                    pixelNum++;
                }
            }
            return scaledPixels;
        }

        /* Масштабирование изображения в заданное число раз методом билинейной субпиксельной интерполяции
         * Параметры: pixels - массив яркостей пикселей изображения, которое необходимо масштабировать,
         *            oldWidth - первоначальная длина изображения,
         *            oldHeight - первоначальная высота изображения,
         *            scale - значение увеличения
         * Возвращаемое значение: массив яркостей пикселей масштабированного изображения
         */
        public static ushort[] BilinearInterpolationScaling(ushort[] pixels, int oldWidth, int oldHeight, int scale)
        {
            // Вычисление новых значений ширины и высоты
            int newWidth = oldWidth * scale;
            int newHeight = oldHeight * scale;

            // Инициализация массива яркостей пикселей масштабированного фрагмента
            // Размер массива равен количеству пикселей в фрагменте после масштабирования
            ushort[] scaledPixels = new ushort[newWidth * newHeight];

            // Соотношение по горизонтали между исходным изображением и новым
            float scaleX = ((float)(oldWidth - 1)) / newWidth;
            // Соотношение по вертикали между исходным изображением и новым
            float scaleY = ((float)(oldHeight - 1)) / newHeight;
            
            // Счетчик количества пикселей нового изображения
            int pixelNum = 0;
            for (int i = 0; i < newHeight; i++)
            {
                for (int k = 0; k < newWidth; k++)
                {
                    // Сопоставление координат с исходным изображением
                    int newX = (int)(scaleX * k);
                    int newY = (int)(scaleY * i);
                    // Вычисление расстояния от нового пикселя до пикселя i1 (верхнего левого)
                    float dx = scaleX * k - newX;
                    float dy = scaleY * i - newY;
                    // Координата 1-го из 4-х смежных пикселей
                    int first = newY * oldWidth + newX;
                    // Яркости 4-х смежных пикселей
                    int i1 = pixels[first]; // Верхний левый
                    int i2 = pixels[first + 1]; // Верхний правый
                    int i3 = pixels[first + oldWidth]; // Нижний левый
                    int i4 = pixels[first + oldWidth + 1]; // Нижний правый

                    // Вычисление яркости смещенного пикселя и добавление в массив scaledPixels
                    scaledPixels[pixelNum] =
                        (ushort)(i1 * (1 - dx) * (1 - dy) + i2 * dx * (1 - dy) + i3 * (1 - dx) * dy + i4 * dx * dy);
                    pixelNum++;
                }
            }
            return scaledPixels;
        }

        /* Получение массива яркостей обзорного изображения (ОИ)
         * Параметры: brightness - яркости пикселей изображения, для которого необходимо построить ОИ,
         *            width - ширина первоначального изображения,
         *            height - высота первоначального изображения,
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
            for (int i = 0; i < height; i += m)
            {
                for (int k = 0; k < width; k += m)
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
