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
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // 정수형
            sbyte sbtval = 127; // signed byte : -128 ~ 127
            byte btVal = 255; // 0 ~ 255 (1 byte)
            short stVal = 32767; // -32768 ~ 32767
            ushort ustVal = 65535; // unsigned short : 0~65535 (2 byte)
            int intVal = 2147483647; // -21억 ~ 21억
            uint uintval = 4294967295; // unsigned int : 0~42억(4 byte)
            long lngVal = 90000; // -92 ~ 92경
            ulong ulngVal = 18000; // unsigned long : 180경(8 byte)

            // 실수형
            float fVal = 3.141592f; // 4byte 소수점
            double dVal = 3.141592; // 8byte 소수점
            decimal dcVal = 3.141592m; // 16byte 소수점

            char ch01 = 'A';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World!"; // \0 : end of line

            bool bool01 = true;

            // Nullable - 기본타입은 NULL할당불가
            int? num = null;

            // 상수 - 선언 이후 변경불가
            const int num2 = 1;

            // 동적타입 // 컴파일하며 해당 타입으로 형결정, 전역 변수로 사용할 수 없음
            var int05 = false; 
            
            

            MessageBox.Show(str01, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
