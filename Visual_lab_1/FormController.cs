using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Visual_lab_1
{
    // Класс, содержащий обработчики событий для элементов пользовательского интерфейса
    public partial class FormController : Form
    {
        // Информация об изображении, видеоданные которого загружены из файла
        ImageInfo imageInfo;
        // Текущее изображение, с параметрами, заданными пользователем
        Bitmap currentImage;
        // Фрагмент изображения, выбранный пользователем
        Bitmap fragment;
        // Верхняя граница изображения (при запуске приложения граница = 0)
        int topLines = 0;

        const int fragSize = 60;

        ushort[] currentPixels;
        ushort[] fragmentPixels;

        public FormController()
        {
            InitializeComponent();

            // Добавление обработчиков событий на элементы интерфейса:
            // клик по кнопке "Загрузить"
            loadFileBtn.Click += LoadFileBtn_Click;
            // клик по кнопке "<-- задать"
            setTopLinesBtn.Click += SetTopLinesBtn_Click;
            // движение курсора по изображению
            displayedPicturePanel.MouseMove += DisplayedPicturePanel_MouseMove;
            // нажатие клавиши мыши по изображению
            displayedPicturePanel.MouseClick += DisplayedPicturePanel_MouseClick;
            // на радио-кнопки из группы "Сдвигать коды на"
            for (int i = 0; i < shiftCodesGb.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)shiftCodesGb.Controls[i];
                rb.CheckedChanged += ShiftCodesRb_CheckedChanged;
            }
            // на радио-кнопки из группы "Увеличить в:"
            for (int i = 0; i < scaleValueGb.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)scaleValueGb.Controls[i];
                rb.CheckedChanged += scaleValueRb_CheckedChanged;
            }
        }

        private void scaleValueRb_CheckedChanged(object sender, EventArgs e)
        {
            if (fragmentPixels != null)
            {
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
            }
        }

        private int GetScaleValue()
        {
            int scaleValue = 1;
            for (int i = 0; i < scaleValueGb.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)scaleValueGb.Controls[i];
                if (rb.Checked)
                    scaleValue = Convert.ToInt32(rb.Text);
            }
            return scaleValue;
        }

        private void DisplayedPicturePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (imageInfo != null)
            {
                fragmentPixels = GetImageFragment(e.Location, fragSize);
                //lensPc.Image = fragment;
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
            }
        }

        private void SetFragment(ushort[] fragPixels, bool normalize, bool interpolate)
        {
            if (fragPixels != null)
            {
                Bitmap frag;
                int scale = GetScaleValue();

                if (normalize) fragPixels = ImageCtrl.NormalizeBrightness(fragPixels);

                fragPixels = interpolate
                    ? ImageCtrl.BilinearInterpolationScaling(fragPixels, fragSize, scale)
                    : ImageCtrl.NearestNeighborScaling(fragPixels, fragSize, scale);

                frag = ImageCtrl.CreateImage(fragPixels, fragSize * scale, fragSize * scale, GetShiftValue());

                lensPc.Image = frag;
            }
        }

        //private void SetFragment(Bitmap frag, bool normalize, bool interpolate)
        //{
        //    if (normalize) frag = ImageController.NormalizeBrightness(frag);

        //    frag = interpolate
        //        ? ImageController.BilinearInterpolationScaling(frag, GetScaleValue())
        //        : ImageController.NearestNeighborScaling(frag, GetScaleValue());

        //    lensPc.Image = frag;
        //}

        private ushort[] GetImageFragment(Point clickLocation, int fragSize)
        {
            int radius = fragSize / 2;
            int x, y;

            x = clickLocation.X - radius;
            y = clickLocation.Y - radius;

            if (clickLocation.X - radius < 0) x = 0;
            if (clickLocation.Y - radius < 0) y = 0;

            if (clickLocation.X + radius > currentImage.Width) x = currentImage.Width - fragSize;
            if (clickLocation.Y + radius > currentImage.Height) y = currentImage.Height - fragSize;

            ushort[] fragPixels = new ushort[fragSize * fragSize];
            int pixelNum = 0;
            for (int i = y; i < y + fragSize; i++)
            {
                for (int k = x; k < x + fragSize; k++)
                {
                    fragPixels[pixelNum] = currentPixels[imageInfo.Width * i + k];
                    pixelNum++;
                }
            }
            return fragPixels;
        }

        private void interpolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (fragmentPixels != null)
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
        }

        private void normalizeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (fragmentPixels != null)
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
        }

        private void createOverviewImageBtn_Click(object sender, EventArgs e)
        {
            if (imageInfo != null)
            {
                overviewImagePb.Image = ImageController.OverviewImage(currentImage);
            }
            else ShowWarning(
              "Изображение отсутствует. Загрузите файл формата .mbv, воспользовавшись кнопкой \"Загрузить\".",
              "Файл не загружен");
        }

        /* Обработчик нажатия на кнопку "Загрузить" для загрузки файла .mbv
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии. 
         */
        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            // Получение пути к файлу, выбранному пользователем
            string path = GetFile();

            if (path != null)
            {
                // Создание объекта с информацией об изображении
                imageInfo = new ImageInfo(path);

                currentPixels = ImageCtrl.GetBrightness(imageInfo, topLines);

                // Отображение изображения на экране
                currentImage = ImageCtrl.CreateImage(
                    currentPixels, imageInfo.Width, imageInfo.Height - topLines, GetShiftValue());
                SetImage(currentImage);

                // Отображение имени загруженного файла
                loadedFileLbl.Text = Path.GetFileName(path);
                lensPc.Image = null;
            }
        }

        /* Обработчик нажатия на кнопку "<-- задать" для установки верхних границ изображения
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void SetTopLinesBtn_Click(object sender, EventArgs e)
        {
            // Если файл выбран и с него считана информация
            if (imageInfo != null)
            {
                // Если введенное пользователем значение - это целое число
                if (Int32.TryParse(topImgLinesTb.Text, out topLines))
                {
                    // Если заданное значение меньше высоты изображения и неотрицательно
                    if (topLines < imageInfo.Height && topLines >= 0)
                    {
                        currentPixels = ImageCtrl.GetBrightness(imageInfo, topLines);
                        // Отображение изображения на экране
                        currentImage = ImageCtrl.CreateImage(imageInfo, currentPixels, GetShiftValue(), topLines);
                        SetImage(currentImage);
                    }
                    else
                    {
                        topLines = 0;
                        topImgLinesTb.Text = "0";
                        ShowWarning("Введенное число вне диапазона.", "Недопустимое значение");
                    }
                }
                else
                {
                    topLines = 0;
                    topImgLinesTb.Text = "";
                    ShowWarning("Необходимо ввести целое число.", "Недопустимое значение");
                }
            }
            else ShowWarning(
                "Изображение отсутствует. Загрузите файл формата .mbv, воспользовавшись кнопкой \"Загрузить\".",
                "Файл не загружен");
        }

        /* Обработчик события движения курсора по изображению
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void DisplayedPicturePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageInfo != null)
            {
                // Вывод значений
                // яркости пикселя, на который указывает курсор
                brightnessTb.Text = currentPixels[imageInfo.Width * e.Location.Y + e.Location.X].ToString();
                // координаты пикселя по X
                xTb.Text = e.Location.X.ToString();
                // координаты пикселя по Y
                yTb.Text = e.Location.Y.ToString();
            }
        }

        /* Обработчик радио-кнопок для выбора значения сдвига
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void ShiftCodesRb_CheckedChanged(object sender, EventArgs e)
        {
            if (imageInfo != null)
            {

                currentPixels = ImageCtrl.GetBrightness(imageInfo, topLines);
                // Отображение изображения на экране
                currentImage = ImageCtrl.CreateImage(imageInfo, currentPixels, GetShiftValue(), topLines);

                SetImage(currentImage);
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
                //fragmentPixels
                //SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
            }

        }

        private int GetShiftValue()
        {
            int shift = 0;
            for (int i = 0; i < shiftCodesGb.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)shiftCodesGb.Controls[i];
                if (rb.Checked)
                    shift = Convert.ToInt32(rb.Text);
            }
            return shift;
        }

        /* Получение пути к файлу с видеоданными изображения, выбранному пользователем
         * Возвращаемое значение: строковое значение пути к файлу
         */
        private string GetFile()
        {
            // Создание окна открытия файла
            OpenFileDialog fileDialog = new OpenFileDialog();
            // Восстановление ранее выбранного каталога
            fileDialog.RestoreDirectory = true;
            // Установка фильтра на файлы формата mbv
            fileDialog.Filter = "MBV files (*.mbv) | *.mbv";

            // Открытие окна.
            // Если пользователь выбрал файл и нажал ОК, то возвращает путь,
            // иначе возвращает null
            return (fileDialog.ShowDialog() == DialogResult.OK) ? fileDialog.FileName : null;
        }

        /* Отображение изображения на экране в соответствующем элементе пользовательского интерфейса
         * Параметр: img - изображение, которое необходимо отобразить.
         */
        private void SetImage(Bitmap img)
        {
            displayedPicturePanel.Image = img;
        }

        /* Показ окна с предупреждением
         * Параметры: message - текст сообщения,
         *            title - заголовок окна. 
         */
        private void ShowWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private ushort[,] OneDimToTwoDim(ushort[] pix)
        {
            int w = 500, h = 3000;
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
