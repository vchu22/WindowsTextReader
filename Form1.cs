using System.Speech.Synthesis;
using System.Text.RegularExpressions;

namespace WindowsTextReader
{
    public partial class TextReader : Form
    {
        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer Synth = new SpeechSynthesizer();
        public TextReader()
        {
            // Configure the audio output.
            Synth.SetOutputToDefaultAudioDevice();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var voice in Synth.GetInstalledVoices())
            {
                var info = voice.VoiceInfo;
                voiceSelectionMenu.Items.Add($"{info.Name}");
            }
            voiceSelectionMenu.SelectedIndex = 0;
            Synth.SelectVoice(voiceSelectionMenu.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            readOutLoudTextBox.Text = "";
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            Synth.SpeakAsyncCancelAll();
            // Speak the text in the textbox
            var prompt = Synth.SpeakAsync(readOutLoudTextBox.Text);
        }

        private void voiceSelectionMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
