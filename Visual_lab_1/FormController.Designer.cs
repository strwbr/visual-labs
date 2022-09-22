
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.shiftCodesGb.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayedPicturePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadFileBtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 70);
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
            this.groupBox2.Size = new System.Drawing.Size(308, 49);
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
            this.shiftCodesGb.Location = new System.Drawing.Point(461, 14);
            this.shiftCodesGb.Name = "shiftCodesGb";
            this.shiftCodesGb.Size = new System.Drawing.Size(200, 70);
            this.shiftCodesGb.TabIndex = 1;
            this.shiftCodesGb.TabStop = false;
            this.shiftCodesGb.Text = "Сдвигать коды на:";
            // 
            // codeShift_2
            // 
            this.codeShift_2.AutoSize = true;
            this.codeShift_2.Location = new System.Drawing.Point(128, 30);
            this.codeShift_2.Name = "codeShift_2";
            this.codeShift_2.Size = new System.Drawing.Size(35, 23);
            this.codeShift_2.TabIndex = 2;
            this.codeShift_2.Text = "2";
            this.codeShift_2.UseVisualStyleBackColor = true;
            // 
            // codeShift_1
            // 
            this.codeShift_1.AutoSize = true;
            this.codeShift_1.Location = new System.Drawing.Point(90, 30);
            this.codeShift_1.Name = "codeShift_1";
            this.codeShift_1.Size = new System.Drawing.Size(35, 23);
            this.codeShift_1.TabIndex = 1;
            this.codeShift_1.Text = "1";
            this.codeShift_1.UseVisualStyleBackColor = true;
            // 
            // codeShift_0
            // 
            this.codeShift_0.AutoSize = true;
            this.codeShift_0.Location = new System.Drawing.Point(52, 30);
            this.codeShift_0.Name = "codeShift_0";
            this.codeShift_0.Size = new System.Drawing.Size(35, 23);
            this.codeShift_0.TabIndex = 0;
            this.codeShift_0.Text = "0";
            this.codeShift_0.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.setTopLinesBtn);
            this.groupBox4.Controls.Add(this.topImgLinesTb);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(667, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 70);
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
            this.groupBox6.Location = new System.Drawing.Point(12, 596);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(239, 161);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Координаты курсора:";
            // 
            // brightnessTb
            // 
            this.brightnessTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brightnessTb.Location = new System.Drawing.Point(159, 122);
            this.brightnessTb.Name = "brightnessTb";
            this.brightnessTb.ReadOnly = true;
            this.brightnessTb.Size = new System.Drawing.Size(50, 27);
            this.brightnessTb.TabIndex = 7;
            // 
            // yTb
            // 
            this.yTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yTb.Location = new System.Drawing.Point(159, 89);
            this.yTb.Name = "yTb";
            this.yTb.ReadOnly = true;
            this.yTb.Size = new System.Drawing.Size(50, 27);
            this.yTb.TabIndex = 6;
            // 
            // xMatrixTb
            // 
            this.xMatrixTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xMatrixTb.Location = new System.Drawing.Point(159, 56);
            this.xMatrixTb.Name = "xMatrixTb";
            this.xMatrixTb.ReadOnly = true;
            this.xMatrixTb.Size = new System.Drawing.Size(50, 27);
            this.xMatrixTb.TabIndex = 5;
            // 
            // xCompZoneTb
            // 
            this.xCompZoneTb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xCompZoneTb.Location = new System.Drawing.Point(159, 23);
            this.xCompZoneTb.Name = "xCompZoneTb";
            this.xCompZoneTb.ReadOnly = true;
            this.xCompZoneTb.Size = new System.Drawing.Size(50, 27);
            this.xCompZoneTb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(53, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Яркость:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Х (мартица) = ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Х (ЗК) =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picturePanel
            // 
            this.picturePanel.AutoScroll = true;
            this.picturePanel.Controls.Add(this.displayedPicturePanel);
            this.picturePanel.Location = new System.Drawing.Point(13, 90);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(910, 500);
            this.picturePanel.TabIndex = 9;
            // 
            // displayedPicturePanel
            // 
            this.displayedPicturePanel.Location = new System.Drawing.Point(0, 0);
            this.displayedPicturePanel.Name = "displayedPicturePanel";
            this.displayedPicturePanel.Size = new System.Drawing.Size(559, 334);
            this.displayedPicturePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.displayedPicturePanel.TabIndex = 0;
            this.displayedPicturePanel.TabStop = false;
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 771);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.shiftCodesGb);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.ResumeLayout(false);

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
    }
}

