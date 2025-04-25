namespace PracticeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EnableFunc(true);
        }

        private void EnableFunc(bool tf)
        {
            TxtName.Enabled = tf;
            TxtBirth.Enabled = tf;
            TxtMajor.Enabled = tf;
            TxtPart.Enabled = tf;
            TxtPhone.Enabled = tf;

            BtnCancel.Visible = tf;
            BtnSave.Visible = tf;
        }
    }
}
