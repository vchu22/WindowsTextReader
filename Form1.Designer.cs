namespace WindowsTextReader
{
    partial class TextReader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            readOutLoudTextBox = new RichTextBox();
            clearButton = new Button();
            readButton = new Button();
            label1 = new Label();
            voiceSelectionMenu = new ComboBox();
            label0 = new Label();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            importTexttxtToolStripMenuItem1 = new ToolStripMenuItem();
            settingsToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // readOutLoudTextBox
            // 
            readOutLoudTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            readOutLoudTextBox.Location = new Point(12, 111);
            readOutLoudTextBox.Name = "readOutLoudTextBox";
            readOutLoudTextBox.Size = new Size(914, 430);
            readOutLoudTextBox.TabIndex = 3;
            readOutLoudTextBox.Text = "Text to read";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(3, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear Text";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // readButton
            // 
            readButton.Location = new Point(121, 3);
            readButton.Name = "readButton";
            readButton.Size = new Size(180, 34);
            readButton.TabIndex = 5;
            readButton.Text = "Read the text";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(309, 25);
            label1.TabIndex = 2;
            label1.Text = "Paste the text to read out loud below:";
            // 
            // voiceSelectionMenu
            // 
            voiceSelectionMenu.FormattingEnabled = true;
            voiceSelectionMenu.Location = new Point(151, 33);
            voiceSelectionMenu.Name = "voiceSelectionMenu";
            voiceSelectionMenu.Size = new Size(283, 33);
            voiceSelectionMenu.TabIndex = 1;
            voiceSelectionMenu.SelectedIndexChanged += voiceSelectionMenu_SelectedIndexChanged;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new Point(12, 36);
            label0.Name = "label0";
            label0.Size = new Size(118, 25);
            label0.TabIndex = 0;
            label0.Text = "Select a voice";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(938, 33);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { importTexttxtToolStripMenuItem1, settingsToolStripMenuItem1, exitToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(54, 29);
            fileToolStripMenuItem1.Text = "File";
            // 
            // importTexttxtToolStripMenuItem1
            // 
            importTexttxtToolStripMenuItem1.Name = "importTexttxtToolStripMenuItem1";
            importTexttxtToolStripMenuItem1.Size = new Size(250, 34);
            importTexttxtToolStripMenuItem1.Text = "Import text (*.txt)";
            // 
            // settingsToolStripMenuItem1
            // 
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.Size = new Size(250, 34);
            settingsToolStripMenuItem1.Text = "Settings";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(250, 34);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.Controls.Add(readButton);
            flowLayoutPanel1.Location = new Point(0, 547);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(938, 182);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // TextReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 610);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(readOutLoudTextBox);
            Controls.Add(menuStrip);
            Controls.Add(label0);
            Controls.Add(voiceSelectionMenu);
            Controls.Add(label1);
            MainMenuStrip = menuStrip;
            Name = "TextReader";
            Text = "Text Reader";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox readOutLoudTextBox;
        private Button readButton;
        private Button clearButton;
        private Label label1;
        private ComboBox voiceSelectionMenu;
        private Label label0;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem importTexttxtToolStripMenuItem1;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
