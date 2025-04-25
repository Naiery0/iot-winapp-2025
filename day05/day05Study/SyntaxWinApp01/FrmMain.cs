using System.CodeDom;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // delegate (대리자)
        delegate void MyDelegate(string msg);

        // 이벤트 핸들러 대리자
        delegate void MyEventHandler(object sender, EventArgs e);
        // 이벤트
        public event EventHandler somthingHappened;

        // 대리자에서 호출할 메서드 - 대리자와 파라미터 일치
        void SayHello(string msg)
        {
            MessageBox.Show($"안녕, {msg}", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SayGoodBy(string msg)
        {
            MessageBox.Show($"내일 봐~, {msg}", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
            TxtLog.Text += ("1. 폼 생성자\r\n");
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
           TxtLog.Text += ("2. 폼 로드\r\n");
        }
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            TxtLog.Text += ("3. 폼 액티베이트\r\n");
        }
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            TxtLog.Text += ("4. 폼 숀\r\n");
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TxtLog.Text += ("5. 폼 클로징\r\n");
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            TxtLog.Text += ("6. 폼 클로즈드\r\n");
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 직접 호출
            // SayHello("Hugo");
            // SayGoodBy

            // 대리자 호출 (윈앱 개발 핵심)
            MyDelegate del = SayHello; // 대리자에 호출할 메서드 묶음

            del += SayGoodBy; // 추가
            del -= SayHello; // 삭제

            del("Ashely");

            // 반환값 없는 대리자 - Action
            Action<string> act = SayHello;
            act("Chris");

            // 반환값이 있는 대리자 - func
            Func<int, int, int> add = (a, d) => a + d;
            int result = add(7, 8);
            Console.Write(result);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
