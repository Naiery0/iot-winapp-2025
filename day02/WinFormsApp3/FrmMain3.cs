namespace WinFormsApp3
{
    public partial class FrmMain3 : Form
    {
        public FrmMain3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "아니오")
            {
                MessageBox.Show("병원을 왜 왔어요. 집에 가!");
            }
            else if (textBox1.Text == "네")
            {
                string PainPoint = comboBox1.SelectedItem.ToString();
                switch (PainPoint)
                {
                    // 머리 눈 코 목 가슴 배
                    case "머리":
                        MessageBox.Show("신경과", "진료과선택");
                        break;
                    case "눈":
                        MessageBox.Show("안과", "진료과선택");
                        break;
                    case "목":
                    case "코":
                        MessageBox.Show("이비인후과", "진료과선택");
                        break;
                    case "가슴":
                        MessageBox.Show("내과", "진료과선택");
                        break;
                    case "배":
                        MessageBox.Show("소화과", "진료과선택");
                        break;

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 키프레스에서 엔터를 입력하면
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(textBox1.Text, "입력값");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "통증부위");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            for (int x = 2; x < 10; x++)
            {

                for (int y = 1; y < 10; ++y)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    textBox2.Text += result + " ";
                }
                textBox2.Text += "\r\n"; // 윈도우 개행
            }
        }

        int clickNum = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            // 무한 반복
            while (true)
            {
                MessageBox.Show("계속 >" + clickNum);
                clickNum++;

                if (clickNum == 10)
                {
                    break;
                }
            }
        }
    }
}
