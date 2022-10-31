namespace Visual_lab_1
{
    // Класс, хранящий в себе информацию об изображении
    class ImageInfo
    {
        // массив считанных с файла байт
        public byte[] ImageBytes { get; private set; }
        // массив яркостей пикселей
        public ushort[] PixelBrightness { get; private set; }
        // количество пикселей в изображении
        public int CountPixels { get; private set; }
        // ширина изображения
        public int Width { get; private set; }
        // высота изображения
        public int Height { get; private set; }

        /* Конструктор класса
         * Параметр: path - путь к файлу, с которого считывается изображение
         */
        public ImageInfo(string path)
        {
            // Считывание байт с файла
            ImageBytes = ImageController.ReadBytesFromFile(path);
            // Вычисление количества пикселей в изображении
            CountPixels = (ImageBytes.Length - 4) / 2;
            // Получение ширины изображения (первые 2 считанных байта)
            Width = ImageBytes[0] | (ImageBytes[1] << 8);
            // Получение высоты изображения (вторые 2 считанных байта)
            Height = ImageBytes[2] | (ImageBytes[3] << 8);
            // Получение яркостей пикселей изображения
            PixelBrightness = GetPixelBrightness();
        }

        /* Получение яркостей пикселей изображения
         * Возвращаемое значение: массив яркостей пикселей
         */
        private ushort[] GetPixelBrightness()
        {
            // Инициализацияя массива с яркостями
            ushort[] temp = new ushort[CountPixels];
            for (int i = 0, k = 4; k < ImageBytes.Length; i++, k+=2)
            {
                // Получение 2-х байт
                temp[i] = (ushort)((ImageBytes[k] | (ImageBytes[k + 1] << 8)) & 1023);
            }
            return temp;
        }
    }
}
