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
            MessageBox.Show("�޽���");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "�ƴϿ�")
            {
                MessageBox.Show("������ �� �Ծ��. ���� ��!");
            }
            else if (textBox1.Text == "��")
            {
                string PainPoint = comboBox1.SelectedItem.ToString();
                switch (PainPoint)
                {
                    // �Ӹ� �� �� �� ���� ��
                    case "�Ӹ�":
                        MessageBox.Show("�Ű��", "���������");
                        break;
                    case "��":
                        MessageBox.Show("�Ȱ�", "���������");
                        break;
                    case "��":
                    case "��":
                        MessageBox.Show("�̺����İ�", "���������");
                        break;
                    case "����":
                        MessageBox.Show("����", "���������");
                        break;
                    case "��":
                        MessageBox.Show("��ȭ��", "���������");
                        break;

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ű���������� ���͸� �Է��ϸ�
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(textBox1.Text, "�Է°�");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "��������");
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
                textBox2.Text += "\r\n"; // ������ ����
            }
        }

        int clickNum = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            // ���� �ݺ�
            while (true)
            {
                MessageBox.Show("��� >" + clickNum);
                clickNum++;

                if (clickNum == 10)
                {
                    break;
                }
            }
        }
    }
}
