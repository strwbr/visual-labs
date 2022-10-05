
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
            this.xTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.displayedPicturePanel = new System.Windows.Forms.PictureBox();
            this.lensPc = new System.Windows.Forms.PictureBox();
            this.normalizeCb = new System.Windows.Forms.CheckBox();
            this.interpolateCb = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scaleValueGb = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.overviewImagePb = new System.Windows.Forms.PictureBox();
            this.createOverviewImageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.shiftCodesGb.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayedPicturePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lensPc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.scaleValueGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewImagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadFileBtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка tiff-файла";
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(6, 28);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(117, 33);
            this.loadFileBtn.TabIndex = 1;
            this.loadFileBtn.Text = "Загрузить";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadedFileLbl);
            this.groupBox2.Location = new System.Drawing.Point(129, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Загружено изображение";
            // 
            // loadedFileLbl
            // 
            this.loadedFileLbl.AutoSize = true;
            this.loadedFileLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadedFileLbl.Location = new System.Drawing.Point(7, 23);
            this.loadedFileLbl.Name = "loadedFileLbl";
            this.loadedFileLbl.Size = new System.Drawing.Size(138, 19);
            this.loadedFileLbl.TabIndex = 0;
            this.loadedFileLbl.Text = "Файл не загружен";
            // 
            // shiftCodesGb
            // 
            this.shiftCodesGb.Controls.Add(this.codeShift_2);
            this.shiftCodesGb.Controls.Add(this.codeShift_1);
            this.shiftCodesGb.Controls.Add(this.codeShift_0);
            this.shiftCodesGb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shiftCodesGb.Location = new System.Drawing.Point(427, 13);
            this.shiftCodesGb.Name = "shiftCodesGb";
            this.shiftCodesGb.Size = new System.Drawing.Size(182, 72);
            this.shiftCodesGb.TabIndex = 1;
            this.shiftCodesGb.TabStop = false;
            this.shiftCodesGb.Text = "Сдвигать коды на:";
            // 
            // codeShift_2
            // 
            this.codeShift_2.AutoSize = true;
            this.codeShift_2.Location = new System.Drawing.Point(110, 30);
            this.codeShift_2.Name = "codeShift_2";
            this.codeShift_2.Size = new System.Drawing.Size(35, 23);
            this.codeShift_2.TabIndex = 2;
            this.codeShift_2.Text = "2";
            this.codeShift_2.UseVisualStyleBackColor = true;
            // 
            // codeShift_1
            // 
            this.codeShift_1.AutoSize = true;
            this.codeShift_1.Location = new System.Drawing.Point(69, 30);
            this.codeShift_1.Name = "codeShift_1";
            this.codeShift_1.Size = new System.Drawing.Size(35, 23);
            this.codeShift_1.TabIndex = 1;
            this.codeShift_1.Text = "1";
            this.codeShift_1.UseVisualStyleBackColor = true;
            // 
            // codeShift_0
            // 
            this.codeShift_0.AutoSize = true;
            this.codeShift_0.Checked = true;
            this.codeShift_0.Location = new System.Drawing.Point(26, 30);
            this.codeShift_0.Name = "codeShift_0";
            this.codeShift_0.Size = new System.Drawing.Size(35, 23);
            this.codeShift_0.TabIndex = 0;
            this.codeShift_0.TabStop = true;
            this.codeShift_0.Text = "0";
            this.codeShift_0.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.setTopLinesBtn);
            this.groupBox4.Controls.Add(this.topImgLinesTb);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(615, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Верхние строки изображений:";
            // 
            // setTopLinesBtn
            // 
            this.setTopLinesBtn.Location = new System.Drawing.Point(144, 26);
            this.setTopLinesBtn.Name = "setTopLinesBtn";
            this.setTopLinesBtn.Size = new System.Drawing.Size(95, 31);
            this.setTopLinesBtn.TabIndex = 1;
            this.setTopLinesBtn.Text = "<-- задать";
            this.setTopLinesBtn.UseVisualStyleBackColor = true;
            // 
            // topImgLinesTb
            // 
            this.topImgLinesTb.Location = new System.Drawing.Point(24, 30);
            this.topImgLinesTb.Name = "topImgLinesTb";
            this.topImgLinesTb.Size = new System.Drawing.Size(102, 25);
            this.topImgLinesTb.TabIndex = 0;
            this.topImgLinesTb.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.brightnessTb);
            this.groupBox6.Controls.Add(this.yTb);
            this.groupBox6.Controls.Add(this.xTb);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(12, 496);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 127);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Координаты курсора:";
            // 
            // brightnessTb
            // 
            this.brightnessTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brightnessTb.Location = new System.Drawing.Point(112, 89);
            this.brightnessTb.Name = "brightnessTb";
            this.brightnessTb.ReadOnly = true;
            this.brightnessTb.Size = new System.Drawing.Size(50, 27);
            this.brightnessTb.TabIndex = 7;
            // 
            // yTb
            // 
            this.yTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yTb.Location = new System.Drawing.Point(112, 56);
            this.yTb.Name = "yTb";
            this.yTb.ReadOnly = true;
            this.yTb.Size = new System.Drawing.Size(50, 27);
            this.yTb.TabIndex = 6;
            // 
            // xCompZoneTb
            // 
            this.xTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xTb.Location = new System.Drawing.Point(112, 24);
            this.xTb.Name = "xCompZoneTb";
            this.xTb.ReadOnly = true;
            this.xTb.Size = new System.Drawing.Size(50, 27);
            this.xTb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Яркость:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Х =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picturePanel
            // 
            this.picturePanel.AutoScroll = true;
            this.picturePanel.Controls.Add(this.displayedPicturePanel);
            this.picturePanel.Location = new System.Drawing.Point(13, 90);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(573, 400);
            this.picturePanel.TabIndex = 9;
            // 
            // displayedPicturePanel
            // 
            this.displayedPicturePanel.Location = new System.Drawing.Point(0, 0);
            this.displayedPicturePanel.Name = "displayedPicturePanel";
            this.displayedPicturePanel.Size = new System.Drawing.Size(559, 200);
            this.displayedPicturePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.displayedPicturePanel.TabIndex = 0;
            this.displayedPicturePanel.TabStop = false;
            // 
            // lensPc
            // 
            this.lensPc.Location = new System.Drawing.Point(592, 116);
            this.lensPc.Name = "lensPc";
            this.lensPc.Size = new System.Drawing.Size(425, 425);
            this.lensPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lensPc.TabIndex = 10;
            this.lensPc.TabStop = false;
            // 
            // normalizeCb
            // 
            this.normalizeCb.AutoSize = true;
            this.normalizeCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.normalizeCb.Location = new System.Drawing.Point(23, 35);
            this.normalizeCb.Name = "normalizeCb";
            this.normalizeCb.Size = new System.Drawing.Size(168, 23);
            this.normalizeCb.TabIndex = 11;
            this.normalizeCb.Text = "Нормировать яркость";
            this.normalizeCb.UseVisualStyleBackColor = true;
            this.normalizeCb.CheckedChanged += new System.EventHandler(this.normalizeCb_CheckedChanged);
            // 
            // interpolateCb
            // 
            this.interpolateCb.AutoSize = true;
            this.interpolateCb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interpolateCb.Location = new System.Drawing.Point(23, 80);
            this.interpolateCb.Name = "interpolateCb";
            this.interpolateCb.Size = new System.Drawing.Size(141, 23);
            this.interpolateCb.TabIndex = 12;
            this.interpolateCb.Text = "Интерполировать";
            this.interpolateCb.UseVisualStyleBackColor = true;
            this.interpolateCb.CheckedChanged += new System.EventHandler(this.interpolateCb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scaleValueGb);
            this.groupBox3.Controls.Add(this.interpolateCb);
            this.groupBox3.Controls.Add(this.normalizeCb);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(208, 496);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 127);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштабирование";
            // 
            // scaleValueGb
            // 
            this.scaleValueGb.Controls.Add(this.radioButton4);
            this.scaleValueGb.Controls.Add(this.radioButton3);
            this.scaleValueGb.Controls.Add(this.radioButton2);
            this.scaleValueGb.Location = new System.Drawing.Point(239, 10);
            this.scaleValueGb.Name = "scaleValueGb";
            this.scaleValueGb.Size = new System.Drawing.Size(125, 111);
            this.scaleValueGb.TabIndex = 14;
            this.scaleValueGb.TabStop = false;
            this.scaleValueGb.Text = "Увеличить в:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 82);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(35, 23);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "7";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 23);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "5";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // overviewImagePb
            // 
            this.overviewImagePb.Location = new System.Drawing.Point(1023, 35);
            this.overviewImagePb.Name = "overviewImagePb";
            this.overviewImagePb.Size = new System.Drawing.Size(100, 50);
            this.overviewImagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.overviewImagePb.TabIndex = 14;
            this.overviewImagePb.TabStop = false;
            // 
            // createOverviewImageBtn
            // 
            this.createOverviewImageBtn.AutoSize = true;
            this.createOverviewImageBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createOverviewImageBtn.Location = new System.Drawing.Point(12, 629);
            this.createOverviewImageBtn.Name = "createOverviewImageBtn";
            this.createOverviewImageBtn.Size = new System.Drawing.Size(311, 31);
            this.createOverviewImageBtn.TabIndex = 15;
            this.createOverviewImageBtn.Text = "Построить обзорное изображение";
            this.createOverviewImageBtn.UseVisualStyleBackColor = true;
            this.createOverviewImageBtn.Click += new System.EventHandler(this.createOverviewImageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(592, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Увеличенный фрагмент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1023, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Обзорное изображение";
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 709);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createOverviewImageBtn);
            this.Controls.Add(this.overviewImagePb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lensPc);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.shiftCodesGb);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormController";
            this.Text = "Лабораторная работа № 2";
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
            this.scaleValueGb.ResumeLayout(false);
            this.scaleValueGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewImagePb)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xTb;
        private System.Windows.Forms.TextBox yTb;
        private System.Windows.Forms.TextBox brightnessTb;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox displayedPicturePanel;
        private System.Windows.Forms.PictureBox lensPc;
        private System.Windows.Forms.CheckBox normalizeCb;
        private System.Windows.Forms.CheckBox interpolateCb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox scaleValueGb;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.PictureBox overviewImagePb;
        private System.Windows.Forms.Button createOverviewImageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}

