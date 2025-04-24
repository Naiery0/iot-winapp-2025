namespace SyntaxWinApp02
{
    partial class FrmMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain2));
            label1 = new Label();
            button1 = new Button();
            imageList1 = new ImageList(components);
            CboArray = new ComboBox();
            label2 = new Label();
            CboList = new ComboBox();
            label3 = new Label();
            CboDictionary = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "배열로 할당";
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new Point(522, 309);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(100, 40);
            button1.TabIndex = 2;
            button1.Text = "체크";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "plus.png");
            // 
            // CboArray
            // 
            CboArray.FormattingEnabled = true;
            CboArray.Location = new Point(103, 6);
            CboArray.Name = "CboArray";
            CboArray.Size = new Size(121, 23);
            CboArray.TabIndex = 3;
            CboArray.SelectedIndexChanged += CboArray_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 38);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 0;
            label2.Text = "리스트로 할당";
            // 
            // CboList
            // 
            CboList.FormattingEnabled = true;
            CboList.Location = new Point(103, 35);
            CboList.Name = "CboList";
            CboList.Size = new Size(121, 23);
            CboList.TabIndex = 3;
            CboList.SelectedIndexChanged += CboList_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 67);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "딕셔너리로 할당";
            // 
            // CboDictionary
            // 
            CboDictionary.FormattingEnabled = true;
            CboDictionary.Location = new Point(103, 64);
            CboDictionary.Name = "CboDictionary";
            CboDictionary.Size = new Size(121, 23);
            CboDictionary.TabIndex = 3;
            // 
            // FrmMain2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
            Controls.Add(CboDictionary);
            Controls.Add(CboList);
            Controls.Add(label3);
            Controls.Add(CboArray);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmMain2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "컬렉션 학습";
            Load += FrmMain2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ImageList imageList1;
        private ComboBox CboArray;
        private Label label2;
        private ComboBox CboList;
        private Label label3;
        private ComboBox CboDictionary;
    }
}
