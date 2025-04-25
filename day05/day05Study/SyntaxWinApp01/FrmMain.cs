using System.CodeDom;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // delegate (�븮��)
        delegate void MyDelegate(string msg);

        // �̺�Ʈ �ڵ鷯 �븮��
        delegate void MyEventHandler(object sender, EventArgs e);
        // �̺�Ʈ
        public event EventHandler somthingHappened;

        // �븮�ڿ��� ȣ���� �޼��� - �븮�ڿ� �Ķ���� ��ġ
        void SayHello(string msg)
        {
            MessageBox.Show($"�ȳ�, {msg}", "�޽���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SayGoodBy(string msg)
        {
            MessageBox.Show($"���� ��~, {msg}", "�޽���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
            TxtLog.Text += ("1. �� ������\r\n");
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
           TxtLog.Text += ("2. �� �ε�\r\n");
        }
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            TxtLog.Text += ("3. �� ��Ƽ����Ʈ\r\n");
        }
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            TxtLog.Text += ("4. �� ��\r\n");
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TxtLog.Text += ("5. �� Ŭ��¡\r\n");
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            TxtLog.Text += ("6. �� Ŭ�����\r\n");
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // ���� ȣ��
            // SayHello("Hugo");
            // SayGoodBy

            // �븮�� ȣ�� (���� ���� �ٽ�)
            MyDelegate del = SayHello; // �븮�ڿ� ȣ���� �޼��� ����

            del += SayGoodBy; // �߰�
            del -= SayHello; // ����

            del("Ashely");

            // ��ȯ�� ���� �븮�� - Action
            Action<string> act = SayHello;
            act("Chris");

            // ��ȯ���� �ִ� �븮�� - func
            Func<int, int, int> add = (a, d) => a + d;
            int result = add(7, 8);
            Console.Write(result);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
