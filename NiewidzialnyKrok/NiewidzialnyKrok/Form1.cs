using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiewidzialnyKrok
{
    public partial class Form1 : Form
    {
        double KrokZmian;
        int KrokZegara, przelacznik = 1;
        bool WarningDialogShown;
        public Form1()
        {
            KrokZmian = 0.10;
            KrokZegara = 1000;
            WarningDialogShown = false;
            InitializeComponent();
            updatePlusPierwszy();
            updateMinusPierwszy();
            updatePlusDrugi();
            updateMinusDrugi();
        }
        private void updateLabel1()
        {
            label1.Text = "Nieprzezroczystość: " + Math.Round(100 * Opacity, 2) + "%";
        }
        private void updateLabel2()
        {
            label2.Text = "Krok zmian: " + Math.Round(100 * KrokZmian, 2) + "%";
        }
        private void updateLabel3()
        {
            label3.Text = "Krok zegara: " + KrokZegara + "ms";
        }
        private void FormAnimacja_Shown(object sender, EventArgs e)
        {
            updateLabel1();
            updateLabel2();
            updateLabel3();
            this.Zegar.Interval = KrokZegara;

        }
        private void Zegar_Tick(object sender, EventArgs e)
        {
            if (przelacznik == 1)
                Opacity = Opacity - KrokZmian;
            else if (przelacznik == 0)
                Opacity = Opacity + KrokZmian;

            updatePlusPierwszy();
            updateLabel1();
            if (Opacity == 0)
                przelacznik = 0;
            else if (Opacity == 1.0)
                przelacznik = 1;
        }
        private void updatePlusPierwszy()
        {
            if (Opacity < 1.00) PlusPierwszy.Enabled = true;
            else
            {
                MinusPierwszy.Focus();
                PlusPierwszy.Enabled = false;
            }
        }
        private void updateMinusPierwszy()
        {
            if (Opacity > 0.0) MinusPierwszy.Enabled = true;
            else
            {
                PlusPierwszy.Focus();
                MinusPierwszy.Enabled = false;
            }
        }
        private void updatePlusDrugi()
        {
            if (Math.Round(KrokZmian, 2) < 1.00) PlusDrugi.Enabled = true;
            else
            {
                MinusDrugi.Focus();
                PlusDrugi.Enabled = false;
            }
        }
        private void updateMinusDrugi()
        {
            if (Math.Round(KrokZmian, 2) > 0.01) MinusDrugi.Enabled = true;
            else
            {
                PlusDrugi.Focus();
                MinusDrugi.Enabled = false;
            }
        }
        private void updatePlusTrzeci()
        {
            if (Math.Round(KrokZmian, 2) > 0.01) MinusDrugi.Enabled = true;
            else
            {
                PlusDrugi.Focus();
                MinusDrugi.Enabled = false;
            }
        }
        private void updateMinusTrzeci()
        {
            if (Math.Round(KrokZmian, 2) > 0.01) MinusDrugi.Enabled = true;
            else
            {
                PlusDrugi.Focus();
                MinusDrugi.Enabled = false;
            }
        }
        private void updateStart()
        {
            if (Start.Text == "Start")
                Start.Text = "Stop";
            else Start.Text = "Start";
        }
        private void PlusPierwszy_Click(object sender, EventArgs e)
        {
            double NewOpacity = Opacity + KrokZmian;
            if (NewOpacity > 1.0) Opacity = 1.0;
            else Opacity = NewOpacity;
            updateMinusPierwszy();
            updatePlusPierwszy();
            updateLabel1();
        }
        private void MinusPierwszy_Click(object sender, EventArgs e)
        {
            double NewOpacity = Opacity - KrokZmian;
            if ((NewOpacity < 0.3) && (WarningDialogShown == false))
            {
                MessageBox.Show("Uwaga, całkowicie przezroczyste okno reaguje tylko na polecenia z klawiatury",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WarningDialogShown = true;
            }
            if (NewOpacity < 0.0) Opacity = 0.0;
            else Opacity = NewOpacity;
            updatePlusPierwszy();
            updateMinusPierwszy();
            updateLabel1();
        }
        private void PlusDrugi_Click(object sender, EventArgs e)
        {
            KrokZmian += 0.01;
            if (KrokZmian > 1.0) KrokZmian = 1.0;
            updateMinusDrugi();
            updatePlusDrugi();
            updateLabel2();
        }
        private void MinusDrugi_Click(object sender, EventArgs e)
        {
            KrokZmian -= 0.01;
            if (KrokZmian < 0.01) KrokZmian = 0.01;
            updatePlusDrugi();
            updateMinusDrugi();
            updateLabel2();
        }
        private void PlusTrzeci_Click(object sender, EventArgs e)
        {
            MinusTrzeci.Enabled = true;
            KrokZegara = KrokZegara + 100;
            updateMinusTrzeci();
            updatePlusTrzeci();
            updateLabel3();

        }
        private void MinusTrzeci_Click(object sender, EventArgs e)
        {
            if (KrokZegara < 200)
            {
                KrokZegara = 100;
            }
            else KrokZegara = KrokZegara - 100;
            if (KrokZegara < 200)
            {
                MinusTrzeci.Enabled = false;
            }
            updatePlusPierwszy();
            updateMinusPierwszy();
            updateLabel3();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (this.Zegar.Enabled == true)
            {

                this.Zegar.Enabled = false;
                Start.Text = "Start";
            }
            else
            {
                this.Zegar.Enabled = true;
                Start.Text = "Stop";
            }
        }
    }
}
