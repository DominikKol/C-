using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DniTygodnia
{
    public partial class FormDatownik : Form
    {
        public FormDatownik()
        {
            InitializeComponent();
        }

        private void buttonKolorPierwszoplanowy_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonKolorPierwszoplanowy.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) ForeColor = colorDialog1.Color;
        }

        private void buttonKolorTła_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonKolorTła.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) BackColor = colorDialog1.Color;
        }

        private void buttonCzcionka_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = labelWczoraj.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                labelWczoraj.Font = labelDzisiaj.Font = labelJutro.Font = fontDialog1.Font;
                labelWczoraj.ForeColor = labelDzisiaj.ForeColor = labelJutro.ForeColor = fontDialog1.Color;
            }
        }

        public string NazwaDnia(int zmienna)
        {
            switch (zmienna)
            {
                case 1:
                    return "poniedziałek";

                case 2:
                    return "wtorek";

                case 3:
                    return "środa";

                case 4:
                    return "czwartek";

                case 5:
                    return "piątek";

                case 6:
                    return "sobota";

                case 0:
                    return "niedziela";

                default:
                    return "";

            }
        }

        private void updateLabelWczoraj()
        {
            DateTime Dzisiaj = DateTime.Now;
            int NumerDnia = (int)Dzisiaj.DayOfWeek;
            labelWczoraj.Text = "wczoraj: " + NazwaDnia(NumerDnia - 1);
        }

        private void updateLabelDzisiaj()
        {
            DateTime Dzisiaj = DateTime.Now;
            int NumerDnia = (int)Dzisiaj.DayOfWeek;
            labelDzisiaj.Text = "dzisiaj: " + NazwaDnia(NumerDnia);
        }

        private void updateLabelJutro()
        {
            DateTime Dzisiaj = DateTime.Now;
            int NumerDnia = (int)Dzisiaj.DayOfWeek;
            labelJutro.Text = "jutro: " + NazwaDnia(NumerDnia + 1);
        }

        private void buttonBieżący_Click(object sender, EventArgs e)
        {
            buttonPoprzedni.Enabled = true;
            buttonNastępny.Enabled = true;
            updateLabelWczoraj();
            updateLabelDzisiaj();
            updateLabelJutro();
        }

        private void buttonPoprzedni_Click(object sender, EventArgs e)
        {
        }

        private void buttonNastępny_Click(object sender, EventArgs e)
        {
        }

        private void Zegar_Tick(object sender, EventArgs e)
        {
            Text = System.DateTime.Now.ToString("yyyy/MM/dd" + " " + "HH:mm:ss");
        }
    }
}
