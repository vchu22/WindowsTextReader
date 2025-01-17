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
            importTextToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            stopButton = new Button();
            label2 = new Label();
            label3 = new Label();
            genderLabel = new Label();
            langLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            speedTrackBar = new TrackBar();
            label6 = new Label();
            menuStrip.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).BeginInit();
            SuspendLayout();
            // 
            // readOutLoudTextBox
            // 
            readOutLoudTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            readOutLoudTextBox.Location = new Point(12, 120);
            readOutLoudTextBox.Name = "readOutLoudTextBox";
            readOutLoudTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            readOutLoudTextBox.Size = new Size(954, 494);
            readOutLoudTextBox.TabIndex = 7;
            readOutLoudTextBox.Text = "Text to read";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(76, 9);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(160, 32);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear Text";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // readButton
            // 
            readButton.Location = new Point(360, 9);
            readButton.Name = "readButton";
            readButton.Size = new Size(160, 32);
            readButton.TabIndex = 16;
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
            menuStrip.Size = new Size(978, 33);
            menuStrip.TabIndex = 100;
            menuStrip.TabStop = true;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { importTextToolStripMenuItem, settingsToolStripMenuItem1, exitToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(73, 29);
            fileToolStripMenuItem1.Text = "Menu";
            // 
            // importTextToolStripMenuItem
            // 
            importTextToolStripMenuItem.Name = "importTextToolStripMenuItem";
            importTextToolStripMenuItem.Size = new Size(270, 34);
            importTextToolStripMenuItem.Text = "Import text (*.txt)";
            importTextToolStripMenuItem.Click += importTextToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem1
            // 
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.Size = new Size(270, 34);
            settingsToolStripMenuItem1.Text = "Settings";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(270, 34);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(readButton);
            flowLayoutPanel1.Controls.Add(stopButton);
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(446, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3, 6, 3, 3);
            flowLayoutPanel1.Size = new Size(529, 52);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(242, 9);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(112, 34);
            stopButton.TabIndex = 15;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.296524F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.703476F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 617);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(978, 58);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(speedTrackBar);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(3);
            flowLayoutPanel2.Size = new Size(437, 52);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 6);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(72, 31);
            label4.TabIndex = 9;
            label4.Text = "Speed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 6);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Padding = new Padding(3);
            label5.Size = new Size(45, 31);
            label5.TabIndex = 10;
            label5.Text = "-10";
            // 
            // speedTrackBar
            // 
            speedTrackBar.LargeChange = 2;
            speedTrackBar.Location = new Point(135, 6);
            speedTrackBar.Maximum = 5;
            speedTrackBar.Minimum = -5;
            speedTrackBar.Name = "speedTrackBar";
            speedTrackBar.Size = new Size(213, 69);
            speedTrackBar.TabIndex = 11;
            speedTrackBar.Scroll += speedTrackBar_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 6);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Padding = new Padding(3);
            label6.Size = new Size(38, 31);
            label6.TabIndex = 12;
            label6.Text = "10";
            // 
            // TextReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 677);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(langLabel);
            Controls.Add(genderLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(readOutLoudTextBox);
            Controls.Add(menuStrip);
            Controls.Add(label0);
            Controls.Add(voiceSelectionMenu);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1000, 500);
            Name = "TextReader";
            Text = "Text Reader";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).EndInit();
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
        private ToolStripMenuItem importTextToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label genderLabel;
        private Label langLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private Label label5;
        private TrackBar speedTrackBar;
        private Label label6;
        private Button stopButton;
    }
}
