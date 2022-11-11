using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace visual_lab_3
{
    // Класс, содержащий обработчики событий для элементов пользовательского интерфейса
    public partial class FormController : Form
    {
        // Информация об изображении, видеоданные которого загружены из файла
        ImageInfo imageInfo;
        // Текущее изображение, с параметрами, заданными пользователем
        public Bitmap CurrentImage { get; private set; }
        // Верхняя граница изображения (при запуске приложения граница = 0)
        int topLines = 0;
        // Размер фрагмента, равный 50х50
        int fragmentSize = 50;
        // Текущие яркости пикселей, с учетом верхней границы и без учета сдвига кодов
        ushort[] currentPixels;
        // Яркости пикселей фрагмента изображения
        ushort[] fragmentPixels;
        // Объект формы с гистограммой
        ChartsForm chartsForm;

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
                rb.CheckedChanged += ScaleValueRb_CheckedChanged;
            }
            // Инициализация объекта формы с гистограммой и передача в него основной формы
            chartsForm = new ChartsForm(this);
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
                // Получение массива яркостей пикселей изображения с учетом верхней границы
                currentPixels = ImageController.GetBrightness(imageInfo, topLines);

                // Отображение изображения на экране
                CurrentImage = ImageController.CreateImage(
                    currentPixels, imageInfo.Width, imageInfo.Height - topLines, GetShiftValue());
                // Установка полученного изображения в соответсвующее поле вывода
                SetImage(CurrentImage);
               
                // Обновление гистограммы
                chartsForm?.UpdateChart(CurrentImage);
                
                // Отображение имени загруженного файла
                loadedFileLbl.Text = Path.GetFileName(path);
                // Очистка поля с увеличенным фрагментом
                lensPb.Image = null;
                // Очистка поля с обзорным изображением
                overviewImagePb.Image = null;
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
                        // Получение массива яркостей пикселей изображения с учетом верхней границы
                        currentPixels = ImageController.GetBrightness(imageInfo, topLines);
                        // Отображение изображения на экране
                        //currentImage = ImageCtrl.CreateImage(imageInfo, currentPixels, GetShiftValue(), topLines);
                        CurrentImage = ImageController.CreateImage(
                            currentPixels, imageInfo.Width, imageInfo.Height - topLines, GetShiftValue());
                        // Установка полученного изображения в соответсвующее поле вывода
                        SetImage(CurrentImage);
                        
                        // Обновление гистограммы
                        chartsForm?.UpdateChart(CurrentImage);
                        
                        // Получение нового размера фрагмента
                        fragmentSize = GetFragmentSize();
                    }
                    // Если введенное число не соответствует допустимому диапазону
                    else
                    {
                        // Обнуление значения верхней границы
                        topLines = 0;
                        // В поле ввода верхней границы отображается 0
                        topImgLinesTb.Text = "0";
                        // Показ предупреждения
                        ShowWarning("Введенное число вне диапазона.", "Недопустимое значение");
                    }
                }
                // Если введенное значение - не целое число
                else
                {
                    // Обнуление значения верхней границы
                    topLines = 0;
                    // В поле ввода верхней границы отображается 0
                    topImgLinesTb.Text = "0";
                    // Показ предупреждения
                    ShowWarning("Необходимо ввести целое число.", "Недопустимое значение");
                }
            }
            // Если изображение не было загружено из файла
            else
                // Показ предупреждения
                ShowWarning(
                "Изображение отсутствует. Загрузите файл формата .mbv, воспользовавшись кнопкой \"Загрузить\".",
                "Файл не загружен");
        }

        /* Обработчик события движения курсора по изображению
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void DisplayedPicturePanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Если файл выбран и с него считана информация
            if (imageInfo != null)
            {
                // Вывод значений
                // яркости пикселя, на который указывает курсор
                // Проверка на вылет за пределы отображаемого изображения
                if (e.Location.X < CurrentImage.Width && e.Location.Y < CurrentImage.Height)
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
            // Если файл выбран и с него считана информация
            if (imageInfo != null)
            {
                // Получение массива яркостей пикселей изображения с учетом верхней границы
                currentPixels = ImageController.GetBrightness(imageInfo, topLines);
                // Отображение изображения на экране с 
                CurrentImage = ImageController.CreateImage(
                           currentPixels, imageInfo.Width, imageInfo.Height - topLines, GetShiftValue());
                // Установка полученного изображения в соответствующее поле вывода
                SetImage(CurrentImage);

                // Обновление гистограммы
                chartsForm?.UpdateChart(CurrentImage);

                // Отображения фрагмента (если он выбран) в соответствующем поле на форме с учетом нормирования и метода увеличения
                if (fragmentPixels != null)
                    SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);

            }
        }

        /* Обработчик выбора значения увеличения фрагмента
         * При изменении значения увеличения на форме отображается новый фрагмент, увеличенный в выбранное число раз
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void ScaleValueRb_CheckedChanged(object sender, EventArgs e)
        {
            // Проверка наличия фрагмента
            if (fragmentPixels != null)
            {
                // Отображения фрагмента в соответствующем поле на форме с учетом нормирования и метода увеличения
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
            }
        }

        /* Обработчик события нажатия по элементу формы с изображением
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void DisplayedPicturePanel_MouseClick(object sender, MouseEventArgs e)
        {
            // Если изображение было закружено из файла
            if (imageInfo != null)
            {
                // Получение фрагмента изображения по координатам пикселя, на который указывал курсор мыши при клике
                fragmentPixels = GetImageFragment(e.Location, fragmentSize);
                // Отображения фрагмента в соответствующем поле на форме с учетом нормирования и метода увеличения
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
            }
        }

        /* Получение размера фрагмента, который можно получить из изображения, отображаемого на экране 
         * Возвращаемое значение: размер фрагмента*/
        private int GetFragmentSize()
        {
            // Изначально размер фрагмента 50 на 50
            int fragSize = 50;
            // Если высота изображения меньше, чем fragSize
            if (fragSize > CurrentImage.Height)
                // то новый размер фрагмента равен выосте изображения
                fragSize = CurrentImage.Height;
            return fragSize;
        }

        /* Получение фрагмента изображения по координатам пикселя (центр фрагмента)
         * Параметры: clickLocation - координата пикселя, вокруг которого будет вырезаться фрагмент
         *            fragSize - размера фрагмента.
         * Возвращаемое значение: массив яркостей пикселей фрагмента
         */
        private ushort[] GetImageFragment(Point clickLocation, int fragSize)
        {
            fragSize = GetFragmentSize();
            // Получение радиуса построения фрагмента
            int radius = fragSize / 2;
            // Координаты левого верхнего угла фрагмента
            int x, y;
            // Вычисление координаты верхнего левого угла фрагмента с учетом радиуса
            x = clickLocation.X - radius;
            y = clickLocation.Y - radius;

            // Если радиус выходит за пределы левой границы изображения,
            // то получение фрагмента начнется с точки (0;y)
            if (clickLocation.X - radius < 0) x = 0;
            // Если радиус выходит за пределы верхней границы изображения,
            // то получение фрагмента начнется с точки (x;0)
            if (clickLocation.Y - radius < 0) y = 0;

            // Если радиус выходит за пределы правой границы изображения,
            // то построение начнется с точки, расположенной слева от границы на расстоянии fragSize
            if (clickLocation.X + radius > CurrentImage.Width) x = CurrentImage.Width - fragSize;
            // Если радиус выходит за пределы нижней границы изображения,
            // то построение начнется с точки, расположенной сверху от границы на расстоянии fragSize
            if (clickLocation.Y + radius > CurrentImage.Height) y = CurrentImage.Height - fragSize;

            // Инициализация массива яркостей пикселей фрагмента
            // Размер массива равен количеству пикселей в фрагменте
            ushort[] fragPixels = new ushort[fragSize * fragSize];
            // Счетчик количества пикселей в фрагменте
            int pixelNum = 0;
            // Проход по пикселям текущего изображения; начинается с левого верхнего угла фрагмента;
            // по каждому из направлений (оси х и y) берется количество пикселей, равное размеру фрагмента fragSize
            for (int i = y; i < y + fragSize; i++)
            {
                for (int k = x; k < x + fragSize; k++)
                {
                    // Присваивание текущему значению яркости фрагмента соответствующей яркости, взятой из текущего изображения
                    fragPixels[pixelNum] = currentPixels[imageInfo.Width * i + k];
                    // Увеличение счетчика пикселей фрагмента на 1
                    pixelNum++;
                }
            }
            // Возврат массива яркостей пикселей фрагмента
            return fragPixels;
        }

        /* Отображение фрагмента в соответствующем поле на форме
         * с учетом нормирования яркостей пикселей и метода увеличения
         * Параметры: fragPixels - яркости пикселей фрагмента,
         *            normalize - необходимо ли нормировать яркости,
         *            interpolate - метод увеличения: true - билинейная интерполяция, false - метод ближайщего соседа.
         * Возвращаемое значение: метод ничего не возвращает            
         */
        private void SetFragment(ushort[] fragPixels, bool normalize, bool interpolate)
        {
            // Инициализация объекта Bitmap - изображения, которое будет выведено в поле фрагмента
            Bitmap frag;
            // Получение текущего значения увеличения
            int scale = GetScaleValue();
            // Если было выбрано нормирование яркостей
            if (normalize)
                // Нормирование яркостей пикселей; параметр fragPixels заменяется на массив с нормированными яркостями
                fragPixels = ImageController.NormalizeBrightness(fragPixels);

            // Если размер фрагмента равен 1 на 1 и выбрана билинейная интерполяция,
            // то увеличение фрагмента будет происходит методом ближайшего соседа
            if (fragPixels.Length == 1 && interpolate)
                interpolate = false;

            // В зависимости от выбранного метода увеличения вызывается соответствующий метод увеличения;
            // параметр fragPixels заменяется на массив с увеличенными пикселями
            fragPixels = interpolate
                // Билинейная субпиксельная интерполяция
                ? ImageController.BilinearInterpolationScaling(fragPixels, fragmentSize, fragmentSize, scale)
                // Метод ближайщего соседа
                : ImageController.NearestNeighborScaling(fragPixels, fragmentSize, fragmentSize, scale);

            // Создание изображения из массива пикселей
            // Размер созданного фрагмента равен увеличенному в scale раз размеру исходного фрагмента
            frag = ImageController.CreateImage(fragPixels, fragmentSize * scale, fragmentSize * scale, GetShiftValue());
            // Установка созданного изображения в элемент lensPc
            lensPb.Image = frag;
        }

        /* Обработчик изменения метода увеличения
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void InterpolateCb_CheckedChanged(object sender, EventArgs e)
        {
            // Проверка наличия фрагмента
            if (fragmentPixels != null)
                // Отображения фрагмента в соответствующем поле на форме с учетом нормирования и метода увеличения
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
        }

        /* Обработчик изменения необходимости нормировки яркостей пикселей
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void NormalizeCb_CheckedChanged(object sender, EventArgs e)
        {
            // Проверка наличия фрагмента
            if (fragmentPixels != null)
                // Отображения фрагмента в соответствующем поле на форме с учетом нормирования и метода увеличения
                SetFragment(fragmentPixels, normalizeCb.Checked, interpolateCb.Checked);
        }

        /* Обработчик кнопки для создания обзорного изображения (ОИ)
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void CreateOverviewImageBtn_Click(object sender, EventArgs e)
        {
            // Если изображение было считано с файла
            if (imageInfo != null)
            {
                // Значение прореживания исходного изображения
                const int m = 5;
                // Получение массива яркостей ОИ
                ushort[] overviewPixels = ImageController.OverviewImage(
                    imageInfo.PixelBrightness, imageInfo.Width, imageInfo.Height, m);
                // Создание ОИ с учетом выбранного сдвига кодов
                Bitmap overviewImage = ImageController.CreateImage(
                    overviewPixels, imageInfo.Width / m, imageInfo.Height / m, GetShiftValue());
                // Установка ОИ в поле для его вывода 
                overviewImagePb.Image = overviewImage;
            }
            // Если изображение не было считано с файла
            else
                // Показ соответствующего предупреждения
                ShowWarning(
              "Невозможно построить обзорное изображение. Загрузите файл формата .mbv, воспользовавшись кнопкой \"Загрузить\".",
              "Файл не загружен");
        }

        /* Получение текущего значения сдвига кодов 
         * Возвращаемое значение: выбранный пользователем сдвиг кодов пикселей
         */
        private int GetShiftValue()
        {
            // Инициализация значения сдвига кодов
            // Первоначально равняется 0 - самому младшему из предлагаемых значений сдвигов
            int shift = 0;
            // Проход по элементам группы "Сдвигать коды на:"
            for (int i = 0; i < shiftCodesGb.Controls.Count; i++)
            {
                // Получение радиокнопки
                RadioButton rb = (RadioButton)shiftCodesGb.Controls[i];
                // Если текущая радиокнопка выбрана
                if (rb.Checked)
                    // Получить целое число, соответсвующее выбранной радиокнопке
                    shift = Convert.ToInt32(rb.Text);
            }
            // Возврат выбраного значения сдвига кодов
            return shift;
        }

        /* Получение текущего значения увеличения
         * Возвращаемое значение: значение увеличения
         */
        private int GetScaleValue()
        {
            // Инициализация значения увеличения изображения
            // Первоначально равняется 3 - самому младшему предлагаемому значению
            int scaleValue = 3;
            // Проход по элементам (радиокнопкам) группы "Увеличить в:"
            for (int i = 0; i < scaleValueGb.Controls.Count; i++)
            {
                // Получение текущей радиокнопки
                RadioButton rb = (RadioButton)scaleValueGb.Controls[i];
                // Если текущая радиокнопка выбрана
                if (rb.Checked)
                    // Получить целое число, соответсвующее выбранной радиокнопке
                    scaleValue = Convert.ToInt32(rb.Text);
            }
            // Возврат выбранного значения увеличения
            return scaleValue;
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

            // Открытие окна
            // Если пользователь выбрал файл и нажал ОК, то возвращает путь,
            // иначе возвращает null
            return (fileDialog.ShowDialog() == DialogResult.OK) ? fileDialog.FileName : null;
        }

        /* Отображение изображения на экране в соответствующем элементе пользовательского интерфейса
         * Параметр: img - изображение, которое необходимо отобразить.
         */
        public void SetImage(Bitmap img)
        {
            // Изменение свойства Image объекта displayedPicturePanel
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

        /* Обработчик нажатия на кнопку "Гистограмма" для отображения окна с гистограммой
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void OpenChartsBtn_Click(object sender, EventArgs e)
        {
            // Если изображения было загружено из файла
            if (imageInfo != null)
            {
                // Отображение формы с гистограммой
                chartsForm.Show();
            }
            // Если не было загружено
            else
            {
                // Показ соответствующего предупреждения
                ShowWarning(
                "Изображение отсутствует. Загрузите файл формата .mbv, воспользовавшись кнопкой \"Загрузить\".",
                "Файл не загружен");
            }
        }

    }
}
