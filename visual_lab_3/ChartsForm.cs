using System;
using System.Drawing;
using System.Windows.Forms;

namespace visual_lab_3
{
    public partial class ChartsForm : Form
    {
        // Количество различных яркостей в изображении
        int[] amountBright = new int[256];
        // Передвигается ли левый движок
        bool isMoveLeftBoundary = false;
        // Передвигается ли правый движок
        bool isMoveRightBoundary = false;
        // Родительская форма
        FormController parentForm;
        // Исходной изображение
        Bitmap originImage;
        // Положение левого движка
        private ushort LeftPos => (ushort)brightAmountChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset;
        // Положения правого движка
        private ushort RightPos => (ushort)brightAmountChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset;

        // Конструктор без параметров
        public ChartsForm()
        {
            InitializeComponent();
        }

        // Конструктор с параметром для передачи родительской формы
        public ChartsForm(FormController parent)
        {
            InitializeComponent();
            // Получение объекта родительской формы
            parentForm = parent;
            // Получение исходного изображения с родительской формы
            originImage = parent.CurrentImage;
            //UpdateChart(parentForm.CurrentImage);

            // Установка левого движка в положение LeftPos
            MoveLeftBoundary(LeftPos);
            // Установка правого движка в положение RightPos
            MoveRightBoundary(RightPos);

            // Добавление обработчиков событий на радиокнопки
            // из группы "Левее L"
            for (int i = 0; i < leftModesGb.Controls.Count; i++)
            {
                RadioButton rb = leftModesGb.Controls[i] as RadioButton;
                rb.CheckedChanged += LeftModeRb_CheckedChanged;
            }
            // из группы "Правее R"
            for (int i = 0; i < rightModesGb.Controls.Count; i++)
            {
                RadioButton rb = rightModesGb.Controls[i] as RadioButton;
                rb.CheckedChanged += RightModeRb_CheckedChanged;
            }
        }

        /* Обновление диаграммы
         * Параметр: image - изображение, для которого необходимо обновить гистограмму
         */
        public void UpdateChart(Bitmap image)
        {
            // Получение нового исходного изображения
            originImage = image;
            // Получение количества различных яркостей в изображении image
            amountBright = CountBright(image);
            // Построение гистограммы 
            BuildChart(amountBright);
        }

        /* Подсчет количества различных яркостей в изображении
         * Параметр: image - изображение, у которого будут подсчитываться яркости
         * Возвращаемое значение: массив с количеством различных яркостей
         */
        private int[] CountBright(Bitmap image)
        {
            // Инициализация массива для хранения количества яркостей
            int[] temp = new int[256];
            // Проход по изображению image
            for (int i = 0; i < image.Height; i++)
            {
                for (int k = 0; k < image.Width; k++)
                {
                    // Получение текущей яркости изображения image
                    ushort bright = image.GetPixel(k, i).R;
                    // Увеличение количества этой яркости на 1
                    temp[bright]++;
                }
            }
            return temp;
        }

        /* Построение гистограммы
         * Параметр: amountBright - массив с количеством яркостей
         */
        private void BuildChart(int[] amountBright)
        {
            // Очистка предыдущих данных
            if (brightAmountChart.Series[0].Points != null)
                brightAmountChart.Series[0].Points.Clear();

            // Задание новых данных для гистограммы
            for (int i = 0; i < amountBright.Length; i++)
            {
                brightAmountChart.Series[0].Points.AddXY(i, amountBright[i]);
            }
        }

        /* Передвижение левого движка
         * Параметр: x - координата по оси X, в которую необходимо установить движок
         */
        private void MoveLeftBoundary(int x)
        {
            // Установка расположения движка в точку x
            brightAmountChart.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = x;
            // Отображения значения x - значения яркости
            leftBrightValueTb.Text = x.ToString();
            // Отображения количества пикселей яркости x
            leftBrightAmountTb.Text = amountBright[x].ToString();
        }

        /* Передвижение правого движка
         * Параметр: x - координата по оси X, в которую необходимо установить движок
         */
        private void MoveRightBoundary(int x)
        {
            // Установка расположения движка в точку x
            brightAmountChart.ChartAreas[0].AxisX.StripLines[1].IntervalOffset = x;
            // Отображения значения x - значения яркости
            rightBrightValueTb.Text = x.ToString();
            // Отображения количества пикселей яркости x
            rightBrightAmountTb.Text = amountBright[x].ToString();
        }

