using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RandomoweFigury
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random(); // wywołanie obiektu klasy random przy uruchomieniu załadowaniu formy
        }
        private Thread wtNiebieski;  // utworzenie nowego wątku prywatnego
        private Thread wtCzerwony;
        private Thread wtZielony;
        private Thread wtOrange;
        private Thread wtFioletowy;
        private Thread wtCzarny;
        Random random; // własnosc przypadkowa
        /*
         * zmienne dla grafik
         */
        int a = 1000; // zmienne dla elips
        int b = 1000;
        float c = 20.0F;
        float d = 20.0F;
        float startWycinek = 0.0F; // zmienne dla wycinków kołowych
        float sweepk = 300.0F;
        float startWycinek2 = 0.0F;
        float sweepk2 = 240.0F;
        /*
         */
        private void Niebieski_Click(object sender, EventArgs e)
        {
            Niebieski.Enabled = false;// przycisk niebieski niewidoczny , niebieski stop widoczny
            Niebieski2.Enabled = true;
            wtNiebieski = new Thread(watekNiebieski); // wywołanie wątku i utworzenie odwołania do metody inicjującej 
            wtNiebieski.Name = "Niebieski"; // po prostu nazwa wątku
            wtNiebieski.Start(); // zainicjowanie wyjątku
            Ciagfibonacziego(22);// wywołanie ciagu fibonacziego dla spowolnienia watku (22) tyle razy bd liczyc trzeba uwazac z wyzszymi wartosciami bo moze zawiesic procesor i wtedy 100%
        }
        private void NiebieskiSTOP_Click(object sender, EventArgs e)
        {
            Niebieski2.Enabled = false;// przycisk niebieski niewidoczny 
            wtNiebieski.Abort();// zatrzymanie wątku i wywołanie wyjątku w bloku catch metody watekNiebieki
        }
        public void watekNiebieski() // tutaj metoda tworząca wątek
        {
            try // blok try catch przechwytuje wystąpienie wyjątku po zatrzymaniu wątku i wyświetla komunikat znajdujacy sie w bloku catch
            {
                if (Thread.CurrentThread == wtNiebieski)// pobiera aktualnie uruchomiony wątek
                {
                    for (int i = 0; i < (int)numericUpDown1.Value; i++)// pobiera wartosc z kontrolki numericupdown ile razy ma zostac wyswietlona grafika
                    {
                        //kod poniżej tworzy grafike w tym przypadku kwadrat ostatnie wartosci to jego wielkosc a wystapienie random tworzy obiekt w różnych miejscach
                        this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(random.Next(0, this.Width), random.Next(0, this.Height), 20, 20));
                        Thread.Sleep(100); //usypia wątek na 100ms
                    }
                    MessageBox.Show("wykonano niebieski");// po wykonaniu instrukcji if wyświetla komunikat o zakonczeniu pracy jeżeli nie został zatrzymany ale wiesz zawsze można go wznowic i doprowadzic do konca
                }
            }
            catch (ThreadAbortException)
            {// opisałem wyżej
                MessageBox.Show("Żeby go wznowic wciśnij przycisk Niebieski", "Wystąpiło zatrzymanie wątku niebieskiego.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //Niebieski.Enabled = true; // ustawia przycisk niebieski na widoczny
            }
        }
        private void Czerwony_Click(object sender, EventArgs e)
        {
            Czerwony.Enabled = false;
            Czerwony2.Enabled = true;
            wtCzerwony = new Thread(watekCzerwony);
            wtCzerwony.Start();
            wtCzerwony.Name = "Czerwony";
            Ciagfibonacziego(22);
        }
        private void CzerwonySTOP_Click(object sender, EventArgs e)
        {
            Czerwony2.Enabled = false;
            wtCzerwony.Abort();
        }
        public void watekCzerwony()
        {
            try
            {
                if (Thread.CurrentThread == wtCzerwony)
                {
                    for (int i = 0; i < (int)numericUpDown2.Value; i++)
                    {
                        this.CreateGraphics().FillRectangle(Brushes.Red, new Rectangle(random.Next(0, this.Width), random.Next(0, this.Height), 35, 20));
                        Thread.Sleep(100);
                    }
                }
                MessageBox.Show("wykonano czerwony");
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Żeby go wznowic wciśnij przycisk Czerwony", "Wystąpiło zatrzymanie wątku czerwonego.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //Czerwony.Enabled = true;
            }
        }
        private void Zielony_Click(object sender, EventArgs e)
        {
            Zielony.Enabled = false;
            Zielony2.Enabled = true;
            wtZielony = new Thread(watekZielony);
            wtZielony.Start();
            wtZielony.Name = "Zielony";
            Ciagfibonacziego(22);
        }
        private void Zielony2_Click(object sender, EventArgs e)
        {
            Zielony2.Enabled = false;
            wtZielony.Abort();
        }
        public void watekZielony()
        {
            try
            {
                if (Thread.CurrentThread == wtZielony)
                {
                    for (int i = 0; i < (int)numericUpDown3.Value; i++)
                    {
                        this.CreateGraphics().DrawPie(new Pen(Brushes.Green, 4), new Rectangle(random.Next(0, this.Width), random.Next(0, this.Height), 50, 50), startWycinek, sweepk);
                        Thread.Sleep(100);
                    }
                }
                MessageBox.Show("wykonano zielony");
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Żeby go wznowic wciśnij przycisk Zielony", "Wystąpiło zatrzymanie wątku zielonego.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //Zielony.Enabled = true;
            }
        }
        private void Orange_Click(object sender, EventArgs e)
        {
            Orange.Enabled = false;
            Orange2.Enabled = true;
            wtOrange = new Thread(watekOrange);
            wtOrange.Name = "Orange";
            wtOrange.Start();
            Ciagfibonacziego(22);
        }
        private void Oragne2_Click(object sender, EventArgs e)
        {
            Orange2.Enabled = false;
            wtOrange.Abort();
        }
        public void watekOrange()
        {
            try
            {
                if (Thread.CurrentThread == wtOrange)
                {
                    for (int i = 0; i < (int)numericUpDown4.Value; i++)
                    {
                        this.CreateGraphics().FillPie(Brushes.Orange, new Rectangle(random.Next(0, this.Width), random.Next(0, this.Height), 40, 40), startWycinek2, sweepk2);
                        Thread.Sleep(100);
                    }
                }
                MessageBox.Show("wykonano żółty");
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Żeby go wznowic wciśnij przycisk Orange", "Wystąpiło zatrzymanie wątku orange.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // Orange.Enabled = true;
            }
        }
        private void Fioletowy_Click(object sender, EventArgs e)
        {
            Fioletowy.Enabled = false;
            Fioletowy2.Enabled = true;
            wtFioletowy = new Thread(watekFioletowy);
            wtFioletowy.Name = "Fioletowy";
            wtFioletowy.Start();
            Ciagfibonacziego(22);
        }
        private void Fioletowy2_Click(object sender, EventArgs e)
        {
            Fioletowy2.Enabled = false;
            wtFioletowy.Abort();
        }
        public void watekFioletowy() // rysuje kontur elipsy
        {
            try
            {
                if (Thread.CurrentThread == wtFioletowy)
                {
                    for (int i = 0; i < (int)numericUpDown5.Value; i++)
                    {
                        this.CreateGraphics().DrawEllipse(new Pen(Brushes.Violet, 4), random.Next(0, this.a), random.Next(0, this.b), c, d);
                        Thread.Sleep(100);
                    }
                }
                MessageBox.Show("wykonano fioletowy");
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Żeby go wznowic wciśnij przycisk Fioletowy", "Wystąpiło zatrzymanie wątku fioletowego.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //Fioletowy.Enabled = true;
            }

        }
        private void czarny_Click(object sender, EventArgs e)
        {
            Czarny.Enabled = false;
            Czarny2.Enabled = true;
            wtCzarny = new Thread(watekCzarny);
            wtCzarny.Name = "Czarny";
            wtCzarny.Start();
            Ciagfibonacziego(22);
        }
        private void Czarny2_Click(object sender, EventArgs e)
        {
            Czarny2.Enabled = false;
            wtCzarny.Abort();
        }
        public void watekCzarny()// rysuje wypełnioną elipse
        {
            try
            {
                if (Thread.CurrentThread == wtCzarny)
                {
                    for (int i = 0; i < (int)numericUpDown6.Value; i++)
                    {
                        this.CreateGraphics().FillEllipse(Brushes.Black, new Rectangle(random.Next(0, this.Width), random.Next(0, this.Height), 30, 30));
                        Thread.Sleep(100);
                    }
                }
                MessageBox.Show("wykonano czarny");
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Żeby go wznowic wciśnij przycisk Czarny", "Wystąpiło zatrzymanie wątku czarnego.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //Czarny.Enabled = true;
            }

        }
        private int Ciagfibonacziego(int x)// dla spowolnienia procesora i w skutku wyświetlania grafik
        {
            if (x < 2) 
                return 1;
            else
                return (Ciagfibonacziego(x - 1) + Ciagfibonacziego(x - 2));
        }
        private void ButtonStartALL_Click(object sender, EventArgs e)
        {
            STARTall.Enabled = false; // opisane na początku co sie dzieje przy enabled
            STOPall.Enabled = true;
            Niebieski_Click(sender, e); // tutaj wywołujemy zdarzenie click wszyskich przycisków na raz 
            Orange_Click(sender, e);
            Czerwony_Click(sender, e);
            Zielony_Click(sender, e);
            Fioletowy_Click(sender, e);
            czarny_Click(sender, e);
        }
        private void STOPall_Click(object sender, EventArgs e)
        {
            STARTall.Enabled = true;
            wtNiebieski.Abort(); // zatrzymujemy wszystkie wątki 
            wtCzerwony.Abort();
            wtZielony.Abort();
            wtOrange.Abort();
            wtFioletowy.Abort();
            wtCzarny.Abort();
            Czarny.Enabled = true;
            Niebieski.Enabled = true;
            Czerwony.Enabled = true;
            Zielony.Enabled = true;
            Fioletowy.Enabled = true;
            Orange.Enabled = true;
        }

        private void Uruchomponownie_Click(object sender, EventArgs e)
        {
            Application.Restart(); // uruchamia aplikacje ponownie 
        }
    }
}
