namespace WinFormsApp4
{
    partial class Frm4
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
            LblName = new Label();
            TxtName = new TextBox();
            LblAge = new Label();
            LblGender = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            BtnOk = new Button();
            TxtResult = new TextBox();
            LblResult = new Label();
            TxtAge = new MaskedTextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(55, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(74, 12);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(128, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(12, 44);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(55, 15);
            LblAge.TabIndex = 2;
            LblAge.Text = "나이입력";
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(12, 72);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(55, 15);
            LblGender.TabIndex = 4;
            LblGender.Text = "성별입력";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Checked = true;
            RdoMale.Location = new Point(85, 70);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 3;
            RdoMale.TabStop = true;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(141, 70);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 4;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(688, 398);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(100, 40);
            BtnOk.TabIndex = 6;
            BtnOk.Text = "확인";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // TxtResult
            // 
            TxtResult.Enabled = false;
            TxtResult.Location = new Point(74, 174);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(714, 23);
            TxtResult.TabIndex = 5;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(12, 177);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(55, 15);
            LblResult.TabIndex = 8;
            LblResult.Text = "      결과";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(74, 41);
            TxtAge.Mask = "0000-00-00";
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(128, 23);
            TxtAge.TabIndex = 2;
            // 
            // Frm4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtAge);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(BtnOk);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMale);
            Controls.Add(LblGender);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "Frm4";
            Text = "문법연습 윈앱4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private Label LblGender;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private Button BtnOk;
        private TextBox TxtResult;
        private Label LblResult;
        private MaskedTextBox TxtAge;
    }
}
