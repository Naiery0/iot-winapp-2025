using System.Resources;
using System.Runtime.Versioning;

namespace SyntaxWinApp01
{
    /// <summary>
    /// 예외처리학습
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
                // int -> 4 bytes 정수, decimal -> 16 bytes 실수

                //형변황
                person.Age = Convert.ToInt32(NudAge.Value); // 이 방식을 더 권장
                person.Gender = char.Parse(TxtGender.Text.Trim());
                person.Phone = TxtPhone.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("성별은 M/F만 입력하세요", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (DivideByZeroException ex) // ArithmeticException(부모)으로 해도 됨
            {
                MessageBox.Show(ex.Message, "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("알 수 없는 예외", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                return;
            }
            finally
            {

            }

            // 들어온 Person객체 값으로 처리
            person.BirthYear = DateTime.Now.Year - person.Age;
            char korGender = person.Gender == 'M' ? '남' : '여';
            string result = $"현재 Person은 {person.Name},\r\n" +
                            $"나이, {person.Age}세({person.BirthYear}년생)\r\n" +
                            $"성별, {korGender}\r\n" + 
                            $"폰번호, {person.Phone}";
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
