using System.Speech.Synthesis;
using System.Text.RegularExpressions;

namespace WindowsTextReader
{
    public partial class TextReader : Form
    {
        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer Synth = new SpeechSynthesizer();
        List<VoiceInfo> voiceInfoList = new List<VoiceInfo>();
        public TextReader()
        {
            // Configure the audio output.
            Synth.SetOutputToDefaultAudioDevice();
            InitializeComponent();
        }

        private void ChangeVoice()
        {
            Synth.SelectVoice(voiceSelectionMenu.Text);
            genderLabel.Text = voiceInfoList.ElementAt(voiceSelectionMenu.SelectedIndex).Gender.ToString();
            langLabel.Text = voiceInfoList.ElementAt(voiceSelectionMenu.SelectedIndex).Culture.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var voice in Synth.GetInstalledVoices())
            {
                var info = voice.VoiceInfo;
                voiceSelectionMenu.Items.Add($"{info.Name}");
                voiceInfoList.Add(info);
            }
            voiceSelectionMenu.SelectedIndex = 0;
            ChangeVoice();
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
            ChangeVoice();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Synth.Pause();
            Synth.SpeakAsyncCancelAll();
            Synth.Resume();
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            Synth.Rate = speedTrackBar.Value * 2;
        }
    }
}
