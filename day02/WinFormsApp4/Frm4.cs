using System.Numerics;

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
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("���� ä���ּ���.");
            }
            else
            {
                //LblResult.Text = "ó����� : ";
                //TxtResult.Text = "���� ó���� ����";

                string name = TxtName.Text.Trim();//Trim:���� ����
                DateTime birthday = DateTime.Parse(TxtAge.Text.Trim()); // Parse:�м��Ͽ� ����ȯ
                int age = (DateTime.Now.Year - birthday.Year);

                // ���׽� �б�
                string gender = RdoMale.Checked ? "��" : "��";

                //�����
                TxtResult.Text = "���� " + name + "�̰�, " + birthday + "�� �¾ " + age +"�� " + gender + "���Դϴ�.";

                //�ֽ�
                TxtResult.Text = $"���� {name}�̰�, {birthday:yyyy�� MM�� dd��}�� �¾ {age}�� {gender}���Դϴ�.";
            }
        }
    }
}
