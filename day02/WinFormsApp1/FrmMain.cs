namespace WinFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // asd
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�޽���", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // ������
            sbyte sbtval = 127; // signed byte : -128 ~ 127
            byte btVal = 255; // 0 ~ 255 (1 byte)
            short stVal = 32767; // -32768 ~ 32767
            ushort ustVal = 65535; // unsigned short : 0~65535 (2 byte)
            int intVal = 2147483647; // -21�� ~ 21��
            uint uintval = 4294967295; // unsigned int : 0~42��(4 byte)
            long lngVal = 90000; // -92 ~ 92��
            ulong ulngVal = 18000; // unsigned long : 180��(8 byte)

            // �Ǽ���
            float fVal = 3.141592f; // 4byte �Ҽ���
            double dVal = 3.141592; // 8byte �Ҽ���
            decimal dcVal = 3.141592m; // 16byte �Ҽ���

            char ch01 = 'A';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World!"; // \0 : end of line

            bool bool01 = true;

            // Nullable - �⺻Ÿ���� NULL�Ҵ�Ұ�
            int? num = null;

            // ��� - ���� ���� ����Ұ�
            const int num2 = 1;

            // ����Ÿ�� // �������ϸ� �ش� Ÿ������ ������, ���� ������ ����� �� ����
            var int05 = false; 
            
            

            MessageBox.Show(str01, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
