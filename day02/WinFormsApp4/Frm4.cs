namespace WinFormsApp4
{
    public partial class Frm4 : Form
    {
        public Frm4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("���� ä���ּ���.");
            } else
            {
                LblResult.Text = "ó����� : ";
                TxtResult.Text = "���� ó���� ����";
            }
        }
    }
}
