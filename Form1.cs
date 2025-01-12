namespace WindowsTextReader
{
    public partial class TextReader : Form
    {
        public TextReader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            readOutLoudTextBox.Text = "";
        }
    }
}
