namespace WinFormsApp6
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnOk = new Button();
            ImlForm = new ImageList(components);
            PicComputer = new PictureBox();
            CboDivision = new ComboBox();
            label1 = new Label();
            ImlBigImg = new ImageList(components);
            BtnPlus = new Button();
            ((System.ComponentModel.ISupportInitialize)PicComputer).BeginInit();
            SuspendLayout();
            // 
            // BtnOk
            // 
            BtnOk.ImageAlign = ContentAlignment.MiddleLeft;
            BtnOk.ImageIndex = 0;
            BtnOk.ImageList = ImlForm;
            BtnOk.Location = new Point(688, 398);
            BtnOk.Name = "BtnOk";
            BtnOk.Padding = new Padding(12, 0, 0, 0);
            BtnOk.Size = new Size(100, 40);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "Okay";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // ImlForm
            // 
            ImlForm.ColorDepth = ColorDepth.Depth32Bit;
            ImlForm.ImageStream = (ImageListStreamer)resources.GetObject("ImlForm.ImageStream");
            ImlForm.TransparentColor = Color.Transparent;
            ImlForm.Images.SetKeyName(0, "check.png");
            ImlForm.Images.SetKeyName(1, "plus.png");
            // 
            // PicComputer
            // 
            PicComputer.Image = Properties.Resources.computer_case;
            PicComputer.Location = new Point(15, 20);
            PicComputer.Name = "PicComputer";
            PicComputer.Size = new Size(397, 406);
            PicComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            PicComputer.TabIndex = 1;
            PicComputer.TabStop = false;
            // 
            // CboDivision
            // 
            CboDivision.FormattingEnabled = true;
            CboDivision.Items.AddRange(new object[] { "Computer", "Notebook", "Server" });
            CboDivision.Location = new Point(655, 20);
            CboDivision.Name = "CboDivision";
            CboDivision.Size = new Size(121, 23);
            CboDivision.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(611, 23);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "종류: ";
            // 
            // ImlBigImg
            // 
            ImlBigImg.ColorDepth = ColorDepth.Depth32Bit;
            ImlBigImg.ImageSize = new Size(256, 256);
            ImlBigImg.TransparentColor = Color.Transparent;
            // 
            // BtnPlus
            // 
            BtnPlus.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPlus.ImageIndex = 1;
            BtnPlus.ImageList = ImlForm;
            BtnPlus.Location = new Point(573, 398);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Padding = new Padding(12, 0, 0, 0);
            BtnPlus.Size = new Size(100, 40);
            BtnPlus.TabIndex = 4;
            BtnPlus.Text = "복사";
            BtnPlus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnPlus);
            Controls.Add(label1);
            Controls.Add(CboDivision);
            Controls.Add(PicComputer);
            Controls.Add(BtnOk);
            Name = "Form1";
            Padding = new Padding(12, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱02";
            //Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PicComputer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOk;
        private ImageList ImlForm;
        private PictureBox PicComputer;
        private ComboBox CboDivision;
        private Label label1;
        private ImageList ImlBigImg;
        private Button BtnPlus;
    }
}
