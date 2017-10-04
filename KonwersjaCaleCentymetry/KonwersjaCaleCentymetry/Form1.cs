using System;
using System.Windows.Forms;

namespace KonwersjaCaleCentymetry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x;
            double.TryParse(textBox1.Text, out x);
            Przelicz(ref x);
            textBox1.Text = x.ToString();

        }
        void Przelicz(ref double x)
        {
            if (label1.Text == "cale")
            {
                x *= 2.54;
                label1.Text = "cm";

            }
            else if (label1.Text == "cm")
            {
                x /= 2.54;
                label1.Text = "cale";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
