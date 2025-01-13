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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextReader));
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
            label2 = new Label();
            label3 = new Label();
            genderLabel = new Label();
            langLabel = new Label();
            menuStrip.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // readOutLoudTextBox
            // 
            readOutLoudTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            readOutLoudTextBox.Location = new Point(12, 120);
            readOutLoudTextBox.Name = "readOutLoudTextBox";
            readOutLoudTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            readOutLoudTextBox.Size = new Size(914, 437);
            readOutLoudTextBox.TabIndex = 7;
            readOutLoudTextBox.Text = "Text to read";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(603, 6);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(160, 32);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear Text";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // readButton
            // 
            readButton.Location = new Point(769, 6);
            readButton.Name = "readButton";
            readButton.Size = new Size(160, 32);
            readButton.TabIndex = 10;
            readButton.Text = "Read Text";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(320, 25);
            label1.TabIndex = 6;
            label1.Text = "Paste your text below to read out loud:";
            // 
            // voiceSelectionMenu
            // 
            voiceSelectionMenu.FormattingEnabled = true;
            voiceSelectionMenu.Location = new Point(151, 39);
            voiceSelectionMenu.Name = "voiceSelectionMenu";
            voiceSelectionMenu.Size = new Size(283, 33);
            voiceSelectionMenu.TabIndex = 1;
            voiceSelectionMenu.SelectedIndexChanged += voiceSelectionMenu_SelectedIndexChanged;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new Point(12, 42);
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
            menuStrip.TabIndex = 100;
            menuStrip.TabStop = true;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { importTexttxtToolStripMenuItem1, settingsToolStripMenuItem1, exitToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(73, 29);
            fileToolStripMenuItem1.Text = "Menu";
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
            flowLayoutPanel1.Controls.Add(readButton);
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 563);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3);
            flowLayoutPanel1.Size = new Size(938, 47);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 42);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Gender: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 42);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 4;
            label3.Text = "Language: ";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(575, 42);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(0, 25);
            genderLabel.TabIndex = 3;
            // 
            // langLabel
            // 
            langLabel.AutoSize = true;
            langLabel.Location = new Point(787, 42);
            langLabel.Name = "langLabel";
            langLabel.Size = new Size(0, 25);
            langLabel.TabIndex = 5;
            // 
            // TextReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 610);
            Controls.Add(langLabel);
            Controls.Add(genderLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(readOutLoudTextBox);
            Controls.Add(menuStrip);
            Controls.Add(label0);
            Controls.Add(voiceSelectionMenu);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(800, 500);
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
        private Label label2;
        private Label label3;
        private Label genderLabel;
        private Label langLabel;
    }
}
