namespace SyntaxWinApp02
{
    public partial class FrmMain2 : Form
    {
        public FrmMain2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fruits = ["���", "�ٳ���", "����", "����", "��纣��"];
            CboArray.Items.AddRange(fruits);
            //CboArray.SelectedIndex = 0;

            List<string> lFruits = ["���", "����ƾ", "���ø���", "�ڸ�"];
            /* List<string> lFruits = new List<string>();
             * lFruits.Add("���");
             * lFruits.Add("����ƾ");
             * lFruits.Add("���ø���");
             * lFruits.Add("�ڸ�");
             */
            CboList.DataSource = lFruits;

            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                {"KR", "���ѹα�"},
                {"US", "�̱�"},
                {"JP", "�Ϻ�"},
                {"CN", "�߱�"},
                {"IN", "�ε�"},
                {"PH", "�ʸ���"},
            };
            CboDictionary.DataSource = new BindingSource(dCountry, null);
            CboDictionary.DisplayMember = "Value"; // ����ڿ��� ���̴� �̸�
            CboDictionary.ValueMember = "Key"; // ���������� ���õǴ� ��

            string result = "";
            foreach(var item in dCountry)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {

        }
        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CboArray.SelectedItem.ToString(); // ���� object? ����
            MessageBox.Show($"������ ������ {selected}�Դϴ�.", "�����ϴ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CboList.SelectedItem.ToString();
            MessageBox.Show(selected, "���õȰ���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
