namespace SlumpaElev
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When you click button1 this happens
        /// </summary>
        /// <param name="sender">Windows forms</param>
        /// <param name="e"></param>        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            int randomnr = random.Next(checkedListBox1.CheckedItems.Count);
            label1.Text = checkedListBox1.CheckedItems[randomnr].ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
    }
}