        /* Обновление яркостей изображения
         * Параметр: image - изображения, у которого необходимо обновить яркости
         * Возвращаемое значение: обновленное изображение 
         */
        private Bitmap UpdateImageBright(Bitmap image)
        {
            // Инициализация изображения с обновленными яркостями
            Bitmap updatedImage = null;
            // Если включен режим отображение диапазона [L,R] в диапазон [0,255]
            if (NormalizeMode())
            {
                // Получение обновленного изображения путем вызова соответствующего метода класса BrightController
                updatedImage = BrightController.NormalizeBright(image, LeftPos, RightPos);
            }
            // Если данный режим отключен
            else
            {
                // Получение новых значений яркостей, которые расположены
                // левее L
                ushort newLeftBright = GetNewLeftBrightValue();
                // правее R
                ushort newRightBright = GetNewRightBrightValue();
                // Если были получены новые яркости, т.е. включены соответствующие радиокнопки
                if (newLeftBright != 9999 && newRightBright != 9999)
                {
                    // // Получение обновленного изображения путем вызова соответствующего метода класса BrightController
                    updatedImage = BrightController.ChangeImageBright(
                                image,
                                LeftPos, newLeftBright,
                                RightPos, newRightBright);
                } // else (newRightBright == 9999 && newLeftBright!=9999) R = 255; ...
            }
            return updatedImage;
        }

        /* Получения режима изменения яркостей левее L
         * Возвращаемое значение: номер режима
         */
        private int GetLeftMode()
        {
            // Номер режима
            // = -1, если не выбран ни один из режимом
            int mode = -1;
            // Получение индекса путем прохождения по радиокнопкам группы "Левее L"
            for (int i = 0; i < leftModesGb.Controls.Count; i++)
            {
                RadioButton rb = leftModesGb.Controls[i] as RadioButton;
                // Если текущая радиокнопка выбрана, то режим равен индексу этой радиокнопки
                if (rb.Checked)
                    mode = i;
            }
            return mode;
        }

        /* Получение нового значения яркости для левого отсечения
         * Возвращаемое значение: новая яркость
         */
        private ushort GetNewLeftBrightValue()
        {
            // Новая яркость
            ushort newBright = 0; // по умолчанию = 0
            // Получение режима изменения яркостей
            int mode = GetLeftMode();
            switch (mode)
            {
                // если не выбран режим, то яркость равна очень большому значению
                case -1: newBright = 9999; break;
                // если выбран режим "Считать равными L", то новая яркость равна положению левого движка
                case 0: newBright = LeftPos; break;
                // если выбран режим "Считать равными минимальному значению 0", то новая яркость равна 0
                case 1: newBright = 0; break;
                // если выбран режим "Считать равными 0", то новая яркость равна 0
                case 2: newBright = 0; break;
            }
            return newBright;
        }

        /* Получения режима изменения яркостей правее R
         * Возвращаемое значение: индекс режима
         */
        private int GetRightMode()
        {
            // Номер режима
            // = -1, если не выбран ни один из режимом
            int mode = -1;
            // Получение индекса путем прохождения по радиокнопкам группы "Правее R"
            for (int i = 0; i < rightModesGb.Controls.Count; i++)
            {
                RadioButton rb = rightModesGb.Controls[i] as RadioButton;
                // Если текущая радиокнопка выбрана, то режим равен индексу этой радиокнопки
                if (rb.Checked)
                    mode = i;
            }
            return mode;
        }

        /* Получение нового значения яркости для правого отсечения
         * Возвращаемое значение: новая яркость
         */
        private ushort GetNewRightBrightValue()
        {
            // Новая яркость
            ushort newBright = 0; // по умолчанию = 0
            // Получение режима изменения яркостей
            int mode = GetRightMode();
            switch (mode)
            {
                // если не выбран режим, то яркость равна очень большому значению
                case -1: newBright = 9999; break;
                // если выбран режим "Считать равными R", то новая яркость равна положению правого движка
                case 0: newBright = RightPos; break;
                // если выбран режим "Считать равными максимальному значению 255", то новая яркость равна 255
                case 1: newBright = 255; break;
                // если выбран режим "Считать равными 0", то новая яркость равна 0
                case 2: newBright = 0; break;
            }
            return newBright;
        }

