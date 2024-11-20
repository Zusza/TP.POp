using System.IO;
using System.Web;
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
            string imie = textBox1.Text;
            bool plecK = radioButton1.Checked;
            bool plecM = radioButton2.Checked;
            string opis = textBox2.Text;

            StreamWriter sw = new StreamWriter("C:\\Users\\3Egr2\\Desktop\\Dane.txt");
            sw.WriteLine(imie);
            if (plecK == true)
            {
                sw.WriteLine("Kobieta");
            }
            else
            {
                sw.WriteLine("Mê¿czyzna");
            }
            sw.WriteLine(opis);
            sw.Close();
        }
    }
}
