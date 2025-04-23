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
                MessageBox.Show("값을 채워주세요.");
            }
            else
            {
                //LblResult.Text = "처리결과 : ";
                //TxtResult.Text = "뭔가 처리될 거임";

                string name = TxtName.Text.Trim();//Trim:여백 제거
                DateTime birthday = DateTime.Parse(TxtAge.Text.Trim()); // Parse:분석하여 형변환
                int age = (DateTime.Now.Year - birthday.Year);

                // 삼항식 분기
                string gender = RdoMale.Checked ? "남" : "여";

                //구방식
                TxtResult.Text = "저는 " + name + "이고, " + birthday + "에 태어난 " + age +"살 " + gender + "자입니다.";

                //최신
                TxtResult.Text = $"저는 {name}이고, {birthday:yyyy년 MM월 dd일}에 태어난 {age}살 {gender}자입니다.";
            }
        }
    }
}
