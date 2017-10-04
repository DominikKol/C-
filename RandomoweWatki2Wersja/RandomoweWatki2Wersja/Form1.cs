using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RandomoweWatki2Wersja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 2;
            trackBar2.Value = 2;
            trackBar3.Value = 2;
            trackBar4.Value = 2;
            trackBar5.Value = 2;
            trackBar6.Value = 2;
            label1.Text = Priorytety(trackBar1.Value);
            label2.Text = Priorytety(trackBar2.Value);
            label3.Text = Priorytety(trackBar3.Value);
            label4.Text = Priorytety(trackBar4.Value);
            label5.Text = Priorytety(trackBar5.Value);
            label6.Text = Priorytety(trackBar6.Value);

        }
        private Thread th, th1, th2, th3, th4, th5;
        Random rdm;

        private void Niebieski_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Priority = WatkiPriorytet(trackBar1.Value);
            th.Name = "A";
            th.Start();
            fibonacci(22);
        }

        public void thread()
        {
            if (Thread.CurrentThread == th)
            {
                for (int i = 0; i < 200; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                    Thread.Sleep(100);
                }
            }
            MessageBox.Show("wykonano czerwony");
        }

        public void thread1()
        {
            if (Thread.CurrentThread == th1)
            {
                for (int i = 0; i < 200; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                    Thread.Sleep(100);
                }
            }
            MessageBox.Show("wykonano niebieski");
        }

        public void thread2()
        {
            if (Thread.CurrentThread == th2)
            {
                for (int i = 0; i < 200; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Green, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                    Thread.Sleep(100);
                }
            }
            MessageBox.Show("wykonano zielony");
        }
        public void thread3()
        {
            if (Thread.CurrentThread == th3)
            {
                for (int i = 0; i < 200; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Yellow, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                    Thread.Sleep(100);
                }
            }
            MessageBox.Show("wykonano żółty");
        }
        public void thread4()
        {
            if (Thread.CurrentThread == th4)
            {
                for (int i = 0; i < 200; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Violet, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                    Thread.Sleep(100);
                }
            }
            MessageBox.Show("wykonano żółty");
        }
        public void thread5()
        {
            if (Thread.CurrentThread == th5)
            {
                for (int i = 0; i < 200; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                    Thread.Sleep(100);
                }
            }
            MessageBox.Show("wykonano żółty");
        }

        private int fibonacci(int x)
        {
            if (x < 2)
                return 1;
            else
                return (fibonacci(x - 1) + fibonacci(x - 2));
        }
        private void Czerwony_Click(object sender, EventArgs e)
        {
            th1 = new Thread(thread1);
            th1.Start();
            th1.Name = "B";
            th1.Priority = WatkiPriorytet(trackBar2.Value);
            fibonacci(22);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }

        private void Zielony_Click(object sender, EventArgs e)
        {

            th2 = new Thread(thread2);
            th2.Start();
            th2.Name = "C";							    // nadanie nazwy
            th2.Priority = WatkiPriorytet(trackBar3.Value);
            fibonacci(22);
        }

        private void Zolty_Click(object sender, EventArgs e)
        {

            th3 = new Thread(thread3);
            th3.Name = "D";
            th3.Priority = WatkiPriorytet(trackBar4.Value);
            th3.Start();
            fibonacci(22);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Niebieski_Click(sender, e);
            Zolty_Click(sender, e);
            Czerwony_Click(sender, e);
            Zielony_Click(sender, e);
            fioletowy_Click(sender, e);
            czarny_Click(sender, e);
        }
        private ThreadPriority WatkiPriorytet(int val)
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
        private string Priorytety(int val)
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

        private void czarny_Click(object sender, EventArgs e)
        {

            th5 = new Thread(thread5);
            th5.Name = "F";
            th5.Priority = WatkiPriorytet(trackBar6.Value);
            th5.Start();
            fibonacci(22);
        }

        private void fioletowy_Click(object sender, EventArgs e)
        {

            th4 = new Thread(thread4);
            th4.Name = "E";
            th4.Priority = WatkiPriorytet(trackBar5.Value);
            th4.Start();
            fibonacci(22);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = Priorytety(trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = Priorytety(trackBar2.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = Priorytety(trackBar3.Value);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label4.Text = Priorytety(trackBar4.Value);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label5.Text = Priorytety(trackBar5.Value);
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label6.Text = Priorytety(trackBar6.Value);
        }
    }
}
