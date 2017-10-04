using System.Threading;
using System.Windows.Forms;

namespace WyscigiWatkow
{
    public partial class Form1 : Form
    {
        private Thread Watek1, Watek2, Watek3, Watek4;
        //private System.ComponentModel.Container components = null;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 2;
            trackBar2.Value = 2;
            trackBar3.Value = 2;
            trackBar4.Value = 2;
            label5.Text = nazwyPriorytetow(trackBar1.Value);
            label6.Text = nazwyPriorytetow(trackBar2.Value);
            label7.Text = nazwyPriorytetow(trackBar3.Value);
            label8.Text = nazwyPriorytetow(trackBar4.Value);
            this.Text = "RajdWątkowy"; // zmiena nazwe okienka
        }
        /* metoda fibonacci nie ma żadnego zadania poza zajęciem 
 * naszego procesora na ułamek sekundy tylko i wyłącznie po to,
 * by auta nie przelatywały przez ekran zbyt szybko */
        private int fibonacci(int x)
        {
            if (x < 2)
                return 1;
            else
                return (fibonacci(x - 1) + fibonacci(x - 2));
        }

        /* metoda Poruszaj() jest wykonywana zarówno przez wątek Watek1, jak i
         * Watek2. W zależności od tego, który watek właśnie ją wykonuje, metoda ta
         * wywołuje metodę poruszającą autami (PictureBox) Z racji tego, iż argumentem delegata ThreadStart nie może
         * być metoda wywyływana z argumentami, Poruszaj() ich nie ma. Za to
         * wywołuje ona metodę X(PictureBox x, int i) już z argumentami.  */
        public void Poruszaj()
        {
            if (Thread.CurrentThread == Watek1) // Thread.CurrentThread zwraca nam
            {							   // referencje do aktualnie wykonywanego
                for (int a = 0; a < 750; a++)	   // wątku
                {
                    Thread.Sleep(1);
                    /* Metodą Thread.Sleep(1) usypiam na 1 ms wątek
                     * w celu sumulowania pracy. Gdy usuniemy te metody
                     * z kodu, po wcisnieciu przycisku START bedziemy mogli
                     * zaobserwowac, iż w niektorych przypadkach jeden z watkow
                     * wykonywyje swa CALĄ pracę, podczas gdy inne czekają.
                     * Poniekąd jest to zgodne z ogólnym algorytmem przydzielania
                     * czasu procesora na poszczególne wątki  */
                    X(pictureBox1, a);
                    /* metoda P służy do przesuwania danego PictureBox`a 
                     * (auta) na nowe miejsce*/
                    //PictureBox1.Left = a;
                }
            }
            if (Thread.CurrentThread == Watek2)
            {
                for (int a = 0; a < 750; a++)
                {
                    Thread.Sleep(1);
                    X(pictureBox2, a);
                    //pictureBox2.Left = a;
                }
            }
            if (Thread.CurrentThread == Watek3)
            {
                for (int a = 0; a < 750; a++)
                {
                    Thread.Sleep(1);
                    X(pictureBox3, a);
                    //pictureBox3.Left = a;
                }
            }
            if (Thread.CurrentThread == Watek4)
            {
                for (int a = 0; a < 750; a++)
                {
                    Thread.Sleep(1);
                    X(pictureBox4, a);
                    //pictureBox4.Left = a;
                }
            }
        }

        /* metoda X() służy do przesuwania auta(PictureBox`a) p w prawą
         * stronę. metoda fibonacci celowo spowalnia przesuwanie aut po to,
         * byśmy mogli obserować ich ruch(symulacja intensywnej pracy systemu)  */
        public void X(PictureBox x, int i)
        {
            x.Left = i;
            fibonacci(22);
            fibonacci(22);
            fibonacci(22);// u mnie fibonacci(22) optymalnie spowalniał...
        }
        public void button1_Click(object sender, System.EventArgs e)
        {
            Watek1 = new Thread(new ThreadStart(Poruszaj)); // inicjalizujemy wątki
            Watek2 = new Thread(new ThreadStart(Poruszaj));
            Watek3 = new Thread(new ThreadStart(Poruszaj));
            Watek4 = new Thread(new ThreadStart(Poruszaj));
            pictureBox1.Left = 0;								// auta na miejsca...
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            Watek1.Priority = priorytetWatkow(trackBar1.Value);   // ustawienie priorytetu
            Watek2.Priority = priorytetWatkow(trackBar2.Value);
            Watek3.Priority = priorytetWatkow(trackBar3.Value);
            Watek4.Priority = priorytetWatkow(trackBar4.Value);
            Watek1.Name = "C";							    // nadanie nazwy
            Watek2.Name = "Z";
            Watek3.Name = "N";
            Watek4.Name = "K";
            Watek1.Start();								    // ...i START !!
            Watek2.Start();
            Watek3.Start();
            Watek4.Start();
        }


        /* metody trackBar_Scroll  wykonywane są 
         * (jak sama nazwa wskazuje) po przesunięciu odpowiedniego trackBar`a.
         * Służą do cofnięcia aut na miejsce i aktualizacji
         * wyświetlanego priorytetu odpowiedniego wątka  */
        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            AutaNaPozycji();
            label5.Text = nazwyPriorytetow(trackBar1.Value);
        }
        private void trackBar2_Scroll(object sender, System.EventArgs e)
        {
            AutaNaPozycji();
            label6.Text = nazwyPriorytetow(trackBar2.Value);
        }
        private void trackBar3_Scroll(object sender, System.EventArgs e)
        {
            AutaNaPozycji();
            label7.Text = nazwyPriorytetow(trackBar3.Value);
        }
        private void trackBar4_Scroll(object sender, System.EventArgs e)
        {
            AutaNaPozycji();
            label8.Text = nazwyPriorytetow(trackBar4.Value);
        }


        /* Metoda AutaNaPozycji jest chyba oczywista... */
        private void AutaNaPozycji()
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
        }


        /* metoda priorytet(int val) służy zamianie wartości int val pobieranej
         * z własności trackBar`a na priorytet wątka. Dlatego właśnie
         * metoda zwraca wartość ThreadPriority. Jak widać liczbie 0 
         * przyporządkowałem najniższy priorytet, natomiast liczbie 4 -
         * najwyższy.  */
        private ThreadPriority priorytetWatkow(int val)
        {
            switch (val)
            {
                case 0:
                    return ThreadPriority.Lowest;
                case 1:
                    return ThreadPriority.BelowNormal;
                case 2:
                    return ThreadPriority.Normal;
                case 3:
                    return ThreadPriority.AboveNormal;
                case 4:
                    return ThreadPriority.Highest;
                default:
                    return ThreadPriority.Normal;
            }
        }

        /* Metoda nazwapriorytet(int val) zamiena numer priorytetu przekazywany
         * przez wartość do metody i zamienia na odpowiedni string będący
         * polską nazwą priorytetu.
         * Ta metoda nie jest potrzebna do właściwej pracy z wątkami... */
        private string nazwyPriorytetow(int val)
        {
            switch (val)
            {
                case 0:
                    return "Najnizszy";
                case 1:
                    return "Niski";
                case 2:
                    return "Normalny";
                case 3:
                    return "Wysoki";
                case 4:
                    return "Najwyższy";
                default:
                    return "Normalny";
            }
        }   
    }
}
