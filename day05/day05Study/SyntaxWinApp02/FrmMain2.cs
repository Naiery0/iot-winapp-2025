using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SyntaxWinApp02
{
    public partial class FrmMain2 : Form
    {
        public FrmMain2()
        {
            InitializeComponent();
        }


        int add(int x, int y)
        {
            return x + y;
        }



        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            // Delegate         // lamda
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            Action<string> sayHello = name => MessageBox.Show($"ㅎㅇ{name}", "인사", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sayHello("유고");


            Random rand = new Random();
            // LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [3, 5, 7, 2, 1, 4, 6, 8, 9, 10];

            // 짝수만 추출해서 오름차순 정렬 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    resList.Add(n);
                }
            }
            TxtLog.Text += "짝수리스트 :" + string.Join(" ", resList) + "\r\n";

            resList.Sort();//정렬
            TxtLog.Text += "정렬리스트 :" + string.Join(" ", resList) + "\r\n";

            // 기본 LINQ 방식
            numbers = [14, 20, 11, 13, 19, 16, 15, 12, 10, 17, 18];
            var resList2 = from n in numbers
                           where n % 2 == 0
                           orderby n
                           select n;
            TxtLog.Text += "링큐 정렬리스트 :" + string.Join(" ", resList2) + "\r\n";


            // LINQ Method Chaining
            numbers.Clear();
            for (int i = 0; i < 10; i++) { numbers.Add(rand.Next(20, 31)); }

            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "링큐2 정렬리스트 > " + string.Join(" ", resList3) + "\r\n";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // UI 초기화
            TxtTest.PlaceholderText = "테스트입니다";
            TxtTest.Size = new Size(200, 23);
            TxtTest.KeyPress += TxtTest_KeyPress; // Designer에서 작업하는 것과 동일
            TxtTest.Font = new Font("휴먼매직체", 12, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // == 13과 동일
            {
                MessageBox.Show("엔터를 클릭했습니다.", "키프레스",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            // 기본
            Print<int>(100);
            Print<float>(3.141592f);
            Print<string>("안녕, 유고!");
            Print<bool>(false);

            // 생략가능 - 편의성을 위해서
            Print(200);
            Print(6.141592f);
            Print("잘가, 유고!");
            Print(true);

            // 제네릭 클래스 사용
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

            Box<string> strBox = new Box<string>();
            strBox.Value = "애슐리";
            strBox.Show();
        }

        public void Print<T>(T data) { Console.WriteLine(data); }
    }

    // 제네릭 클래스
    public class Box<T> // where T : struct
    {
        public T Value { get; set; }  // 속성
        // private T value; // 멤버변수

        public void Show()
        {
            MessageBox.Show($"Box의 값 : {Value}", "Box값",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}