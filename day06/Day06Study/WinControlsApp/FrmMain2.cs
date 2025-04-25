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
            // OS ��ü ��Ʈ ��������
            var Fonts = FontFamily.Families;
            //CboFonts.Items.AddRange(Fonts);
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }
            LblState.Text = "���� : ��Ʈ�б� �Ϸ�";

            toolTip1.SetToolTip(BtnModal, "���â ���� ��ư");
            toolTip1.SetToolTip(TxtYear, "Ķ���� ���� �⵵ ǥ�� �ؽ�Ʈ �ڽ�");
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
            if (CboFonts.SelectedIndex < 0) return; // ��Ʈ�� ���� �� �� ���

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
            frmModal.Text = "���â";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent; // �θ�â�� �߾�
            frmModal.ShowDialog(); // ��� ����
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModaless = new Form();
            frmModaless.Text = "��޸���â";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.Red;
            // ��޸���â�� ����â ���߾ӿ� ������ ����ʿ�
            frmModaless.StartPosition = FormStartPosition.CenterParent; // �θ�â�� �߾�
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2,
                                             this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this); // ��� ����
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // �޽����ڽ� -> ���â
            MessageBox.Show(TxtResult.Text, "�ؽ�Ʈ�ڽ�����",
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
                MessageBox.Show("��带 �����ϼ���", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand(); // Ʈ��Ȯ�� Expand, Ʈ����� Collapse
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
            DlgOpenImage.Title = "�̹��� ����";
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
            //MessageBox.Show(DtpBirth.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= Form1_FormClosing;
                Application.Exit();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;//���Ḧ �� ��Ŵ
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
