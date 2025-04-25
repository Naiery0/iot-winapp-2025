namespace WinControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // OS 전체 폰트 가져오기
            var Fonts = FontFamily.Families;
            //CboFonts.Items.AddRange(Fonts);
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }
            LblState.Text = "상태 : 폰트읽기 완료";

            toolTip1.SetToolTip(BtnModal, "모달창 연습 버튼");
            toolTip1.SetToolTip(TxtYear, "캘린더 선택 년도 표시 텍스트 박스");
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }


        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItelic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return; // 폰트를 선택 안 한 경우

            FontStyle style = FontStyle.Regular;

            if (ChkBold.Checked) style |= FontStyle.Bold; // FontStyle.Regular | FontStyle.Bold
            if (ChkItalic.Checked) style |= FontStyle.Italic;


            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 12, style);

        }

        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "모달창";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent; // 부모창의 중앙
            frmModal.ShowDialog(); // 모달 띄우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModaless = new Form();
            frmModaless.Text = "모달리스창";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.Red;
            // 모달리스창을 메인창 정중앙에 띄우려면 계산필요
            frmModaless.StartPosition = FormStartPosition.CenterParent; // 부모창의 중앙
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2,
                                             this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this); // 모달 띄우기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // 메시지박스 -> 모달창
            MessageBox.Show(TxtResult.Text, "텍스트박스문장",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            TrvDummy.Nodes.Add(rand.Next().ToString());

        }

        private void BtnNode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("노드를 선택하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand(); // 트리확장 Expand, 트리축소 Collapse
            TreeToList();
        }
        private void TreeToList()
        {

            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }
        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() });
            item.ImageIndex = 0;
            LsvDummy.Items.Add(item);
            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode);
            }
        }


        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.dmp;*.jpg;*.png)|*.dmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void CalSche_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtYear.Text = (CalSchedule.SelectionStart.Year.ToString());
            TxtMonth.Text = (CalSchedule.SelectionStart.Year.ToString());
            TxtDay.Text = (CalSchedule.SelectionStart.Year.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= Form1_FormClosing;
                Application.Exit();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;//종료를 안 시킴
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.naver.com/");
        }

        private void TrvDummy_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
