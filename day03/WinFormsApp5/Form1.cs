namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // �⺻ ������
            Person hugo = new Person();
            hugo.Name = TxtName.Text.Trim();
            hugo.Age = int.Parse(TxtAge.Text.Trim());
            hugo.Gender = char.Parse(TxtGender.Text.Trim());
            hugo.Phone = TxtPhone.Text.Trim();

            // �Ű����� ������ 
            Person ashely = new Person ( "�ֽ���", 42, 'F', "010-2345-2345" );

            TxtResult.Text += hugo.ToString();
            hugo.GetUp();
            hugo.GoToSchool();

            // static�� ���� ��ü�� �������� ����
            Person.GetNumber();
        }
    }
}
