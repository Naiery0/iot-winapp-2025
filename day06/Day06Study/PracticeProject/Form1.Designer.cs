namespace PracticeProject
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
            groupBox2 = new GroupBox();
            DgvMamber = new DataGridView();
            MemName = new DataGridViewTextBoxColumn();
            CheckAbsence = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            정보 = new GroupBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPhone = new MaskedTextBox();
            TxtBirth = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            TxtMajor = new TextBox();
            label4 = new Label();
            label2 = new Label();
            TxtPart = new TextBox();
            TxtName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            LblAbsenceCount = new Label();
            LsvAbsenceDay = new ListView();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MenuSave = new ToolStripMenuItem();
            MenuSaveName = new ToolStripMenuItem();
            MnuLoad = new ToolStripMenuItem();
            MnuCancle = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            TxtAbsence = new TextBox();
            BtnAdd = new Button();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            LblAbsenceMem = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMamber).BeginInit();
            정보.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvMamber);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 34);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(191, 371);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "인원 명단";
            // 
            // DgvMamber
            // 
            DgvMamber.AllowUserToAddRows = false;
            DgvMamber.AllowUserToDeleteRows = false;
            DgvMamber.BackgroundColor = SystemColors.ControlLightLight;
            DgvMamber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMamber.Columns.AddRange(new DataGridViewColumn[] { MemName, CheckAbsence });
            DgvMamber.Location = new Point(6, 27);
            DgvMamber.Name = "DgvMamber";
            DgvMamber.RowHeadersVisible = false;
            DgvMamber.Size = new Size(179, 339);
            DgvMamber.TabIndex = 3;
            // 
            // MemName
            // 
            MemName.HeaderText = "이름";
            MemName.Name = "MemName";
            MemName.ReadOnly = true;
            MemName.Width = 136;
            // 
            // CheckAbsence
            // 
            CheckAbsence.HeaderText = "결석";
            CheckAbsence.Name = "CheckAbsence";
            CheckAbsence.Width = 40;
            // 
            // button1
            // 
            button1.Location = new Point(226, -8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(27, 24);
            button1.TabIndex = 2;
            button1.TabStop = false;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            monthCalendar1.Location = new Point(442, 40);
            monthCalendar1.Margin = new Padding(10, 9, 10, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // 정보
            // 
            정보.Controls.Add(BtnCancel);
            정보.Controls.Add(BtnSave);
            정보.Controls.Add(TxtPhone);
            정보.Controls.Add(TxtBirth);
            정보.Controls.Add(label7);
            정보.Controls.Add(label6);
            정보.Controls.Add(TxtMajor);
            정보.Controls.Add(label4);
            정보.Controls.Add(label2);
            정보.Controls.Add(TxtPart);
            정보.Controls.Add(TxtName);
            정보.Controls.Add(label1);
            정보.Controls.Add(label3);
            정보.Controls.Add(LblAbsenceCount);
            정보.Controls.Add(LsvAbsenceDay);
            정보.Location = new Point(210, 34);
            정보.Margin = new Padding(3, 2, 3, 2);
            정보.Name = "정보";
            정보.Padding = new Padding(3, 2, 3, 2);
            정보.Size = new Size(219, 371);
            정보.TabIndex = 5;
            정보.TabStop = false;
            정보.Text = "인원 정보";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(127, 162);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(39, 23);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Visible = false;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(172, 162);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(39, 23);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Visible = false;
            // 
            // TxtPhone
            // 
            TxtPhone.Enabled = false;
            TxtPhone.Location = new Point(68, 134);
            TxtPhone.Mask = "___-____-____";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(144, 22);
            TxtPhone.TabIndex = 7;
            // 
            // TxtBirth
            // 
            TxtBirth.Enabled = false;
            TxtBirth.Location = new Point(67, 106);
            TxtBirth.Mask = "____-__-__";
            TxtBirth.Name = "TxtBirth";
            TxtBirth.Size = new Size(144, 22);
            TxtBirth.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 53);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 5;
            label7.Text = "조";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 81);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "학과";
            // 
            // TxtMajor
            // 
            TxtMajor.Enabled = false;
            TxtMajor.Location = new Point(67, 78);
            TxtMajor.Name = "TxtMajor";
            TxtMajor.Size = new Size(145, 22);
            TxtMajor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "전화번호";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 109);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "생년월일";
            // 
            // TxtPart
            // 
            TxtPart.Enabled = false;
            TxtPart.Location = new Point(66, 50);
            TxtPart.Name = "TxtPart";
            TxtPart.Size = new Size(145, 22);
            TxtPart.TabIndex = 4;
            // 
            // TxtName
            // 
            TxtName.Enabled = false;
            TxtName.Location = new Point(67, 22);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(145, 22);
            TxtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 208);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "결석날짜";
            // 
            // LblAbsenceCount
            // 
            LblAbsenceCount.AutoSize = true;
            LblAbsenceCount.Location = new Point(138, 208);
            LblAbsenceCount.Name = "LblAbsenceCount";
            LblAbsenceCount.Size = new Size(75, 15);
            LblAbsenceCount.TabIndex = 1;
            LblAbsenceCount.Text = "결석횟수 : 0";
            // 
            // LsvAbsenceDay
            // 
            LsvAbsenceDay.Location = new Point(7, 225);
            LsvAbsenceDay.Margin = new Padding(3, 2, 3, 2);
            LsvAbsenceDay.Name = "LsvAbsenceDay";
            LsvAbsenceDay.Size = new Size(205, 141);
            LsvAbsenceDay.TabIndex = 0;
            LsvAbsenceDay.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(673, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.BackColor = Color.LightGray;
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuSave, MenuSaveName, MnuLoad, MnuCancle });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(43, 20);
            MnuFile.Text = "파일";
            // 
            // MenuSave
            // 
            MenuSave.Name = "MenuSave";
            MenuSave.Size = new Size(178, 22);
            MenuSave.Text = "저장 (Ctrl+S)";
            // 
            // MenuSaveName
            // 
            MenuSaveName.Name = "MenuSaveName";
            MenuSaveName.Size = new Size(178, 22);
            MenuSaveName.Text = "다른 이름으로 저장";
            // 
            // MnuLoad
            // 
            MnuLoad.Name = "MnuLoad";
            MnuLoad.Size = new Size(178, 22);
            MnuLoad.Text = "불러오기";
            // 
            // MnuCancle
            // 
            MnuCancle.Name = "MnuCancle";
            MnuCancle.Size = new Size(178, 22);
            MnuCancle.Text = "닫기";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtAbsence);
            groupBox1.Location = new Point(442, 222);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(220, 183);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "결석사유";
            // 
            // TxtAbsence
            // 
            TxtAbsence.Enabled = false;
            TxtAbsence.Location = new Point(6, 17);
            TxtAbsence.Multiline = true;
            TxtAbsence.Name = "TxtAbsence";
            TxtAbsence.Size = new Size(208, 161);
            TxtAbsence.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(110, 31);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(39, 23);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "추가";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(153, 31);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(39, 23);
            BtnDelete.TabIndex = 8;
            BtnDelete.Text = "삭제";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(382, 30);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(39, 23);
            BtnUpdate.TabIndex = 8;
            BtnUpdate.Text = "편집";
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // LblAbsenceMem
            // 
            LblAbsenceMem.AutoSize = true;
            LblAbsenceMem.Location = new Point(582, 205);
            LblAbsenceMem.Name = "LblAbsenceMem";
            LblAbsenceMem.Size = new Size(75, 15);
            LblAbsenceMem.TabIndex = 9;
            LblAbsenceMem.Text = "결석인원 : 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(673, 418);
            Controls.Add(LblAbsenceMem);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(groupBox1);
            Controls.Add(정보);
            Controls.Add(monthCalendar1);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            Font = new Font("나눔고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "출결 관리 프로그램";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMamber).EndInit();
            정보.ResumeLayout(false);
            정보.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private MonthCalendar monthCalendar1;
        private GroupBox 정보;
        private Label LblAbsenceCount;
        private ListView LsvAbsenceDay;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MenuSave;
        private ToolStripMenuItem MenuSaveName;
        private ToolStripMenuItem MnuLoad;
        private ToolStripMenuItem MnuCancle;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox TxtPart;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label LblAbsenceMem;
        private TextBox TxtName;
        private TextBox TxtAbsence;
        private Label label2;
        private TextBox TxtMajor;
        private Label label4;
        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnUpdate;
        private MaskedTextBox TxtPhone;
        private MaskedTextBox TxtBirth;
        private DataGridView DgvMamber;
        private DataGridViewTextBoxColumn MemName;
        private DataGridViewCheckBoxColumn CheckAbsence;
        private Button BtnSave;
        private Button BtnCancel;
        private Label label3;
    }
}
