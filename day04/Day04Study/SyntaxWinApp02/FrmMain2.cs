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
            string[] fruits = ["사과", "바나나", "딸기", "망고", "블루베리"];
            CboArray.Items.AddRange(fruits);
            //CboArray.SelectedIndex = 0;

            List<string> lFruits = ["용과", "망고스틴", "애플망고", "자몽"];
            /* List<string> lFruits = new List<string>();
             * lFruits.Add("용과");
             * lFruits.Add("망고스틴");
             * lFruits.Add("애플망고");
             * lFruits.Add("자몽");
             */
            CboList.DataSource = lFruits;

            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                {"KR", "대한민국"},
                {"US", "미국"},
                {"JP", "일본"},
                {"CN", "중국"},
                {"IN", "인도"},
                {"PH", "필리핀"},
            };
            CboDictionary.DataSource = new BindingSource(dCountry, null);
            CboDictionary.DisplayMember = "Value"; // 사용자에게 보이는 이름
            CboDictionary.ValueMember = "Key"; // 내부적으로 선택되는 값

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
            string selected = CboArray.SelectedItem.ToString(); // 원래 object? 형임
            MessageBox.Show($"선택한 과일은 {selected}입니다.", "좋아하는 과일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CboList.SelectedItem.ToString();
            MessageBox.Show(selected, "선택된과일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
