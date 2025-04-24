﻿namespace SyntaxWinApp03
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
            BtnSave = new Button();
            BtnLoad = new Button();
            RtbNote = new RichTextBox();
            BtnBold = new Button();
            BrnRed = new Button();
            DlgOpen = new OpenFileDialog();
            DlgSave = new SaveFileDialog();
            DlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(366, 251);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 28);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(472, 251);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(100, 28);
            BtnLoad.TabIndex = 0;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // RtbNote
            // 
            RtbNote.Font = new Font("나눔고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RtbNote.Location = new Point(12, 11);
            RtbNote.Name = "RtbNote";
            RtbNote.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            RtbNote.Size = new Size(560, 235);
            RtbNote.TabIndex = 1;
            RtbNote.Text = "";
            RtbNote.TextChanged += RtbNote_TextChanged;
            // 
            // BtnBold
            // 
            BtnBold.BackColor = SystemColors.ControlLight;
            BtnBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnBold.ForeColor = SystemColors.ActiveCaptionText;
            BtnBold.Location = new Point(332, 251);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(28, 28);
            BtnBold.TabIndex = 2;
            BtnBold.Text = "B";
            BtnBold.UseVisualStyleBackColor = false;
            BtnBold.Click += BtnBold_Click;
            // 
            // BrnRed
            // 
            BrnRed.BackColor = SystemColors.ControlLight;
            BrnRed.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BrnRed.ForeColor = Color.Red;
            BrnRed.Location = new Point(298, 251);
            BrnRed.Name = "BrnRed";
            BrnRed.Size = new Size(28, 28);
            BrnRed.TabIndex = 2;
            BrnRed.Text = "R";
            BrnRed.UseVisualStyleBackColor = false;
            BrnRed.Click += BrnRed_Click;
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            DlgOpen.FileOk += openFileDialog1_FileOk;
            // 
            // FrmMain3
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 290);
            Controls.Add(BrnRed);
            Controls.Add(BtnBold);
            Controls.Add(RtbNote);
            Controls.Add(BtnLoad);
            Controls.Add(BtnSave);
            Font = new Font("나눔고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "파일IO 윈앱";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSave;
        private Button BtnLoad;
        private RichTextBox RtbNote;
        private Button BtnBold;
        private Button BrnRed;
        private OpenFileDialog DlgOpen;
        private SaveFileDialog DlgSave;
        private ColorDialog DlgColor;
    }
}
