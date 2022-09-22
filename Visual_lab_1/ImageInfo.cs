namespace Visual_lab_1
{
    // Класс, хранящий в себе информацию об изображении
    class ImageInfo
    {
        // массив считанных с файла байт
        public byte[] ImageBytes { get; private set; }
        // количество пикселей в изображении
        public int CountPixels { get; private set; }
        // ширина изображения
        public int Width { get; private set; }
        // высота изображения
        public int Height { get; private set; }

        public ImageInfo(string path)
        {
            ImageBytes = ImageController.ReadBytesFromFile(path);
            CountPixels = (ImageBytes.Length - 4) / 2;
            Width = ImageBytes[0] | (ImageBytes[1] << 8);
            Height = ImageBytes[2] | (ImageBytes[3] << 8);
        }
    }
}
