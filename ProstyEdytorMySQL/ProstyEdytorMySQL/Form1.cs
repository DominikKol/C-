using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProstyEdytorMySQL
{
    public partial class EdytorBazyDanych : Form
    {
        public EdytorBazyDanych()
        {
            InitializeComponent();
        }

        public void pobierzDane()
        {
            string mojePolaczenie =
            ";PORT=3306;SERVER=" + Host.Text + ";" +
            "DATABASE=" + BazaDanych.Text + ";" +
            "UID=" + ID.Text + ";" +
            "PASSWORD=" + PASS.Text + ";";
            string sql = polecenie.Text;//"" + polecenie.Text + ';';//+ polecenie.Text +
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
                            listBox1.Items.Add(reader.GetString(0));
                        }
                        MessageBox.Show("Polecenie zostało wykonane");
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show(e.Message + e.StackTrace + "Błąd logowania do bazy danych MySQL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            polaczenie.Close();
        }
        public void mierzczas()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            pobierzDane();
            sw.Stop();
            label5.Text = ("Polecenie wykonano w :" + sw.ElapsedMilliseconds.ToString() + "ms");
        }
        private void Logowanie_Click(object sender, EventArgs e)
        {
            mierzczas();
            //pobierzDane();
            polecenie.Clear();
            Logowanie.Enabled = false;
            polecenie.Enabled = true;
            update.Enabled = true;
            insert.Enabled = true;
            select.Enabled = true;
        }

        private void select_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            update.Enabled = false;
            insert.Enabled = false;
            Logowanie.Enabled = true;
            polecenie.AppendText("SELECT * FROM test" + ';');
        }

        private void insert_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            select.Enabled = false;
            update.Enabled = false;
            Logowanie.Enabled = true;
            polecenie.AppendText("INSERT INTO test(konto) VALUES('')" + ';');
        }


        private void update_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            insert.Enabled = false;
            select.Enabled = false;
            Logowanie.Enabled = true;
            polecenie.AppendText("UPDATE test SET konto='' WHERE konto= ''" + ';');
        }

        private void Host_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void wyczyśćListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logowanie.Enabled = true;
            polecenie.AppendText("SELECT * FROM test");
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logowanie.Enabled = true;
            polecenie.AppendText("INSERT INTO test (konto) VALUES (' ')");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logowanie.Enabled = true;
            polecenie.AppendText("UPDATE test SET konto=' ' WHERE konto= ' '");
        }

        private void wykonajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pobierzDane();
            polecenie.Clear();
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
