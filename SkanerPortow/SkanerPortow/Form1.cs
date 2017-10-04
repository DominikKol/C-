using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace SkanerPortow
{
    public partial class SkanerPortow : Form
    {
        public SkanerPortow()
        {
            InitializeComponent();
            Komunikaty();
        }
        public List<int> openPorts = new List<int>();
        public bool stop = false;
        public int StartPort;
        public int KoniecPort;
        public object CL = new object();
        static int waitingForResponses;
        public int maxQueriesAtOneTime = 100;

        private void Komunikaty()
        {
            Logtxt.AppendText("Wprowadź IP oraz numery Portów i Rozpocznij Skanowanie \r\n");
            Logtxt.AppendText("\r\n");
        }
        public void EndConnect(IAsyncResult ar)
        {
            try
            {
                DecrementResponses();

                Socket TcpScan = ar.AsyncState as Socket;

                TcpScan.EndConnect(ar);

                if (TcpScan.Connected)
                {
                    int openPort = Convert.ToInt32(TcpScan.RemoteEndPoint.ToString().Split(':')[1]);//

                    openPorts.Add(openPort);

                    lock (CL)
                    {
                        Logtxt.AppendText("Połączenie TCP na porcie: " + openPort + " jest otwarte\r\n");
                    }
                    TcpScan.Disconnect(true);
                }
            }
            catch //()(Exception ex
            {
                // Logtxt.AppendText("Błąd:" + ex.Message + ex.StackTrace);
            }
        }

        public void SkanStart_Click(object sender, EventArgs e)
        {
            StartPort = Convert.ToInt32(numericUpDown1.Value);
            KoniecPort = Convert.ToInt32(numericUpDown2.Value);
            Komunikaty();
            //funkcje();
            Thread thr = new Thread(Skan);
            thr.Start();
        }
        public void Skan()
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(Host.Text, out ipAddress))
                StatusSkanu.Value = 0;
            StatusSkanu.Maximum = KoniecPort - StartPort + 1;
            Cursor.Current = Cursors.WaitCursor;
            for (int i = StartPort; i <= KoniecPort; i++)
            {

                while (waitingForResponses >= maxQueriesAtOneTime)
                    Thread.Sleep(0);
                if (stop)
                    break;

                try
                {
                    Socket TcpScan = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    TcpScan.BeginConnect(new IPEndPoint(ipAddress, i), EndConnect, TcpScan);

                    Interlocked.Increment(ref waitingForResponses);
                    //Logtxt.AppendText("Port numer: " + i + " jest OTWARTY\r\n");
                }
                catch (Exception ex)
                {
                    Logtxt.AppendText("Błąd:" + ex.Message + ex.StackTrace);
                    //Logtxt.AppendText("Port numer:" + i + " jest zamknięty\r\n");

                }
                StatusSkanu.PerformStep();
            }
            Cursor.Current = Cursors.Arrow;
        }
        static void IncrementResponses()
        {
            Interlocked.Increment(ref waitingForResponses);
        }

        static void DecrementResponses()
        {
            Interlocked.Decrement(ref waitingForResponses);
        }

        private void Host_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void wyczyśToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logtxt.Clear();
        }

        private void skanujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartPort = Convert.ToInt32(numericUpDown1.Value);
            KoniecPort = Convert.ToInt32(numericUpDown2.Value);
            Komunikaty();
            //funkcje();
            Thread thr = new Thread(Skan);
            thr.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logtxt.Clear();
            StatusSkanu.Value = 0;
        }

        private void wyjścieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
/*
        public void funkcje()
        {
            StartPort = Convert.ToInt32(numericUpDown1.Value);
            KoniecPort = Convert.ToInt32(numericUpDown2.Value);
            string ip = Host.Text;
            this.Invoke((MethodInvoker)delegate
            {
               Host.Text = ip;
             });
            decimal sp = numericUpDown1.Value;
            this.Invoke((MethodInvoker)delegate
            {
                numericUpDown1.Value = sp;
            });
            decimal kp = numericUpDown2.Value;
            this.Invoke((MethodInvoker)delegate
            {
                numericUpDown2.Value = kp;
            });
        }*/
