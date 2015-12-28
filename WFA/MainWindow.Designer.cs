namespace WindowsFormsApplication1
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.MakePreviewButton = new System.Windows.Forms.Button();
            this.TextBoxForAll = new System.Windows.Forms.TextBox();
            this.textDelta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LineButton = new System.Windows.Forms.Button();
            this.textBlock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.x4 = new System.Windows.Forms.RadioButton();
            this.x3 = new System.Windows.Forms.RadioButton();
            this.x2 = new System.Windows.Forms.RadioButton();
            this.x = new System.Windows.Forms.RadioButton();
            this.MakePointsButton = new System.Windows.Forms.Button();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reDrawButton = new System.Windows.Forms.Button();
            this.reDrawPreviewButton = new System.Windows.Forms.Button();
            this.reGAnerateBurtton = new System.Windows.Forms.Button();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textWhite = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBlack = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxInverse = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // textPoints
            // 
            this.textPoints.Location = new System.Drawing.Point(83, 321);
            this.textPoints.Name = "textPoints";
            this.textPoints.Size = new System.Drawing.Size(34, 20);
            this.textPoints.TabIndex = 4;
            this.textPoints.Text = "400";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num points";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(15, 12);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(102, 23);
            this.LoadImageButton.TabIndex = 5;
            this.LoadImageButton.Text = "Load image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // MakePreviewButton
            // 
            this.MakePreviewButton.Location = new System.Drawing.Point(15, 370);
            this.MakePreviewButton.Name = "MakePreviewButton";
            this.MakePreviewButton.Size = new System.Drawing.Size(102, 22);
            this.MakePreviewButton.TabIndex = 7;
            this.MakePreviewButton.Text = "Make preview";
            this.MakePreviewButton.UseVisualStyleBackColor = true;
            this.MakePreviewButton.Click += new System.EventHandler(this.MakePreviewButton_Click);
            // 
            // TextBoxForAll
            // 
            this.TextBoxForAll.Location = new System.Drawing.Point(145, 270);
            this.TextBoxForAll.Multiline = true;
            this.TextBoxForAll.Name = "TextBoxForAll";
            this.TextBoxForAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxForAll.Size = new System.Drawing.Size(126, 116);
            this.TextBoxForAll.TabIndex = 10;
            // 
            // textDelta
            // 
            this.textDelta.Location = new System.Drawing.Point(83, 448);
            this.textDelta.Name = "textDelta";
            this.textDelta.Size = new System.Drawing.Size(34, 20);
            this.textDelta.TabIndex = 13;
            this.textDelta.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "delta for line";
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(15, 498);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(102, 22);
            this.LineButton.TabIndex = 22;
            this.LineButton.Text = " line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // textBlock
            // 
            this.textBlock.Location = new System.Drawing.Point(83, 474);
            this.textBlock.Name = "textBlock";
            this.textBlock.Size = new System.Drawing.Size(34, 20);
            this.textBlock.TabIndex = 24;
            this.textBlock.Text = "150";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "block for line";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = ":Black";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "White:";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(15, 175);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(25, 20);
            this.textA.TabIndex = 29;
            this.textA.Text = "0";
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(246, 175);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(25, 20);
            this.textB.TabIndex = 30;
            this.textB.Text = "255";
            // 
            // textD
            // 
            this.textD.Location = new System.Drawing.Point(83, 201);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(34, 20);
            this.textD.TabIndex = 34;
            this.textD.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "D (1~0.25mm)";
            // 
            // textH
            // 
            this.textH.Location = new System.Drawing.Point(83, 225);
            this.textH.Name = "textH";
            this.textH.Size = new System.Drawing.Size(34, 20);
            this.textH.TabIndex = 32;
            this.textH.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "H (1~0.25mm)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.x4);
            this.groupBox1.Controls.Add(this.x3);
            this.groupBox1.Controls.Add(this.x2);
            this.groupBox1.Controls.Add(this.x);
            this.groupBox1.Location = new System.Drawing.Point(145, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 63);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // x4
            // 
            this.x4.AutoSize = true;
            this.x4.Location = new System.Drawing.Point(78, 42);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(42, 17);
            this.x4.TabIndex = 3;
            this.x4.Text = "x^4";
            this.x4.UseVisualStyleBackColor = true;
            // 
            // x3
            // 
            this.x3.AutoSize = true;
            this.x3.Location = new System.Drawing.Point(78, 19);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(42, 17);
            this.x3.TabIndex = 2;
            this.x3.Text = "x^3";
            this.x3.UseVisualStyleBackColor = true;
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Checked = true;
            this.x2.Location = new System.Drawing.Point(11, 42);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(42, 17);
            this.x2.TabIndex = 1;
            this.x2.TabStop = true;
            this.x2.Text = "x^2";
            this.x2.UseVisualStyleBackColor = true;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(11, 19);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(30, 17);
            this.x.TabIndex = 0;
            this.x.Text = "x";
            this.x.UseVisualStyleBackColor = true;
            // 
            // MakePointsButton
            // 
            this.MakePointsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakePointsButton.Location = new System.Drawing.Point(169, 497);
            this.MakePointsButton.Name = "MakePointsButton";
            this.MakePointsButton.Size = new System.Drawing.Size(102, 22);
            this.MakePointsButton.TabIndex = 36;
            this.MakePointsButton.Text = "Make points";
            this.MakePointsButton.UseVisualStyleBackColor = true;
            this.MakePointsButton.Click += new System.EventHandler(this.MakePointsButton_Click);
            // 
            // picturePreview
            // 
            this.picturePreview.Location = new System.Drawing.Point(29, 537);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(222, 315);
            this.picturePreview.TabIndex = 38;
            this.picturePreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "D = H, иначе глупо";
            // 
            // reDrawButton
            // 
            this.reDrawButton.Location = new System.Drawing.Point(96, 153);
            this.reDrawButton.Name = "reDrawButton";
            this.reDrawButton.Size = new System.Drawing.Size(102, 38);
            this.reDrawButton.TabIndex = 40;
            this.reDrawButton.Text = "ReDraw";
            this.reDrawButton.UseVisualStyleBackColor = true;
            this.reDrawButton.Click += new System.EventHandler(this.reDrawButton_Click);
            // 
            // reDrawPreviewButton
            // 
            this.reDrawPreviewButton.Location = new System.Drawing.Point(15, 420);
            this.reDrawPreviewButton.Name = "reDrawPreviewButton";
            this.reDrawPreviewButton.Size = new System.Drawing.Size(102, 22);
            this.reDrawPreviewButton.TabIndex = 41;
            this.reDrawPreviewButton.Text = "reDraw preview";
            this.reDrawPreviewButton.UseVisualStyleBackColor = true;
            this.reDrawPreviewButton.Click += new System.EventHandler(this.reDrawPreviewButton_Click);
            // 
            // reGAnerateBurtton
            // 
            this.reGAnerateBurtton.Location = new System.Drawing.Point(15, 345);
            this.reGAnerateBurtton.Name = "reGAnerateBurtton";
            this.reGAnerateBurtton.Size = new System.Drawing.Size(102, 22);
            this.reGAnerateBurtton.TabIndex = 42;
            this.reGAnerateBurtton.Text = "ReGanerate";
            this.reGAnerateBurtton.UseVisualStyleBackColor = true;
            this.reGAnerateBurtton.Click += new System.EventHandler(this.reGAnerateBurtton_Click);
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(83, 295);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(34, 20);
            this.textWidth.TabIndex = 43;
            this.textWidth.Text = "148";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(83, 271);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(34, 20);
            this.textHeight.TabIndex = 44;
            this.textHeight.Text = "210";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "WIDTH (мм)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "HEIGHT (мм)";
            // 
            // textWhite
            // 
            this.textWhite.Location = new System.Drawing.Point(237, 446);
            this.textWhite.Name = "textWhite";
            this.textWhite.Size = new System.Drawing.Size(34, 20);
            this.textWhite.TabIndex = 48;
            this.textWhite.Text = "220";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "for white";
            // 
            // textBlack
            // 
            this.textBlack.Location = new System.Drawing.Point(237, 392);
            this.textBlack.Name = "textBlack";
            this.textBlack.Size = new System.Drawing.Size(34, 20);
            this.textBlack.TabIndex = 50;
            this.textBlack.Text = "25";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(187, 395);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "for black";
            // 
            // buttonBlack
            // 
            this.buttonBlack.Location = new System.Drawing.Point(169, 415);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(102, 22);
            this.buttonBlack.TabIndex = 51;
            this.buttonBlack.Text = " black";
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.Location = new System.Drawing.Point(169, 469);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(102, 22);
            this.buttonWhite.TabIndex = 52;
            this.buttonWhite.Text = "white";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(15, 395);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 22);
            this.buttonClear.TabIndex = 53;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxInverse
            // 
            this.checkBoxInverse.AutoSize = true;
            this.checkBoxInverse.Location = new System.Drawing.Point(145, 16);
            this.checkBoxInverse.Name = "checkBoxInverse";
            this.checkBoxInverse.Size = new System.Drawing.Size(87, 17);
            this.checkBoxInverse.TabIndex = 54;
            this.checkBoxInverse.Text = "Inverse color";
            this.checkBoxInverse.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 862);
            this.Controls.Add(this.checkBoxInverse);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.textBlack);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textWhite);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.reGAnerateBurtton);
            this.Controls.Add(this.reDrawPreviewButton);
            this.Controls.Add(this.reDrawButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturePreview);
            this.Controls.Add(this.MakePointsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBlock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.textDelta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxForAll);
            this.Controls.Add(this.MakePreviewButton);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.textPoints);
            this.Controls.Add(this.label2);
            this.Name = "MainWindow";
            this.Text = "Pr. Pointers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button MakePreviewButton;
        private System.Windows.Forms.TextBox TextBoxForAll;
        private System.Windows.Forms.TextBox textDelta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.TextBox textBlock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton x4;
        private System.Windows.Forms.RadioButton x3;
        private System.Windows.Forms.RadioButton x2;
        private System.Windows.Forms.RadioButton x;
        private System.Windows.Forms.Button MakePointsButton;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reDrawButton;
        private System.Windows.Forms.Button reDrawPreviewButton;
        private System.Windows.Forms.Button reGAnerateBurtton;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textWhite;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBlack;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxInverse;
    }
}

