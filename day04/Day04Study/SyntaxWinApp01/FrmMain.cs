using System.Resources;
using System.Runtime.Versioning;

namespace SyntaxWinApp01
{
    /// <summary>
    /// ����ó���н�
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            try
            {
                person.Name = TxtName.Text.Trim();
                // int -> 4 bytes ����, decimal -> 16 bytes �Ǽ�

                //����Ȳ
                person.Age = Convert.ToInt32(NudAge.Value); // �� ����� �� ����
                person.Gender = char.Parse(TxtGender.Text.Trim());
                person.Phone = TxtPhone.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("������ M/F�� �Է��ϼ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                return;
            }

            try
            {
                float rval = 0f;
                int x = 10, y = 5;
                rval = x / y;

                MessageBox.Show(rval.ToString());
            }
            catch (DivideByZeroException ex) // ArithmeticException(�θ�)���� �ص� ��
            {
                MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("�� �� ���� ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                return;
            }
            finally
            {

            }

            // ���� Person��ü ������ ó��
            person.BirthYear = DateTime.Now.Year - person.Age;
            char korGender = person.Gender == 'M' ? '��' : '��';
            string result = $"���� Person�� {person.Name},\r\n" +
                            $"����, {person.Age}��({person.BirthYear}���)\r\n" +
                            $"����, {korGender}\r\n" + 
                            $"����ȣ, {person.Phone}";
            TxtResult.Text = result;

            if (person.Age > 0 && person.Age < 20)
            {
                if (person.Gender == 'M') PicResult.Image = Resources.boy;
                else PicResult.Image = Resources.girl;
            }
            else if (person.Age >= 20 && person.Age < 45)
            {
                if (person.Gender == 'M') PicResult.Image = Resources.man;
                else PicResult.Image = Resources.woman;
            }
            else
            {
                if (person.Gender == 'M') PicResult.Image = Resources.old_man;
                else PicResult.Image = Resources.old_woman;
            }

        }
    }
}
