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
                MessageBox.Show("값을 채워주세요.");
            } else
            {
                LblResult.Text = "처리결과 : ";
                TxtResult.Text = "뭔가 처리될 거임";
            }
        }
    }
}
