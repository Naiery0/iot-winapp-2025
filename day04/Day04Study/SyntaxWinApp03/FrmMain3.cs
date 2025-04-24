namespace SyntaxWinApp03
{
    public partial class FrmMain3 : Form
    {
        private string filePath = "sample.rtf"; //Rich Text Format (MS Word 유사)
        public FrmMain3()
        {
            InitializeComponent();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            //string filePath = "sample.txt";
            DlgSave.FileName = string.Empty;
            DlgSave.Filter = "RTF파일 (*,rtf)|*.rtf|txt파일 (*.txt)|*.txt";
            DlgSave.Title = "문서파일 저장";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgSave.FileName;
                    string ext = Path.GetExtension(fullPath); // 확장자 가져옴

                    if (ext == ".rtf")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("파일이 저장되었습니다.", "파일저장",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"저장 실패 : {ex.Message}", "파일저장",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //try
            //{
            //    //일단 txt 파일 저장
            //    //File.WriteAllText(filePath, RtbNote.Text);

            //    //Rich Text Format으로 저장
            //    RtbNote.SaveFile(filePath, RichTextBoxStreamType.RichText);

            //    MessageBox.Show("파일이 저장되었습니다.", "파일저장",
            //          MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"저장 실패 : {ex.Message}", "파일저장",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // 읽어올 파일
            DlgOpen.FileName = string.Empty;
            DlgOpen.Filter = "RTF파일 (*,rtf)|*.rtf|txt파일 (*.txt)|*.txt";
            DlgOpen.Title = "문서파일 읽기";

            // 다이얼로그창 열기=OK  , 취소=Cancel
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgOpen.FileName;
                    string ext = Path.GetExtension(fullPath); // 확장자 가져옴

                    if (ext == ".rtf")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.PlainText);

                    //RtbNote.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"읽기 실패 : {ex.Message}", "파일읽기",
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
                newStyle = currFont.Style & ~FontStyle.Bold; // Bold 제거
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
