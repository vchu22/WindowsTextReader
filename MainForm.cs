using System.Speech.Synthesis;
using System.Configuration;
using System.IO.IsolatedStorage;

namespace WindowsTextReader
{
    public partial class TextReader : Form
    {
        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer? Synth = new SpeechSynthesizer();
        List<VoiceInfo> voiceInfoList = new List<VoiceInfo>();
        public TextReader()
        {
            InitializeComponent();
        }

        // **** REUSABLE METHODS *****
        private void CheckSynth(Action? hasSynthCallback = null, Action? noSynthCallback = null)
        {
            if (Synth == null)
            {
                Synth = new SpeechSynthesizer();
                Synth.SetOutputToDefaultAudioDevice();
                ChangeVoice();
                ChangeSpeed();
                if (noSynthCallback != null) noSynthCallback();
            }
            else
            {
                if (hasSynthCallback != null) hasSynthCallback();
            }
        }
        private void ChangeVoice()
        {
            if (Synth == null)
            {
                Synth = new SpeechSynthesizer();
            }
            Synth.SelectVoice(voiceSelectionMenu.Text);
            // save the new selection to saved settings
            Properties.Settings.Default["Voice"] = voiceSelectionMenu.SelectedIndex;
            Properties.Settings.Default.Save();

            genderLabel.Text = voiceInfoList.ElementAt(voiceSelectionMenu.SelectedIndex).Gender.ToString();
            langLabel.Text = voiceInfoList.ElementAt(voiceSelectionMenu.SelectedIndex).Culture.ToString();
        }
        private void ChangeSpeed()
        {
            Synth.Rate = speedTrackBar.Value * 2;
        }
        // **** UI METHODS *****
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configure the audio output.
            Synth?.SetOutputToDefaultAudioDevice();
            foreach (var voice in Synth.GetInstalledVoices())
            {
                var info = voice.VoiceInfo;
                voiceSelectionMenu.Items.Add($"{info.Name}");
                voiceInfoList.Add(info);
            }
            // load selection from saved settings
            voiceSelectionMenu.SelectedIndex = (int)Properties.Settings.Default["Voice"];
            ChangeVoice();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            readOutLoudTextBox.Text = "";
        }

        private void voiceSelectionMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSynth(ChangeVoice);
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            CheckSynth(ChangeSpeed);
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            if (Synth != null)
            {
                Synth.SpeakAsyncCancelAll();
                Synth.Dispose();
                Synth = null;
            };
        }
        private void readButton_Click(object sender, EventArgs e)
        {
            CheckSynth(() =>
            {
                Synth.SpeakAsyncCancelAll();
            }, () => { });
            // Speak the text in the textbox
            Synth?.SpeakAsync(readOutLoudTextBox.Text);
        }

        private void importTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "Select File";
            ofDialog.InitialDirectory = Application.StartupPath;
            ofDialog.Filter = "Text File (*.txt)|*.txt";
            ofDialog.FilterIndex = 1;
            ofDialog.ShowDialog();

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                // Fill textarea with txt file content
            }
        }
    }
}
