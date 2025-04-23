namespace WinFormsApp5
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
            groupBox1 = new GroupBox();
            TxtAge = new TextBox();
            LblAge = new Label();
            TxtGender = new TextBox();
            LblGender = new Label();
            TxtPhone = new TextBox();
            LblPhone = new Label();
            TxtName = new TextBox();
            LblName = new Label();
            BtnOk = new Button();
            TxtResult = new TextBox();
            LblResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtAge);
            groupBox1.Controls.Add(LblAge);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(LblGender);
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(LblPhone);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(LblName);
            groupBox1.Location = new Point(28, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "사람 정보 입력";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(71, 71);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(100, 23);
            TxtAge.TabIndex = 11;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(24, 74);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(31, 15);
            LblAge.TabIndex = 10;
            LblAge.Text = "나이";
            LblAge.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(71, 100);
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(100, 23);
            TxtGender.TabIndex = 9;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(24, 103);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(31, 15);
            LblGender.TabIndex = 8;
            LblGender.Text = "성별";
            LblGender.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(71, 129);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(100, 23);
            TxtPhone.TabIndex = 7;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Location = new Point(12, 132);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(43, 15);
            LblPhone.TabIndex = 6;
            LblPhone.Text = "핸드폰";
            LblPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(71, 42);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 1;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(24, 45);
            LblName.Name = "LblName";
            LblName.Size = new Size(31, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름";
            LblName.TextAlign = ContentAlignment.TopRight;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(692, 392);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 1;
            BtnOk.Text = "확인";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // TxtResult
            // 
            TxtResult.BorderStyle = BorderStyle.FixedSingle;
            TxtResult.Location = new Point(351, 39);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(416, 347);
            TxtResult.TabIndex = 2;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(351, 21);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(31, 15);
            LblResult.TabIndex = 3;
            LblResult.Text = "결과";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResult);
            Controls.Add(TxtResult);
            Controls.Add(BtnOk);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnOk;
        private TextBox TxtName;
        private Label LblName;
        private TextBox TxtResult;
        private TextBox TxtAge;
        private Label LblAge;
        private TextBox TxtGender;
        private Label LblGender;
        private TextBox TxtPhone;
        private Label LblPhone;
        private Label LblResult;
    }
}
