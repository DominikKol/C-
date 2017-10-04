using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double wynik, liczba1, liczba2;
        /*
         * public double liczba1;
         * public double liczb2;
         * public double działanie;
         */
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            liczToolStripMenuItem.Enabled = false;
            wyczyśćWynikiToolStripMenuItem.Enabled = false;
        }
        /*public double licz()
        {
            if (działanie == '+')
                return a + b;
            if (działanie == '-')
                return a - b;
            if (działanie == '*')
                return a * b;
            if (działanie == '/')
                return a / b;
            {
                long s = 1;
                for (int i = 1; i <= a; ++i)
                    s *= i;
                return (double)s;
            }
            else
                return 0;
        }
        */
        private void Button4BlokadaPlusStart(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                button4.Enabled = true;
                liczToolStripMenuItem.Enabled = true;
                liczba1 = Convert.ToDouble(textBox1.Text);
                liczba2 = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                button4.Enabled = false;
                liczToolStripMenuItem.Enabled = false;
            }
        }
        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            liczba1 = Convert.ToDouble(textBox1.Text);
            LiczBlokadaPlusStart();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            liczba2 = Convert.ToDouble(textBox2.Text);
            LiczBlokadaPlusStart();
        }*/ // Stara metoda 
        private void oProgramieToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mój czadowy kalkulator v.2.0\n(C) Dominik Koliński", "O programie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void wyczyśćWynikiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }
        private void wyjścieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b') && (e.KeyChar != ',') && (e.KeyChar != '.')) e.Handled = true;
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1) e.Handled = true;
            if (e.KeyChar == '.') e.KeyChar = ',';
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b') && (e.KeyChar != ',') && (e.KeyChar != '.')) e.Handled = true;
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1) e.Handled = true;
            if (e.KeyChar == '.') e.KeyChar = ',';
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) //private void richTextBox1_Validated(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
        private void richTexBox1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length != 0)
            {
                wyczyśćWynikiToolStripMenuItem.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                wyczyśćWynikiToolStripMenuItem.Enabled = false;
                button5.Enabled = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dodawanieToolStripMenuItem.Checked = true;
            odejmowanieToolStripMenuItem.Checked = false;
            mnożenieToolStripMenuItem.Checked = false;
            dzielenieToolStripMenuItem.Checked = false;
            radioButton1.Checked = true;
            wynik = (liczba1 + liczba2);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            odejmowanieToolStripMenuItem.Checked = true;
            dodawanieToolStripMenuItem.Checked = false;
            mnożenieToolStripMenuItem.Checked = false;
            dzielenieToolStripMenuItem.Checked = false;
            radioButton2.Checked = true;
            wynik = (liczba1 - liczba2);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            odejmowanieToolStripMenuItem.Checked = false;
            dodawanieToolStripMenuItem.Checked = false;
            mnożenieToolStripMenuItem.Checked = true;
            dzielenieToolStripMenuItem.Checked = false;
            radioButton3.Checked = true;
            wynik = (liczba1 * liczba2);
        }
        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            odejmowanieToolStripMenuItem.Checked = false;
            dodawanieToolStripMenuItem.Checked = false;
            mnożenieToolStripMenuItem.Checked = false;
            dzielenieToolStripMenuItem.Checked = true;
            radioButton4.Checked = true;
            wynik = (liczba1 / liczba2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.SelectedText;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = richTextBox1.SelectedText;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked) && (liczba2 == 0))
                MessageBox.Show("Próba dzielenia przez zero", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (radioButton1.Checked)
                    radioButton1.Focus();
                if (radioButton2.Checked)
                    radioButton2.Focus();
                if (radioButton3.Checked)
                    radioButton3.Focus();
                if (radioButton4.Checked)
                    radioButton4.Focus();
                richTextBox2.AppendText(Convert.ToString(wynik) + Environment.NewLine);
                richTextBox2.Focus();
                richTextBox1.AppendText(Convert.ToString(liczba1) + Environment.NewLine + Convert.ToString(liczba2) + Environment.NewLine);
                richTextBox1.Focus();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }
    }
}
