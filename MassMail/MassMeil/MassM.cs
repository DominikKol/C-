using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace MassMeil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += new EventHandler(Form1_Show);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }
        public void Form1_Show(object sender, System.EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();       
        }
        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = ListaAdresow.Items.Count; i <= wyslano; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    backgroundWorker1.ReportProgress(wyslano);
                }
            }
        }
        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           //this.progressBar1.Value = e.ProgressPercentage;   // Zmień wartość ProgressBar do postępu BackgroundWorker.
        }
            static public int wyslano;
            static public int bledy;
            public void WyslijWiadomosc(string adres)
            {
                StatusWysylania.Value = 0;
                StatusWysylania.Maximum = ListaAdresow.Items.Count - wyslano;
                try
                {
                    MailMessage wiadomosc = new MailMessage();
                    wiadomosc.To.Add(adres);
                    wiadomosc.From = new MailAddress(Adresat.Text);
                    wiadomosc.IsBodyHtml = HTML.Checked;
                    wiadomosc.Subject = TematTextBox.Text;
                    wiadomosc.Body = BodyTextBox.Text;
                    wiadomosc.Priority = MailPriority.High;
                    wiadomosc.ReplyToList.Add("example@example.pl");
                    MailAddress cc = new MailAddress("example@example.pl");
                    MailAddress bcc = new MailAddress("example@example.pl");
                    wiadomosc.Bcc.Add(bcc);
                    wiadomosc.CC.Add(cc);
                    wiadomosc.BodyEncoding = System.Text.Encoding.UTF8;
                    wiadomosc.SubjectEncoding = System.Text.Encoding.UTF8;
                    SmtpClient klient = new SmtpClient(HostSMTP.Text);
                    {
                        klient.EnableSsl = false;
                        klient.UseDefaultCredentials = true;
                        klient.Credentials = new NetworkCredential(LoginSMTP.Text, HasloSMTP.Text);
                        klient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        lblPostep.Text = "";
                    }
                    klient.SendMailAsync(wiadomosc);
                    klient.SendCompleted += new SendCompletedEventHandler(klient_SendCompleted);
                }
                catch (InvalidAsynchronousStateException ex)
                {
                    MessageBox.Show("Błąd: " + ex.StackTrace + ex.ParamName);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Błąd: " + ex.StackTrace);
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show("Błąd: " + ex.StackTrace + ex.StatusCode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message + ex.StackTrace);
                }
                StatusWysylania.PerformStep();
            }
            public void wyslij()
            {
                for (wyslano = 0; wyslano < ListaAdresow.Items.Count; wyslano++)
                {
                    if (wyslano < ListaAdresow.Items.Count)
                    {
                        string adres = ListaAdresow.Items[wyslano].ToString();
                        WyslijWiadomosc(adres);
                        WyswietlPodsumowanie();
                    }
                    //wyslano++;
                }
                
            }/*
            public void CzyListBoxPusty()
            {
                if (this.ListaAdresow.Items.Contains(this.ListaAdresow.Items.Count))
                {
                    this.ListaAdresow.Items.Remove(this.ListaAdresow.Items.Count);
                }
                else
                {
                    MessageBox.Show("Brak adresów", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblczas.Text = "";
                }
            }*/
            public void WyswietlPodsumowanie()
            {
                //DateTime czas2 = DateTime.Now;
                //TimeSpan diff = czas2 - czas;
                lblPostep.Text = string.Format("Przetworzono {0} z {1} wiadomości.\nNie udało się wysłać: {2}.", wyslano, ListaAdresow.Items.Count, bledy);
                //label8.Text = (" Czas wykonania równy | : " + diff.ToString());
               // lblPostep.Focus();
                lblPostep.Refresh();
            }
        public void mierzczas()
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                wyslij();
                sw.Stop();
                lblczas.Text = ("Wysyłanie wykonano w :" + sw.ElapsedMilliseconds.ToString() + "ms");
            }
            public void klient_SendCompleted(object sender, AsyncCompletedEventArgs e)
            {
               
                if (e.Cancelled || e.Error != null)   //if (wyslano < listBox1.Items.Count){ WyslijWiadomosc(); }
                    bledy++;/*
                if (wyslano < ListaAdresow.Items.Count)
                {
                   string adres = ListaAdresow.Items[wyslano].ToString();
                   WyslijWiadomosc(adres);
                }
                else
                {
                   WyswietlPodsumowanie();
                    //MessageBox.Show("Wysyłanie zakończone", "Status wysyłania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }*/
            }
            public void PrzyciskWyslij_Click(object sender, EventArgs e)
            {
                //wyslij();
                Thread thr = new Thread(wyslij);
                thr.Start();
                mierzczas();
                LogowanieMySQL.Enabled = true;
            }
        public void LogowanieMySQL_Click(object sender, EventArgs e)
        {
            pobierzDane();
            LogowanieMySQL.Enabled = false;
        }
        public void pobierzDane()
        {
            string mojePolaczenie =
            ";PORT=3306;SERVER=" + HostMySQL.Text + ";" +
            "DATABASE=" + BazaMySQL.Text + ";" +
            "UID=" + LoginMySQL.Text + ";" +
            "PASSWORD=" + HasloMySQL.Text + ";";
            string sql = "" + Polecenie.Text +';';
            MySqlConnection polaczenie = new MySqlConnection(mojePolaczenie);
            try
            {
                polaczenie.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, polaczenie))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaAdresow.Items.Add(reader.GetString(0));
                        }
                    }
                }
             }
            catch (MySql.Data.MySqlClient.MySqlException){
                MessageBox.Show("Błąd logowania do bazy danych MySQL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            polaczenie.Close();
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (ListaAdresow.SelectedIndex != -1)
                ListaAdresow.Items.RemoveAt(ListaAdresow.SelectedIndex);
        }
        private void DodajZalacznik_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                try
                {
                    //openFileDialog1.DefaultExt = "";
                    // openFileDialog1.Filter = "Wszystkie dokumenty (*.csv)|*.csv";
                    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        ZalacznikTextBox.Items.Add(openFileDialog1.FileName);
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message, "Błąd odczytu pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void wyczyśćWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogowanieMySQL.Enabled = true;
            PrzyciskWyslij.Enabled = true;
            ListaAdresow.Items.Clear();
            ZalacznikTextBox.Items.Clear();
            LoginSMTP.Clear();
            TematTextBox.Clear();
            BodyTextBox.Clear();
            BazaMySQL.Clear();
            LoginMySQL.Clear();
            HasloMySQL.Clear();
            HasloSMTP.Clear();
            
        }
        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void CzyszczeniePol_Click(object sender, EventArgs e)
        {
            LogowanieMySQL.Enabled = true;
            PrzyciskWyslij.Enabled = true;
            ListaAdresow.Items.Clear();
            ZalacznikTextBox.Items.Clear();
            StatusWysylania.Value = 0;


            /*
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            maskedTextBox1.Clear();*/
        }
        private void sprawdzaniePortówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkanerPortow okno = new SkanerPortow();
            okno.Text = "Skaner portów";
            okno.Show();
           // if (okno.ShowDialog() == System.Windows.Forms.DialogResult.OK);
        }
        private void edytorBazyDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdytorBazyDanych okno1 = new EdytorBazyDanych();
            okno1.Text = "Edytor baz danych";
            okno1.Show();
            //if(okno1.ShowDialog() == System.Windows.Forms.DialogResult.OK);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }
        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja MassMeilingowa\r\nWersja 1.0.0\r\n(C)Dominik Koliński 2014\r\nE-mail: dominik.kolinski@gmail.com", "O programie", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}