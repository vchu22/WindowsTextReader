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
            tableLayoutPanel1 = new TableLayoutPanel();
            readButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            clearButton = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // readOutLoudTextBox
            // 
            readOutLoudTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            readOutLoudTextBox.Location = new Point(3, 3);
            readOutLoudTextBox.Name = "readOutLoudTextBox";
            readOutLoudTextBox.Size = new Size(794, 368);
            readOutLoudTextBox.TabIndex = 0;
            readOutLoudTextBox.Text = "Text to read";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(readOutLoudTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 468);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // readButton
            // 
            readButton.Location = new Point(121, 3);
            readButton.Name = "readButton";
            readButton.Size = new Size(180, 34);
            readButton.TabIndex = 1;
            readButton.Text = "Read the text";
            readButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.Controls.Add(readButton);
            flowLayoutPanel1.Location = new Point(3, 377);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 88);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(3, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear Text";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(309, 25);
            label1.TabIndex = 2;
            label1.Text = "Paste the text to read out loud below:";
            // 
            // TextReader
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "TextReader";
            Text = "Text Reader";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox readOutLoudTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button readButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button clearButton;
        private Label label1;
    }
}
