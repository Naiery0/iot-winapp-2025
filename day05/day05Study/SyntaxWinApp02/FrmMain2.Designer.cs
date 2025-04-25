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
            BtnCheck = new Button();
            TxtLog = new TextBox();
            TxtTest = new TextBox();
            BtnGeneric = new Button();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(461, 251);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(95, 41);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "button1";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(12, 12);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(544, 233);
            TxtLog.TabIndex = 1;
            // 
            // TxtTest
            // 
            TxtTest.Location = new Point(12, 261);
            TxtTest.Name = "TxtTest";
            TxtTest.Size = new Size(100, 23);
            TxtTest.TabIndex = 2;
            TxtTest.KeyPress += TxtTest_KeyPress;
            // 
            // BtnGeneric
            // 
            BtnGeneric.Location = new Point(367, 261);
            BtnGeneric.Name = "BtnGeneric";
            BtnGeneric.Size = new Size(75, 23);
            BtnGeneric.TabIndex = 3;
            BtnGeneric.Text = "button1";
            BtnGeneric.UseVisualStyleBackColor = true;
            BtnGeneric.Click += BtnGeneric_Click;
            // 
            // FrmMain2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 304);
            Controls.Add(BtnGeneric);
            Controls.Add(TxtTest);
            Controls.Add(TxtLog);
            Controls.Add(BtnCheck);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private TextBox TxtLog;
        private TextBox TxtTest;
        private Button BtnGeneric;
    }
}
