namespace pdf_birleştir3
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 0;
            button1.Text = "Klasör Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 48);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 1;
            button2.Text = "Birleştirilmiş Dosya";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(660, 415);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 2;
            button3.Text = "Dosyaları Birleştir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Kaynak Dosya yolunuz";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(647, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Hedef Dosya Yolunuz";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 76);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 333);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "PDF Birleştir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
    }
}