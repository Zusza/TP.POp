using System.IO;
namespace _14._11._24r
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\3Egr2\\Desktop\\Dane.txt");
            sw.WriteLine(textBox1);
            sw.WriteLine(textBox2);
            sw.Close();
        }
    }
}
