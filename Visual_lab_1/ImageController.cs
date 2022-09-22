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
            for (int i = 0, k = imageInfo.Width  * topLine * 2 + 4; k < temp.Length; i++, k += 2)
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
                    // Значения цветов R, G, B равны
                    image.SetPixel(k, i, Color.FromArgb(pixels[pixelNum], pixels[pixelNum], pixels[pixelNum]));
                    pixelNum++;
                }
            }
            return image;
        }
    }
}
