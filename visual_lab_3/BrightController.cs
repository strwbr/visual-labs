using System.Drawing;

namespace visual_lab_3
{
    class BrightController
    {
        /* Отображение заданного диапазона яркостей [L,R] в диапазон [0,255]
         * Параметры: image - изображение, яркости которого необходимо изменить,
         *            L - левая граница диапазона яркостей для отображения,
         *            R - правая граница диапазона яркостей для отображения.
         * Возвращаемое значение: изображение с измененными яркостями.
         */
        public static Bitmap NormalizeBright(Bitmap image, int L, int R)
        {
            // Инициализация изображения, для которого будут задаваться яркости
            Bitmap temp = new Bitmap(image.Width, image.Height);
            // Проход по изображению image для получения его яркостей и их изменения
            for (int i = 0; i < image.Height; i++)
            {
                for (int k = 0; k < image.Width; k++)
                {
                    // Яркость текущего пикселя изображения image
                    ushort bright = image.GetPixel(k, i).R;
                    // Если текущее значение яркости принадлежит диапазону [L,R]
                    if (bright >= L && bright <= R)
                    {
                        // Расчет новой яркости
                        ushort newBright = (ushort)(255 * (bright - L) / (R - L));
                        // Установка пикселя с новой яркостью для соответствующего пикселя изображения temp
                        temp.SetPixel(k, i, Color.FromArgb(newBright, newBright, newBright));
                    } 
                    // Если не принадлежит
                    else
                        // Яркость пикселя изображения temp устанавливается равной яркости соответствующего пикселя изображения image
                        temp.SetPixel(k, i, Color.FromArgb(bright, bright, bright));
                }
            }
            return temp;
        }

        /* Отсечение яркостей в изображении
         * Параметры: image - изображение, яркости которого необходимо изменить,
         *            L - левая граница отсечения; до этого значения необходимо изменить яркости,
         *            leftNewBright - новое значение яркости пикселей левее L,
         *            R - правая граница отсечения; после значения необходимо изменить яркости,
         *            rightNewBright - новое значение яркости пикселей правее R.
         * Возвращаемое значение: изображение с измененными яркостями
         */
        public static Bitmap ChangeImageBright(Bitmap image, int L, ushort leftNewBright, int R, ushort rightNewBright)
        {
            // Инициализация изображения, для которого будут задаваться яркости
            Bitmap temp = new Bitmap(image.Width, image.Height);
            // Проход по изображению image для получения его яркостей и их изменения
            for (int i = 0; i < image.Height; i++)
            {
                for (int k = 0; k < image.Width; k++)
                {
                    // Яркость текущего пикселя изображения image
                    ushort bright = image.GetPixel(k, i).R;
                    // Если текущая яркость принадлежит левому отсечению 
                    if (bright <= L)
                        // Яркость соответсвующего пикселя изображения temp устанавляивается равной leftNewBright
                        temp.SetPixel(k, i, Color.FromArgb(leftNewBright, leftNewBright, leftNewBright));
                    // Если текущая яркость принадлежит правому отсечению 
                    else if (bright >= R)
                        // Яркость соответсвующего пикселя изображения temp устанавляивается равной rightNewBright
                        temp.SetPixel(k, i, Color.FromArgb(rightNewBright, rightNewBright, rightNewBright));
                    // Если текущая яркость не принадлежит ни одному из отсечений
                    else
                        // Яркость пикселя изображения temp устанавливается равной яркости соответствующего пикселя изображения image
                        temp.SetPixel(k, i, Color.FromArgb(bright, bright, bright));
                }
            }
            return temp;
        }
    }
}
