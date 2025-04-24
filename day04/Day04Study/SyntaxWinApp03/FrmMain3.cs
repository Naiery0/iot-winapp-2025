namespace SyntaxWinApp03
{
    public partial class FrmMain3 : Form
    {
        private string filePath = "sample.rtf"; //Rich Text Format (MS Word ����)
        public FrmMain3()
        {
            InitializeComponent();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            //string filePath = "sample.txt";
            DlgSave.FileName = string.Empty;
            DlgSave.Filter = "RTF���� (*,rtf)|*.rtf|txt���� (*.txt)|*.txt";
            DlgSave.Title = "�������� ����";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgSave.FileName;
                    string ext = Path.GetExtension(fullPath); // Ȯ���� ������

                    if (ext == ".rtf")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"���� ���� : {ex.Message}", "��������",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //try
            //{
            //    //�ϴ� txt ���� ����
            //    //File.WriteAllText(filePath, RtbNote.Text);

            //    //Rich Text Format���� ����
            //    RtbNote.SaveFile(filePath, RichTextBoxStreamType.RichText);

            //    MessageBox.Show("������ ����Ǿ����ϴ�.", "��������",
            //          MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"���� ���� : {ex.Message}", "��������",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // �о�� ����
            DlgOpen.FileName = string.Empty;
            DlgOpen.Filter = "RTF���� (*,rtf)|*.rtf|txt���� (*.txt)|*.txt";
            DlgOpen.Title = "�������� �б�";

            // ���̾�α�â ����=OK  , ���=Cancel
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgOpen.FileName;
                    string ext = Path.GetExtension(fullPath); // Ȯ���� ������

                    if (ext == ".rtf")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.PlainText);

                    //RtbNote.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�б� ���� : {ex.Message}", "�����б�",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void BrnRed_Click(object sender, EventArgs e)
        {
            //RtbNote.SelectionColor = Color.Red;
            if (RtbNote.SelectionLength > 0)
            {
                if (DlgColor.ShowDialog() == DialogResult.OK)
                {
                    RtbNote.SelectionColor = DlgColor.Color;
                }
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font currFont = RtbNote.SelectionFont;
            FontStyle newStyle;

            if (currFont.Bold)
            {
                newStyle = currFont.Style & ~FontStyle.Bold; // Bold ����
            }
            else
            {
                newStyle = currFont.Style | FontStyle.Bold;
            }
            RtbNote.SelectionFont = new Font(currFont, newStyle);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void RtbNote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
