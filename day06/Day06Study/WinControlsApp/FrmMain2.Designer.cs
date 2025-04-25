namespace WinControlsApp
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
            groupBox1 = new GroupBox();
            CboFonts = new ComboBox();
            TxtResult = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnOpenImage = new Button();
            PicImage = new PictureBox();
            groupBox3 = new GroupBox();
            BtnCheck = new Button();
            linkLabel1 = new LinkLabel();
            TxtYear = new TextBox();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            DtpBirth = new DateTimePicker();
            CalSchedule = new MonthCalendar();
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            트랙바 = new GroupBox();
            TrbProcess = new TrackBar();
            PrgProcess = new ProgressBar();
            groupBox4 = new GroupBox();
            BtnModaless = new Button();
            BtnMsgBox = new Button();
            BtnModal = new Button();
            groupBox5 = new GroupBox();
            BtnNode = new Button();
            BtnRoot = new Button();
            LsvDummy = new ListView();
            imageList1 = new ImageList(components);
            TrvDummy = new TreeView();
            DlgOpenImage = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewFile = new ToolStripMenuItem();
            MnuExit = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox3.SuspendLayout();
            statusStrip1.SuspendLayout();
            트랙바.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 99);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(48, 26);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(138, 23);
            CboFonts.TabIndex = 4;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(6, 71);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(308, 23);
            TxtResult.TabIndex = 3;
            TxtResult.Text = "Sample Text";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("맑은 고딕", 9F, FontStyle.Italic);
            ChkItalic.Location = new Point(253, 28);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(62, 19);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이텔릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItelic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(198, 28);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 19);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "볼드";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnOpenImage);
            groupBox2.Controls.Add(PicImage);
            groupBox2.Location = new Point(338, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 508);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "픽처박스";
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(224, 479);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(90, 23);
            BtnOpenImage.TabIndex = 5;
            BtnOpenImage.Text = "이미지열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.ControlLight;
            PicImage.Location = new Point(6, 22);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(308, 455);
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnCheck);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(TxtYear);
            groupBox3.Controls.Add(TxtDay);
            groupBox3.Controls.Add(TxtMonth);
            groupBox3.Controls.Add(DtpBirth);
            groupBox3.Controls.Add(CalSchedule);
            groupBox3.Location = new Point(664, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(354, 508);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타 컨트롤";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(244, 193);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 23);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 232);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(244, 26);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(100, 23);
            TxtYear.TabIndex = 2;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(244, 84);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(100, 23);
            TxtDay.TabIndex = 2;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(244, 55);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(100, 23);
            TxtMonth.TabIndex = 2;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(12, 193);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(184, 23);
            DtpBirth.TabIndex = 1;
            DtpBirth.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // CalSchedule
            // 
            CalSchedule.Location = new Point(12, 26);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSche_DateChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 616);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1030, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(90, 17);
            LblState.Text = "상태 : 일반상태";
            // 
            // 트랙바
            // 
            트랙바.Controls.Add(TrbProcess);
            트랙바.Controls.Add(PrgProcess);
            트랙바.Location = new Point(12, 145);
            트랙바.Name = "트랙바";
            트랙바.Size = new Size(320, 100);
            트랙바.TabIndex = 2;
            트랙바.TabStop = false;
            트랙바.Text = "트랙바";
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(6, 22);
            TrbProcess.Maximum = 100;
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(309, 45);
            TrbProcess.TabIndex = 1;
            TrbProcess.TickFrequency = 10;
            TrbProcess.Scroll += TrbProcess_Scroll;
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(6, 71);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(308, 23);
            PrgProcess.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnModaless);
            groupBox4.Controls.Add(BtnMsgBox);
            groupBox4.Controls.Add(BtnModal);
            groupBox4.Location = new Point(12, 251);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(320, 100);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(112, 33);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(96, 52);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(214, 33);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(96, 52);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(10, 33);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(96, 52);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnNode);
            groupBox5.Controls.Add(BtnRoot);
            groupBox5.Controls.Add(LsvDummy);
            groupBox5.Controls.Add(TrvDummy);
            groupBox5.Location = new Point(12, 357);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(320, 180);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "트리뷰, 리스트뷰";
            // 
            // BtnNode
            // 
            BtnNode.Location = new Point(235, 151);
            BtnNode.Name = "BtnNode";
            BtnNode.Size = new Size(75, 23);
            BtnNode.TabIndex = 2;
            BtnNode.Text = "노드추가";
            BtnNode.UseVisualStyleBackColor = true;
            BtnNode.Click += BtnNode_Click;
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(154, 151);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(75, 23);
            BtnRoot.TabIndex = 2;
            BtnRoot.Text = "루트추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(166, 22);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(144, 127);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(12, 22);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(148, 127);
            TrvDummy.TabIndex = 0;
            TrvDummy.AfterSelect += TrvDummy_AfterSelect;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewFile, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            MnuNewFile.Name = "MnuNewFile";
            MnuNewFile.Size = new Size(119, 22);
            MnuNewFile.Text = "새 글(&N)";
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 638);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(트랙바);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            트랙바.ResumeLayout(false);
            트랙바.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox CboFonts;
        private TextBox TxtResult;
        private CheckBox ChkItalic;
        private CheckBox ChkBold;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LblState;
        private GroupBox 트랙바;
        private TrackBar TrbProcess;
        private ProgressBar PrgProcess;
        private GroupBox groupBox4;
        private Button BtnModaless;
        private Button BtnMsgBox;
        private Button BtnModal;
        private GroupBox groupBox5;
        private Button BtnRoot;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private Button BtnNode;
        private ImageList imageList1;
        private Button BtnOpenImage;
        private PictureBox PicImage;
        private OpenFileDialog DlgOpenImage;
        private DateTimePicker DtpBirth;
        private MonthCalendar CalSchedule;
        private LinkLabel linkLabel1;
        private TextBox TxtYear;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private Button BtnCheck;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuNewFile;
        private ToolStripMenuItem MnuExit;
        private ToolTip toolTip1;
    }
}
