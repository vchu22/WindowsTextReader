using System.Speech.Synthesis;

namespace WindowsTextReader
{
    public partial class TextReader : Form
    {
        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public TextReader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configure the audio output.
            this.synth.SetOutputToDefaultAudioDevice();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            readOutLoudTextBox.Text = "";
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            // Speak the text in the textbox
            var prompt = synth.SpeakAsync(readOutLoudTextBox.Text);
        }
    }
}
