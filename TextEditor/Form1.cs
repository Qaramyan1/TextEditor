using System.IO;  
namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt) | *.txt ";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("File saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("File open");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor ==  Color.FromArgb(64, 64, 64))
            {
                textBox1.BackColor = Color.FromArgb(224, 224, 224);
                textBox1.ForeColor = Color.Black;
                panel1.BackColor = Color.SeaShell;
                openfile.BackColor = Color.SeaShell;
                openfile.ForeColor = Color.Black;
                lightmode.BackColor = Color.SeaShell;
                lightmode.ForeColor = Color.Black;
                saveas.BackColor = Color.SeaShell;
                saveas.ForeColor = Color.Black;
                
            }
            
            else
            {
                textBox1.BackColor = Color.FromArgb(64, 64, 64);
                textBox1.ForeColor = Color.White;
                panel1.BackColor = Color.DarkGray;
                openfile.BackColor = Color.DarkGray;
                openfile.ForeColor = Color.Black;
                lightmode.BackColor = Color.DarkGray;
                lightmode.ForeColor = Color.Black;
                saveas.BackColor = Color.DarkGray;
                saveas.ForeColor = Color.Black;
                
            }
        }
    }
}