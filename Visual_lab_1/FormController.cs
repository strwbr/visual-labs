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
        // Сдвиг изображения (при запуске приложения сдвиг = 0)
        int codeShift = 0;
        // Верхняя граница изображения (при запуске приложения граница = 0)
        int topLines = 0;

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
            // на радио-кнопки из группы "Сдвигать коды на"
            for (int i = 0; i < shiftCodesGb.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)shiftCodesGb.Controls[i];
                rb.CheckedChanged += ShiftCodesRb_CheckedChanged;
            }
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
                // Создание изображения для отображения его на экране;
                // значение сдвига, установленное ранее, сохраняется, а верхняя граница сбрасывается
                currentImage = ImageController.CreateImage(imageInfo, codeShift, topLines);
                // Отображение изображения на экране
                SetImage(currentImage);

                // Отображение имени загруженного файла
                loadedFileLbl.Text = Path.GetFileName(path); // Debug -- поменять на нужный лейбл 
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
                        // Создание изображения для отображения его на экране с полученным знаение верхней границы;
                        // при этом значение сдвига, установленного ранее, сохраняется
                        currentImage = ImageController.CreateImage(imageInfo, codeShift, topLines);
                        // Отображение изображения на экране
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
                brightnessTb.Text = currentImage.GetPixel(e.Location.X, e.Location.Y).R.ToString();
                // координаты пикселя по X
                xMatrixTb.Text = xCompZoneTb.Text = e.Location.X.ToString();
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
                // Получение объекта радио-кнопки, вызвавшей событие
                RadioButton rb = sender as RadioButton;
                // Если эта радио-кнопка выбрана
                if (rb.Checked)
                {
                    // Получение значения сдвига, соответствующего данной радио-кнопке 
                    codeShift = Convert.ToInt32(rb.Text);
                    // Создание изображения для отображения его на экране с полученным значением сдвига;
                    // при этом значение верхней границы, установленной ранее, сохраняется
                    currentImage = ImageController.CreateImage(imageInfo, codeShift, topLines);
                    // Отображение изображения на экране
                    SetImage(currentImage);
                }
            }
            else ShowWarning(
                "Изображение отсутствует. Загрузите файл формата .mbv, воспользовавшись кнопкой \"Загрузить\".",
                "Файл не загружен");
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

    }
}
