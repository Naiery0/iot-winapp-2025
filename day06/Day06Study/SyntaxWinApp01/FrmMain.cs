using System.ComponentModel; // ��׶����Ŀ �̺�Ʈ�ƱԸ�Ʈ ���ӽ����̽�

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // ��׶����Ŀ �ʱ�ȭ 
            BgwProcess.WorkerReportsProgress = true; //�����Ȳ ����Ʈ �Ұ�����

            BgwProcess.DoWork += BgwProcess_DoWork; // ��׶��� ���� �̺�Ʈ
            BgwProcess.ProgressChanged += BgwProcess_ProgressChanged; // ��׶��� ������� ���� �̺�Ʈ UI
            BgwProcess.RunWorkerCompleted += BgwProcess_RunWorkerCompleted; // ��׶��� ����Ϸ� �̺�Ʈ

            BtnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            LblState.Text = "������� : ����";
            BtnStart.Text = "���� ��";
            BtnStart.Enabled = false;

            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;
            PrgProcess.Value = 0;

            TxtLog.Clear();

            BgwProcess.RunWorkerAsync(); // ��׶��� �۾� ����
        }

        // ��׶��� ���� �۾�
        private void BgwProcess_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;

            for (int i = 0; i<MaxVal; i++)
            {
                total += 1 % 3;
                
                int progress = (int)((i * 100) / MaxVal) + 1;
                // ������� ProgressChanged�� �ѱ��
                BgwProcess.ReportProgress(progress, i);

                Thread.Sleep(50); // ���ſ� �۾� �䳻
            }
        }

        // ������� UI ������Ʈ
        private void BgwProcess_ProgressChanged(object? sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage; // DoWork. ReprotProgress(1,2) �� 1������ �Ѿ�� ��
            int currVal = (int)e.UserState; // ReportProgress 2������ �Ѿ�� ��

            PrgProcess.Value = progress;

            TxtLog.AppendText(currVal.ToString() + "\r\n");
            TxtLog.SelectionStart = TxtLog.Text.Length;
            TxtLog.ScrollToCaret();

            LblState.Text = $"������� : {progress}%";
        }

        // ��׶��� �۾��Ϸ� ��
        private void BgwProcess_RunWorkerCompleted(object? sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LblState.Text = "������� : ����";
            BtnStart.Enabled = true;
            BtnStart.Text = "����";
        }
    }
}
