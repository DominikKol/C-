using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net.Security;
using System.Net;
using System.Net.Mail;

namespace KlientPocztowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąc aplikacje?", "Zakończenie pracy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;   // Wyskakujace okienko z informacja o zamknieciu aplikacji
            else
                e.Cancel = false;
        }
        private TcpClient client; // deklarujemy prywatne pole inicjujące zmienną klasy TcpClient
        private NetworkStream ns; // Tworzenie fikcyjnego pola Strumieni sieciowych
        private StreamReader streamr; //prywatne pole inicjujace Czytanie Strumienia danych
        private StreamWriter streamw; //prywatne pole inicjujace Wpisywanie Strumienia danych
        public int portSMTP; // publiczne pola a w nich zmienne do obsługi portu SMTP i POP3
        public int portPOP3;

        private void WysylanieWiadomosci()
        {
            MailAddress Od = null; // utworzenie 
            MailAddress Do = null;
            MailMessage wiadomosc = new MailMessage();  // utworzenie wiadomosci 
            try
            {
                Od = new MailAddress(Odtbx.Text); // odczytanie nadawcy z TextBoxu
            }
            catch // blok try catch sprawdza czy przy okazji czy pole jest wypełnione
            {
                MessageBox.Show("Nieprawidłowy adres nadawcy");
                Odtbx.Clear(); // czyści textbox z nadawca
                return;
            }
            wiadomosc.From = Od; // nagłówek wiadomosci nadawca
            if (listBox2.Items.Count > 0) // odczytanie z listBox czy zawiera załączniki
                foreach (string plik in listBox2.Items)
                {
                    Attachment zalacznik = new Attachment(plik); // Zainicjowanie klasy Zalacznik
                    wiadomosc.Attachments.Add(zalacznik); // dodanie do wiadomosci zalacznika
                }
            try
            {
                foreach (string adres in listBox1.Items) // w petli foreach tworzymy obiekt ciąg umiejscowiony w Składnikach (wierszach) listBox / w osobnym fragmencie kodu dodajemy do listBoxu za pomoca textboxa adresy odbiorców
                {
                    Do = new MailAddress(adres); // 
                    wiadomosc.To.Add(Do); // dodanie do nagłówka odbiorcy/ów
                }
                wiadomosc.Subject = TematTb.Text;
                wiadomosc.Body = TrescTb.Text; // nagłówek wiadomości odczytywany z TextBoxów 
                wiadomosc.IsBodyHtml = TrescChb.Checked; // jeżeli zaznaczony checkBox to wiadomosc obsługuje HTML
                MailAddress CarbonCopy = new MailAddress(CCtbx.Text);  // Tworzenie CarbonCopy 
                wiadomosc.CC.Add(CarbonCopy);
            }
            catch (Exception ex) // sprawdzenie błedów ze ścieżką błedu
            {
                MessageBox.Show("Błąd w wysylce:" + ex.Message + ex.TargetSite + ex.StackTrace);
            }
            try
            {
                SmtpClient Client = new SmtpClient(SMTPtb.Text); // Odwołanie do klasy i utworzenie zmiennej klienta, wczytanie z TextBOxu hosta SMTP
                Client.EnableSsl = SSLchb.Checked; // To samo co z HTML
                SSLchb.Checked = true;
                Client.Host = SMTPtb.Text;  // wczytanie Hosta SMTP
                Client.UseDefaultCredentials = true;
                portSMTP = Convert.ToInt32(PortSMTP.Value); // Wywołanie zmiennej publicznej i konwersja Numeru portu z kontrolki numeric coś tam 
                Client.Port = portSMTP; // Dodanie portu do klienta
                Client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //Client.Credentials = new NetworkCredential(LoginSMTPtb.Text, PassSMTPtb.Text);
                if (LoginSMTPtb.Text != string.Empty && PassSMTPtb.Text != string.Empty) // w instrukcji warunkowej sprawdzamy czy został wprowadzony login i hasło
                    Client.Credentials = new NetworkCredential(LoginSMTPtb.Text, PassSMTPtb.Text);
                else
                {
                    MessageBox.Show("Prosze podac nazwe użytkownika i hasło");
                    return;
                }
                // Client.SendCompleted += new SendCompletedEventHandler(WiadomoscWyslana);
                Client.Send(wiadomosc); // wysłanie wiadomości
                MessageBox.Show("Wiadomosc została wysłana");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad: " + ex.Message);
            }
        }
        private void WyslijBt_Click(object sender, EventArgs e)
        {
            // Thread thr = new Thread(WysylanieWiadomosci);
            // thr.Start();
            mierzczas(); // wywołanie metody mierzącej czas i wysyłającej maile
        }
        private void DodajAdresButton_Click(object sender, EventArgs e)// dodanie odbiorcy
        {
            if (DoTextBox.Text != string.Empty) // Sprawdza czy tekst Box nie jest pusty
                if (DoTextBox.Text.Trim().Length > 0) //sprawdza czy tekst w textBoxie jest wiekszy niż 0 , jeżeli warunki są spełnione to wpisuje zawartosc do list Box i czysci textBox 
                {
                    listBox1.Items.Add(DoTextBox.Text); // Dodanie do listBoxu zawartosci textboxu
                    DoTextBox.Clear(); //wyczysc textbox
                }
        }
        public void mierzczas() // metoda odmierza czas od wywołania metody do jej zakończenie , 
                                //metoda umiejscowiona jest po środku. 
                                //Inicjacja wystąpienia klasy Stoper i wyświetlenie wyniku w etykiecie w postaciu sekund
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            WysylanieWiadomosci();
            sw.Stop();
            lblczas.Text = ("Wysłano w :" + sw.Elapsed.Seconds.ToString() + " s");
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) listBox1.Items.RemoveAt(listBox1.SelectedIndex); // usuwa 1 wiersz z listBoxu po podwójnym kliknieciu na ListBOx
        }
        private void DodajZalacznikButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // otworzenie okna dialogowego pozwalającego na wybranie pliku z wybranego folderu ( pulpit) i dodanie go do ListBoxa
                try
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                        listBox2.Items.Add(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd wczytywania pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public void LogowaniePOP3_Click(object sender, EventArgs e) // Metoda zdarzeniowa logująca i pobierająca adresy przez pop3 do listBox3
        {
            listBox1.Items.Clear(); // czyści listBox3
            StatusPOP3tb.Text = "Czekam na wiadomości...";
            Thread startlogin = new Thread(new ThreadStart(login)); // Tworzy nowy wątek (startlogin ) wywołujący metode login
            startlogin.IsBackground = true;
            startlogin.Start(); // rozpoczecie wątku 
        }
        public void login()
        {
            string response;
            string from = null; // ciągi zerowe 
            string subject = null;
            string date = null;
            int totmessages;
            portPOP3 = Convert.ToInt32(PortPOP3.Value); // to samo co przy SMTP

            try
            {
                client = new TcpClient(); //tworzenie nowego klienta
                client.Connect(POP3tb.Text, portPOP3); // wywołanie polacznie klienta i pobranie hosta i portu
            }
            catch (SocketException)
            {
                StatusPOP3tb.Text = "Błąd połączenia z serwerem";
                return;
            }
            SslStream stream = new SslStream(client.GetStream());// tworzenie nowego strumienia sieci klienta 
            stream.AuthenticateAsClient(POP3tb.Text); //uwierzytelnianie strumienia
            ns = client.GetStream();

            streamr = new StreamReader(stream); // tworzenie nowego strumienia czytajacego
            streamw = new StreamWriter(stream); // tworzenie nowego strumienia wypisujacego

            response = streamr.ReadLine(); //Get opening POP3 banner

            streamw.WriteLine("User " + LoginPOP3tb.Text); //Wysyłka Loginu
            streamw.Flush();

            response = streamr.ReadLine(); // jeżeli nie poprawne wyświetl komunikat
            if (response.Substring(0, 4) == "-ERR")
            {
                StatusPOP3tb.Text = "Błąd logowania z serwerem";
                return;
            }

            streamw.WriteLine("Pass " + PassPOP3tb.Text);  //Wysyłka Hasła
            streamw.Flush();

            try
            {
                response = streamr.ReadLine();// jeżeli nie poprawne wyświetl komunikat
            }
            catch (IOException)
            {
                StatusPOP3tb.Text = "Błąd logowania z serwerem";
                return;
            }
            if (response.Substring(0, 3) == "-ER")// jeżeli nie poprawne wyświetl komunikat
            {
                StatusPOP3tb.Text = "Błąd logowania z serwerem";
                return;
            }

            streamw.WriteLine("stat");
            streamw.Flush();

            response = streamr.ReadLine();
            string[] nummess = response.Split(' '); // tworzymy tablice 

            totmessages = Convert.ToInt16(nummess[1]); // sprawdzamy ile wiadomosci mamy na serwerze 
            if (totmessages > 0)
            {
                StatusPOP3tb.Clear();
                StatusPOP3tb.Text = "Masz " + totmessages + " wiadomości";
            }
            else
            {
                StatusPOP3tb.Text = "Nie masz nowych wiadomości";
            }

            for (int i = 1; i <= totmessages; i++) // Petla wyświetla wiadomości od 1 do x 
            {
                streamw.WriteLine("top " + i + " 0");  // czytanie nagłówka wiadomosci
                streamw.Flush();
                response = streamr.ReadLine();
                while (true)
                {

                    response = streamr.ReadLine();
                    if (response == ".")
                        break;
                    if (response.Length > 4) // warunek sprawdza czy długosc jest wieksza od 4 
                    {
                        if (response.Substring(0, 5) == "From:") // Substring(0, 5) oznacza pozycje FROM: = 5 znaków  
                            from = response;
                    }
                    if (response.Length > 7)
                    {
                        if (response.Substring(0, 8) == "Subject:")
                            subject = response;
                    }
                    if (response.Length > 4)
                    {
                        if (response.Substring(0, 5) == "Date:")
                            date = response;
                    }
                }
                listBox3.Items.Add(i + "  " + from + "  " + subject + "  " + date + "  "); // dodanie do listBoxu nadawcy , tematu i daty wiadomosci
            }
            //client.Close();
        }
        private void ZapiszDoPliku_Click(object sender, EventArgs e) // zapisanie do pliku listy wiadomosci z ListBOX
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Zapisz plik";
            saveFileDialog1.FileName = "Lista maili";
            saveFileDialog1.Filter = "Dokumenty tekstowe (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sww = new StreamWriter(saveFileDialog1.FileName)) // inicjazja wypisywania strumienia danych 
                {
                    foreach (string wpis in listBox3.Items) // w petli tworzymy ciag umiejscowiony w listBox i wypisujemy je do pliku
                        sww.WriteLine(wpis);
                }
            }
        }
        private void WylogowaniePOP3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StatusPOP3tb.Clear();
            if (ns != null) // jeżeli networkstream jest równy zero to instrukacja warunkowa zamyka polaczenie StreamWriter , Streamreader , Zamyka NetworkStream, połączenie z klientem i wypisuje komunikat o zakmnieciu połaczeni
            {
                streamw.Close();
                streamr.Close();
                ns.Close();
                client.Close();
            }
            StatusPOP3tb.Text = "Połączenie z sererem pop3 zakończone";
        }
        private void DomyslnePOP3_Click(object sender, EventArgs e) // ta metoda zdarzeniowa wpisuje po kliknieciu przycisku do odpowiednich pół poniższe dane 
        {
            POP3tb.Text = "pop.gmail.com";
            LoginPOP3tb.Text = "example@gmail.com";
            PassPOP3tb.Text = "example";
            PortPOP3.Value = 995;
        }
        private void DomyslneSMTP_Click(object sender, EventArgs e) // ta metoda zdarzeniowa wpisuje po kliknieciu przycisku do odpowiednich pół poniższe dane 
        {
            SMTPtb.Text = "smtp.gmail.com";
            LoginSMTPtb.Text = "example@gmail.com";
            PassSMTPtb.Text = "example";
            PortSMTP.Value = 587;
            SSLchb.Checked = true;
            Odtbx.Text = "example@gmail.com";
            CCtbx.Text = "example@gmail.com";
            TematTb.Text = "test";
            TrescTb.Text = "test";
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e) // Reset aplikacji
        {
            Application.Restart();
        }
        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e) // Wyjście z apliakcji
        {
            Close();
        }
    }
}