        /* Получение статуса режима "[L, R] отображать в [0, 255]" */
        private bool NormalizeMode() => normalizeModeRb.Checked;

        /* Обработчик радиокнопок выбора режима изменения яркостей левее движка L
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void LeftModeRb_CheckedChanged(object sender, EventArgs e)
        {
            // Если выбран режим
            if (GetLeftMode() != -1)
            {
                // Отключить режим "[L, R] отображать в [0, 255]"
                DisableNormalizeMode();
                // Если при этом не выбран режим для правого движка
                if (GetRightMode() == -1)
                    // Включить режим "Считать равными R"
                    ((RadioButton)rightModesGb.Controls[0]).Checked = true;
            }
            //if (GetLeftMode() != -1 && GetRightMode() != -1)
            //    DisableNormalizeMode();
        }

        /* Обработчик радиокнопок выбора режима изменения яркостей правее движка R
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void RightModeRb_CheckedChanged(object sender, EventArgs e)
        {
            // Если выбран режим
            if (GetRightMode() != -1)
            {
                // Отключить режим "[L, R] отображать в [0, 255]"
                DisableNormalizeMode();
                // Если при этом не выбран режим для левого движка
                if (GetLeftMode() == -1)
                    // Включить режим "Считать равными L"
                    ((RadioButton)leftModesGb.Controls[0]).Checked = true;

            }
            //if (GetLeftMode() != -1 && GetRightMode() != -1)
            //    DisableNormalizeMode();
        }

        /* Обработчик нажатия на кнопку "Обновить яркости изображения" для вывода нового изображения в родительской форме 
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void UpdateBrightBtn_Click(object sender, EventArgs e)
        {
            // Изменение яркостей исходного изображения originImage
            Bitmap newImg = UpdateImageBright(originImage);
            // Отображение полученного изобрежения в родительской форме
            // путем вызова метода SetImage из класса этой формы
            parentForm?.SetImage(newImg);
        }

        /* Обоработчик режима "[L, R] отображать в [0, 255]"
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void NormalizeModeRb_CheckedChanged(object sender, EventArgs e)
        {
            // Если режим включен
            if (NormalizeMode())
            {
                // Отключить режимы изменения яркостей левее L и правее R соответственно
                DisableLeftMode();
                DisableRightMode();
            }
        }

        /* Отключение режимов изменения яркостей левее L */
        private void DisableLeftMode()
        {
            // Проход по всем радиокнопка в группе "Левее L" и их отключение
            for (int i = 0; i < leftModesGb.Controls.Count; i++)
            {
                ((RadioButton)leftModesGb.Controls[i]).Checked = false;
            }
        }

        /* Отключение режимов изменения яркостей правее R */
        private void DisableRightMode()
        {
            // Проход по всем радиокнопка в группе "Правее R" и их отключение
            for (int i = 0; i < rightModesGb.Controls.Count; i++)
            {
                ((RadioButton)rightModesGb.Controls[i]).Checked = false;
            }
        }

        /* Отключение режима "[L, R] отображать в [0, 255]" */
        private void DisableNormalizeMode()
        {
            // Отключение соответстующей радикнопки
            normalizeModeRb.Checked = false;
        }

