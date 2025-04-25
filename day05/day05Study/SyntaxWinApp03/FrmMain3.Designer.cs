namespace SyntaxWinApp03
{
    partial class FrmMain3
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
            BtnStart = new Button();
            TxtLog = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            LblCurrState = new ToolStripStatusLabel();
            PrgProcess = new ToolStripProgressBar();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(438, 232);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(99, 32);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(12, 27);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.ScrollBars = ScrollBars.Vertical;
            TxtLog.Size = new Size(525, 199);
            TxtLog.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "로그";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblCurrState, PrgProcess });
            statusStrip1.Location = new Point(0, 269);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(550, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblCurrState
            // 
            LblCurrState.Name = "LblCurrState";
            LblCurrState.Size = new Size(90, 17);
            LblCurrState.Text = "현재상태 : 중지";
            // 
            // PrgProcess
            // 
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(380, 16);
            // 
            // FrmMain3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 291);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(TxtLog);
            Controls.Add(BtnStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "스레드 연습 앱";
            Load += FrmMain3_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private TextBox TxtLog;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LblCurrState;
        private ToolStripProgressBar PrgProcess;
    }
}
