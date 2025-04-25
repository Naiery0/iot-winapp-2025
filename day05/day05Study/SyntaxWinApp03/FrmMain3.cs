using System.Threading.Tasks;

namespace SyntaxWinApp03
{
    public partial class FrmMain3 : Form
    {
        public FrmMain3()
        {
            InitializeComponent();
        }

        private void FrmMain3_Load(object sender, EventArgs e)
        {
        }

        // async - 비동기 동작
        // await ...> async
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "현재상태 : 진행";

            BtnStart.Text = "진행중";
            BtnStart.Enabled = false;

            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            // await 비동기 대기
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;
                    int progress = (int)((i * 100) / MaxVal) + 1;
                    //Console.WriteLine(progress.ToString());

                    //Task.Run 내 UI처리 로직은
                    this.Invoke(new Action(() =>

                    {
                        TxtLog.Text += $"{i.ToString()}\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();
                        PrgProcess.Value = progress;
                    }));

                    Thread.Sleep(50);
                }

            });

            LblCurrState.Text = "현재상태 : 중지";
            BtnStart.Text = "시작";
            BtnStart.Enabled = true;
        }
    }
}