        /* Обработчик нажатия на кнопку мыши, когда ее указатель находится на гистограмме
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void BrightAmountChart_MouseDown(object sender, MouseEventArgs e)
        {
            // Получение координаты клика относительно оси X гистограммы, в которую необходимо переместить движок
            double x = brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            // Положение левого движка
            int xL = LeftPos;
            // Положение правого движка
            int xR = RightPos;

            // Проверка захвата движков для пермещения
            isMoveLeftBoundary = (x > xL - 5) && (x < xL + 5);
            isMoveRightBoundary = (x > xR - 5) && (x < xR + 5);

            // Проверка случая, когда движки расположены близко друг к другу,
            // т.е. когда оба движка были захвачены
            if (isMoveLeftBoundary && isMoveRightBoundary)
            {
                // Флаг передвижения левого движка
                // Если движок расположен на расстоянии меньше 5 от правой границы (255) области гистограммы,
                // то его можно перемещать; иначе - нельзя
                isMoveLeftBoundary = 255 - xR < 5;
                // Правый движок может перемещать только, когда левый движок неподвижен, и наоборот
                isMoveRightBoundary = !isMoveLeftBoundary;

                //isMoveLeftBoundary = isMoveRightBoundary = false;
                //if (xL < 5) isMoveRightBoundary = true;
                //else if (255 - xR < 5) isMoveLeftBoundary = true;
                //else isMoveRightBoundary = true;
            }
        }

        /* Обработчик отпускания кнопки мыши, когда ее указатель находится на гистограмме
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void BrightAmountChart_MouseUp(object sender, MouseEventArgs e)
        {
            // Отключение возможности перемещения для обоих движков
            isMoveLeftBoundary = false;
            isMoveRightBoundary = false;
        }

        /* Обработчик перемещения указателя мыши по гистограмме
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void BrightAmountChart_MouseMove(object sender, MouseEventArgs e)
        {
            // Координата клика относительно оси X гистограммы, в которую необходимо переместить движок
            int x = -1;
            try
            {
                // Получение координаты x
                x = (int)brightAmountChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X);
            }
            // Обработка исключения
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Если координата x = -1, то есть вышла за пределы гистограммы, и при этом перемещается левый движок
                if (isMoveLeftBoundary && x == -1)
                {
                    // то его положение устанавливается равным 0
                    MoveLeftBoundary(0);
                }
                // Если координата x = 256, то есть вышла за пределы гистограммы, и при этом перемещается правый движок
                if (isMoveRightBoundary && x == 256)
                {
                    // то его положение устанавливается равным 255
                    MoveRightBoundary(255);
                }
            }

            // Если координата x расположена в пределах оси Х гистограммы
            if (x >= 0 && x <= 255)
            {
                // Если включен режим фиксированного перемещения движков
                if (IsFixBoundaries())
                {
                    // Расстояние между левым и правым движком
                    int dx = Math.Abs(LeftPos - RightPos);
                    // Если движки перемещаются с помощью левого движка (т.е. был захвачен левый движок)
                    // и расстояние до правой границы области гистограммы меньше или равно dx
                    // (т.е.можно передвинуть правый движок с слхранением расстояния dx между ними)
                    if (isMoveLeftBoundary && x + dx <= 255)
                    {
                        // Перемещение левого движка в позицию x
                        MoveLeftBoundary(x);
                        // Перемещение правого движка в позицию x+dx
                        MoveRightBoundary(x + dx);
                    }
                    // Если был захвачен правый движок и можно передвинуть левый движок с сохранением расстояния dx между ними
                    else if (isMoveRightBoundary && x - dx >= 0)
                    {
                        // Перемещение левого движка в позицию x-dx
                        MoveLeftBoundary(x - dx);
                        // Перемещение правого движка в позицию x
                        MoveRightBoundary(x);
                    }
                }
                // Если режим фиксированного перемещения выключен
                else
                {
                    // Если был захвачен левый движок, и при этом новая координата меньше координаты правого движка
                    if (isMoveLeftBoundary && x <= RightPos)
                    {
                        // Перемещение левого движка в позицию x
                        MoveLeftBoundary(x);
                    }
                    // Если был захвачен правый движок, и при этом новая координата больше координаты левого движка
                    if (isMoveRightBoundary && x >= LeftPos)
                    {
                        // Перемещение правого движка в позицию x
                        MoveRightBoundary(x);
                    }
                }
            }
        }

        /* Получение статуса режима фиксированного пермещения движков */
        private bool IsFixBoundaries() => fixCb.Checked;

        /* Обработчик закрытия формы
         * Параметры: sender - объект, вызвавший событие,
         *            e - аргумент, хранящий информацию о событии.
         */
        private void ChartsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Отмена события закрытия формы
            e.Cancel = true;
            // Отображение исходного изображения в родительской форме
            parentForm.SetImage(originImage); // ПОД ВОПРОСОМ
            // Сброс позиций движков на начальные
            MoveLeftBoundary(0);
            MoveRightBoundary(255);
            // Сокрытие формы с гистограммой
            this.Hide();
        }
    }
}
