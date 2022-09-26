
namespace Visual_lab_1
{
    partial class FormController
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadedFileLbl = new System.Windows.Forms.Label();
            this.shiftCodesGb = new System.Windows.Forms.GroupBox();
            this.codeShift_2 = new System.Windows.Forms.RadioButton();
            this.codeShift_1 = new System.Windows.Forms.RadioButton();
            this.codeShift_0 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.setTopLinesBtn = new System.Windows.Forms.Button();
            this.topImgLinesTb = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.brightnessTb = new System.Windows.Forms.TextBox();
            this.yTb = new System.Windows.Forms.TextBox();
            this.xMatrixTb = new System.Windows.Forms.TextBox();
            this.xCompZoneTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.displayedPicturePanel = new System.Windows.Forms.PictureBox();
            this.lensPc = new System.Windows.Forms.PictureBox();
            this.normalizeCb = new System.Windows.Forms.CheckBox();
            this.interpolateCb = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.shiftCodesGb.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayedPicturePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lensPc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadFileBtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(467, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка tiff-файла";
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(7, 37);
            this.loadFileBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(134, 44);
            this.loadFileBtn.TabIndex = 1;
            this.loadFileBtn.Text = "Загрузить";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadedFileLbl);
            this.groupBox2.Location = new System.Drawing.Point(147, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(311, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Загружено изображение";
            // 
            // loadedFileLbl
            // 
            this.loadedFileLbl.AutoSize = true;
            this.loadedFileLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadedFileLbl.Location = new System.Drawing.Point(8, 31);
            this.loadedFileLbl.Name = "loadedFileLbl";
            this.loadedFileLbl.Size = new System.Drawing.Size(160, 23);
            this.loadedFileLbl.TabIndex = 0;
            this.loadedFileLbl.Text = "Файл не загружен";
            // 
            // shiftCodesGb
            // 
            this.shiftCodesGb.Controls.Add(this.codeShift_2);
            this.shiftCodesGb.Controls.Add(this.codeShift_1);
            this.shiftCodesGb.Controls.Add(this.codeShift_0);
            this.shiftCodesGb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shiftCodesGb.Location = new System.Drawing.Point(488, 17);
            this.shiftCodesGb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shiftCodesGb.Name = "shiftCodesGb";
            this.shiftCodesGb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shiftCodesGb.Size = new System.Drawing.Size(208, 96);
            this.shiftCodesGb.TabIndex = 1;
            this.shiftCodesGb.TabStop = false;
            this.shiftCodesGb.Text = "Сдвигать коды на:";
            // 
            // codeShift_2
            // 
            this.codeShift_2.AutoSize = true;
            this.codeShift_2.Location = new System.Drawing.Point(126, 40);
            this.codeShift_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeShift_2.Name = "codeShift_2";
            this.codeShift_2.Size = new System.Drawing.Size(40, 27);
            this.codeShift_2.TabIndex = 2;
            this.codeShift_2.Text = "2";
            this.codeShift_2.UseVisualStyleBackColor = true;
            // 
            // codeShift_1
            // 
            this.codeShift_1.AutoSize = true;
            this.codeShift_1.Location = new System.Drawing.Point(79, 40);
            this.codeShift_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeShift_1.Name = "codeShift_1";
            this.codeShift_1.Size = new System.Drawing.Size(40, 27);
            this.codeShift_1.TabIndex = 1;
            this.codeShift_1.Text = "1";
            this.codeShift_1.UseVisualStyleBackColor = true;
            // 
            // codeShift_0
            // 
            this.codeShift_0.AutoSize = true;
            this.codeShift_0.Location = new System.Drawing.Point(30, 40);
            this.codeShift_0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeShift_0.Name = "codeShift_0";
            this.codeShift_0.Size = new System.Drawing.Size(40, 27);
            this.codeShift_0.TabIndex = 0;
            this.codeShift_0.Text = "0";
            this.codeShift_0.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.setTopLinesBtn);
            this.groupBox4.Controls.Add(this.topImgLinesTb);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(703, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(293, 96);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Верхние строки изображений:";
            // 
            // setTopLinesBtn
            // 
            this.setTopLinesBtn.Location = new System.Drawing.Point(165, 35);
            this.setTopLinesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setTopLinesBtn.Name = "setTopLinesBtn";
            this.setTopLinesBtn.Size = new System.Drawing.Size(109, 41);
            this.setTopLinesBtn.TabIndex = 1;
            this.setTopLinesBtn.Text = "<-- задать";
            this.setTopLinesBtn.UseVisualStyleBackColor = true;
            // 
            // topImgLinesTb
            // 
            this.topImgLinesTb.Location = new System.Drawing.Point(27, 40);
            this.topImgLinesTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topImgLinesTb.Name = "topImgLinesTb";
            this.topImgLinesTb.Size = new System.Drawing.Size(116, 30);
            this.topImgLinesTb.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.brightnessTb);
            this.groupBox6.Controls.Add(this.yTb);
            this.groupBox6.Controls.Add(this.xMatrixTb);
            this.groupBox6.Controls.Add(this.xCompZoneTb);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(14, 795);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(273, 215);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Координаты курсора:";
            // 
            // brightnessTb
            // 
            this.brightnessTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brightnessTb.Location = new System.Drawing.Point(182, 163);
            this.brightnessTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brightnessTb.Name = "brightnessTb";
            this.brightnessTb.ReadOnly = true;
            this.brightnessTb.Size = new System.Drawing.Size(57, 32);
            this.brightnessTb.TabIndex = 7;
            // 
            // yTb
            // 
            this.yTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yTb.Location = new System.Drawing.Point(182, 119);
            this.yTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yTb.Name = "yTb";
            this.yTb.ReadOnly = true;
            this.yTb.Size = new System.Drawing.Size(57, 32);
            this.yTb.TabIndex = 6;
            // 
            // xMatrixTb
            // 
            this.xMatrixTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xMatrixTb.Location = new System.Drawing.Point(182, 75);
            this.xMatrixTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xMatrixTb.Name = "xMatrixTb";
            this.xMatrixTb.ReadOnly = true;
            this.xMatrixTb.Size = new System.Drawing.Size(57, 32);
            this.xMatrixTb.TabIndex = 5;
            // 
            // xCompZoneTb
            // 
            this.xCompZoneTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xCompZoneTb.Location = new System.Drawing.Point(182, 31);
            this.xCompZoneTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xCompZoneTb.Name = "xCompZoneTb";
            this.xCompZoneTb.ReadOnly = true;
            this.xCompZoneTb.Size = new System.Drawing.Size(57, 32);
            this.xCompZoneTb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(61, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Яркость:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(61, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(61, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Х (мартица) = ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(61, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Х (ЗК) =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picturePanel
            // 
            this.picturePanel.AutoScroll = true;
            this.picturePanel.Controls.Add(this.displayedPicturePanel);
            this.picturePanel.Location = new System.Drawing.Point(15, 120);
            this.picturePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(655, 667);
            this.picturePanel.TabIndex = 9;
            // 
            // displayedPicturePanel
            // 
            this.displayedPicturePanel.Location = new System.Drawing.Point(0, 0);
            this.displayedPicturePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayedPicturePanel.Name = "displayedPicturePanel";
            this.displayedPicturePanel.Size = new System.Drawing.Size(559, 334);
            this.displayedPicturePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.displayedPicturePanel.TabIndex = 0;
            this.displayedPicturePanel.TabStop = false;
            // 
            // lensPc
            // 
            this.lensPc.Location = new System.Drawing.Point(677, 121);
            this.lensPc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lensPc.Name = "lensPc";
            this.lensPc.Size = new System.Drawing.Size(466, 443);
            this.lensPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lensPc.TabIndex = 10;
            this.lensPc.TabStop = false;
            // 
            // normalizeCb
            // 
            this.normalizeCb.AutoSize = true;
            this.normalizeCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.normalizeCb.Location = new System.Drawing.Point(35, 47);
            this.normalizeCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.normalizeCb.Name = "normalizeCb";
            this.normalizeCb.Size = new System.Drawing.Size(206, 27);
            this.normalizeCb.TabIndex = 11;
            this.normalizeCb.Text = "Нормировать яркость";
            this.normalizeCb.UseVisualStyleBackColor = true;
            this.normalizeCb.CheckedChanged += new System.EventHandler(this.normalizeCb_CheckedChanged);
            // 
            // interpolateCb
            // 
            this.interpolateCb.AutoSize = true;
            this.interpolateCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interpolateCb.Location = new System.Drawing.Point(35, 89);
            this.interpolateCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interpolateCb.Name = "interpolateCb";
            this.interpolateCb.Size = new System.Drawing.Size(174, 27);
            this.interpolateCb.TabIndex = 12;
            this.interpolateCb.Text = "Интерполировать";
            this.interpolateCb.UseVisualStyleBackColor = true;
            this.interpolateCb.CheckedChanged += new System.EventHandler(this.interpolateCb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.interpolateCb);
            this.groupBox3.Controls.Add(this.normalizeCb);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(313, 795);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(424, 155);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштабирование";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton4);
            this.groupBox7.Controls.Add(this.radioButton3);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Location = new System.Drawing.Point(253, 19);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(165, 128);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Увеличить в:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(93, 75);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(40, 27);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "7";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(93, 37);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(40, 27);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "5";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 75);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(1002, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(238, 96);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Размер фрагмента";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "<-- задать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 30);
            this.textBox1.TabIndex = 0;
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 1028);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lensPc);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.shiftCodesGb);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormController";
            this.Text = "Лабораторная работа № 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.shiftCodesGb.ResumeLayout(false);
            this.shiftCodesGb.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayedPicturePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lensPc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Label loadedFileLbl;
        private System.Windows.Forms.GroupBox shiftCodesGb;
        private System.Windows.Forms.RadioButton codeShift_0;
        private System.Windows.Forms.RadioButton codeShift_1;
        private System.Windows.Forms.RadioButton codeShift_2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox topImgLinesTb;
        private System.Windows.Forms.Button setTopLinesBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xCompZoneTb;
        private System.Windows.Forms.TextBox xMatrixTb;
        private System.Windows.Forms.TextBox yTb;
        private System.Windows.Forms.TextBox brightnessTb;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox displayedPicturePanel;
        private System.Windows.Forms.PictureBox lensPc;
        private System.Windows.Forms.CheckBox normalizeCb;
        private System.Windows.Forms.CheckBox interpolateCb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

