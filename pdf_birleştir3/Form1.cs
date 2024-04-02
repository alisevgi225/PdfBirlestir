namespace pdf_birleştir3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.richTextBox1.AllowDrop = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
                var dialog1 = dialog.SelectedPath;
                string rootPath = textBox1.Text;

                var files = from file in
                            Directory.EnumerateFiles(rootPath)
                            select file;

                var fileString = $"Dosyalarınızın Listesi {Environment.NewLine}";
                int num = 0;
                richTextBox1.Text = fileString;
                foreach (var file in files)
                {

                    richTextBox1.Text += $"{file} {Environment.NewLine} {Environment.NewLine}";
                    num++;

                }
                richTextBox1.AppendText($"Toplam Dosya Sayısı = {num}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog di = new FolderBrowserDialog();
            if (di.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = di.SelectedPath;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo($"{textBox1.Text}");

            var pdfList = new List<byte[]> { };

            foreach (var file in d.GetFiles("*.pdf"))
            {
                pdfList.Add(File.ReadAllBytes(file.FullName));
            }


            File.WriteAllBytes($"{textBox2.Text}" + "\\birlestirilmis.pdf", brl.Combine(pdfList));

            MessageBox.Show("PDF Dosayalarınız Birleştirildi");
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            richTextBox1.Text += $"  {Environment.NewLine} {e.Data.GetData(DataFormats.FileDrop, false)}  ";
        }
        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            
            e.Effect = DragDropEffects.All;
        }




    }
}