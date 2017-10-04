namespace MassMeil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HasloSMTP = new System.Windows.Forms.MaskedTextBox();
            this.LoginSMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HostSMTP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BodyTextBox = new System.Windows.Forms.TextBox();
            this.HTML = new System.Windows.Forms.CheckBox();
            this.PrzyciskWyslij = new System.Windows.Forms.Button();
            this.Zalacznik = new System.Windows.Forms.Button();
            this.ZalacznikTextBox = new System.Windows.Forms.ListBox();
            this.TematTextBox = new System.Windows.Forms.TextBox();
            this.Adresat = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZałacznikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wyślijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.wyczyśćWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprawdzaniePortówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytorBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Polecenie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LogowanieMySQL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HasloMySQL = new System.Windows.Forms.TextBox();
            this.LoginMySQL = new System.Windows.Forms.TextBox();
            this.BazaMySQL = new System.Windows.Forms.TextBox();
            this.HostMySQL = new System.Windows.Forms.TextBox();
            this.lblPostep = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblczas = new System.Windows.Forms.Label();
            this.StatusWysylania = new System.Windows.Forms.ProgressBar();
            this.ListaAdresow = new System.Windows.Forms.ListBox();
            this.CzyszczeniePol = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HasloSMTP);
            this.groupBox2.Controls.Add(this.LoginSMTP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HostSMTP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(264, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serwer SMTP";
            // 
            // HasloSMTP
            // 
            this.HasloSMTP.Location = new System.Drawing.Point(60, 86);
            this.HasloSMTP.Name = "HasloSMTP";
            this.HasloSMTP.PasswordChar = '*';
            this.HasloSMTP.Size = new System.Drawing.Size(219, 22);
            this.HasloSMTP.TabIndex = 5;
            // 
            // LoginSMTP
            // 
            this.LoginSMTP.Location = new System.Drawing.Point(60, 49);
            this.LoginSMTP.Name = "LoginSMTP";
            this.LoginSMTP.Size = new System.Drawing.Size(219, 22);
            this.LoginSMTP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // HostSMTP
            // 
            this.HostSMTP.Location = new System.Drawing.Point(13, 19);
            this.HostSMTP.MaxLength = 15;
            this.HostSMTP.Name = "HostSMTP";
            this.HostSMTP.Size = new System.Drawing.Size(266, 22);
            this.HostSMTP.TabIndex = 1;
            this.HostSMTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BodyTextBox);
            this.groupBox3.Controls.Add(this.HTML);
            this.groupBox3.Controls.Add(this.PrzyciskWyslij);
            this.groupBox3.Controls.Add(this.Zalacznik);
            this.groupBox3.Controls.Add(this.ZalacznikTextBox);
            this.groupBox3.Controls.Add(this.TematTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(264, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 416);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temat";
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.Location = new System.Drawing.Point(8, 106);
            this.BodyTextBox.Multiline = true;
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(279, 256);
            this.BodyTextBox.TabIndex = 2;
            this.BodyTextBox.Text = "test";
            // 
            // HTML
            // 
            this.HTML.AutoSize = true;
            this.HTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HTML.Location = new System.Drawing.Point(6, 384);
            this.HTML.Name = "HTML";
            this.HTML.Size = new System.Drawing.Size(80, 17);
            this.HTML.TabIndex = 3;
            this.HTML.Text = "Tryb HTML";
            this.HTML.UseVisualStyleBackColor = true;
            // 
            // PrzyciskWyslij
            // 
            this.PrzyciskWyslij.Location = new System.Drawing.Point(109, 368);
            this.PrzyciskWyslij.Name = "PrzyciskWyslij";
            this.PrzyciskWyslij.Size = new System.Drawing.Size(80, 30);
            this.PrzyciskWyslij.TabIndex = 3;
            this.PrzyciskWyslij.Text = "Wyślij";
            this.PrzyciskWyslij.UseVisualStyleBackColor = true;
            this.PrzyciskWyslij.Click += new System.EventHandler(this.PrzyciskWyslij_Click);
            // 
            // Zalacznik
            // 
            this.Zalacznik.Location = new System.Drawing.Point(253, 60);
            this.Zalacznik.Name = "Zalacznik";
            this.Zalacznik.Size = new System.Drawing.Size(32, 27);
            this.Zalacznik.TabIndex = 3;
            this.Zalacznik.Text = "...";
            this.Zalacznik.UseVisualStyleBackColor = true;
            this.Zalacznik.Click += new System.EventHandler(this.DodajZalacznik_Click);
            // 
            // ZalacznikTextBox
            // 
            this.ZalacznikTextBox.FormattingEnabled = true;
            this.ZalacznikTextBox.HorizontalScrollbar = true;
            this.ZalacznikTextBox.ItemHeight = 16;
            this.ZalacznikTextBox.Location = new System.Drawing.Point(8, 48);
            this.ZalacznikTextBox.Name = "ZalacznikTextBox";
            this.ZalacznikTextBox.Size = new System.Drawing.Size(239, 52);
            this.ZalacznikTextBox.TabIndex = 2;
            // 
            // TematTextBox
            // 
            this.TematTextBox.Location = new System.Drawing.Point(8, 19);
            this.TematTextBox.Name = "TematTextBox";
            this.TematTextBox.Size = new System.Drawing.Size(279, 22);
            this.TematTextBox.TabIndex = 1;
            this.TematTextBox.Text = "test";
            // 
            // Adresat
            // 
            this.Adresat.Location = new System.Drawing.Point(10, 19);
            this.Adresat.Name = "Adresat";
            this.Adresat.Size = new System.Drawing.Size(277, 21);
            this.Adresat.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Adresat);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(264, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 51);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adresat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oProgramieToolStripMenuItem,
            this.dodatkiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZałacznikToolStripMenuItem,
            this.toolStripSeparator1,
            this.wyślijToolStripMenuItem,
            this.toolStripSeparator3,
            this.wyczyśćWszystkoToolStripMenuItem,
            this.wyjścieToolStripMenuItem,
            this.toolStripMenuItem1});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Delete)));
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.ToolTipText = "Funkcje programu";
            // 
            // dodajZałacznikToolStripMenuItem
            // 
            this.dodajZałacznikToolStripMenuItem.Name = "dodajZałacznikToolStripMenuItem";
            this.dodajZałacznikToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.dodajZałacznikToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.dodajZałacznikToolStripMenuItem.Text = "Dodaj Załacznik";
            this.dodajZałacznikToolStripMenuItem.ToolTipText = "Dodaj Załącznik";
            this.dodajZałacznikToolStripMenuItem.Click += new System.EventHandler(this.DodajZalacznik_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // wyślijToolStripMenuItem
            // 
            this.wyślijToolStripMenuItem.Name = "wyślijToolStripMenuItem";
            this.wyślijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.wyślijToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.wyślijToolStripMenuItem.Text = "Wyślij";
            this.wyślijToolStripMenuItem.ToolTipText = "Wyślij";
            this.wyślijToolStripMenuItem.Click += new System.EventHandler(this.PrzyciskWyslij_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(249, 6);
            // 
            // wyczyśćWszystkoToolStripMenuItem
            // 
            this.wyczyśćWszystkoToolStripMenuItem.Name = "wyczyśćWszystkoToolStripMenuItem";
            this.wyczyśćWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.wyczyśćWszystkoToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.wyczyśćWszystkoToolStripMenuItem.Text = "Wyczyść wszystko";
            this.wyczyśćWszystkoToolStripMenuItem.ToolTipText = "Wyczyść wszystko";
            this.wyczyśćWszystkoToolStripMenuItem.Click += new System.EventHandler(this.CzyszczeniePol_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.ToolTipText = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.toolStripMenuItem1.Text = "Restar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.ToolTipText = "Informacje o programie";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.ToolTipText = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // dodatkiToolStripMenuItem
            // 
            this.dodatkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprawdzaniePortówToolStripMenuItem,
            this.edytorBazyDanychToolStripMenuItem});
            this.dodatkiToolStripMenuItem.Name = "dodatkiToolStripMenuItem";
            this.dodatkiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.dodatkiToolStripMenuItem.Text = "Dodatki";
            // 
            // sprawdzaniePortówToolStripMenuItem
            // 
            this.sprawdzaniePortówToolStripMenuItem.Name = "sprawdzaniePortówToolStripMenuItem";
            this.sprawdzaniePortówToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sprawdzaniePortówToolStripMenuItem.Text = "Sprawdzanie portów";
            this.sprawdzaniePortówToolStripMenuItem.Click += new System.EventHandler(this.sprawdzaniePortówToolStripMenuItem_Click);
            // 
            // edytorBazyDanychToolStripMenuItem
            // 
            this.edytorBazyDanychToolStripMenuItem.Name = "edytorBazyDanychToolStripMenuItem";
            this.edytorBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.edytorBazyDanychToolStripMenuItem.Text = "Edytor bazy danych";
            this.edytorBazyDanychToolStripMenuItem.Click += new System.EventHandler(this.edytorBazyDanychToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.Polecenie);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.LogowanieMySQL);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.HasloMySQL);
            this.groupBox5.Controls.Add(this.LoginMySQL);
            this.groupBox5.Controls.Add(this.BazaMySQL);
            this.groupBox5.Controls.Add(this.HostMySQL);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(561, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 281);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Logowanie do bazy SQL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Polecenia \r\n    Sql:";
            // 
            // Polecenie
            // 
            this.Polecenie.Location = new System.Drawing.Point(77, 170);
            this.Polecenie.Multiline = true;
            this.Polecenie.Name = "Polecenie";
            this.Polecenie.Size = new System.Drawing.Size(198, 66);
            this.Polecenie.TabIndex = 8;
            this.Polecenie.Text = "select * from test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hasło:";
            // 
            // LogowanieMySQL
            // 
            this.LogowanieMySQL.Location = new System.Drawing.Point(111, 242);
            this.LogowanieMySQL.Name = "LogowanieMySQL";
            this.LogowanieMySQL.Size = new System.Drawing.Size(85, 28);
            this.LogowanieMySQL.TabIndex = 7;
            this.LogowanieMySQL.Text = "logowanie baza";
            this.LogowanieMySQL.UseVisualStyleBackColor = true;
            this.LogowanieMySQL.Click += new System.EventHandler(this.LogowanieMySQL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(7, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Baza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host:";
            // 
            // HasloMySQL
            // 
            this.HasloMySQL.Location = new System.Drawing.Point(55, 134);
            this.HasloMySQL.Name = "HasloMySQL";
            this.HasloMySQL.PasswordChar = '*';
            this.HasloMySQL.Size = new System.Drawing.Size(220, 22);
            this.HasloMySQL.TabIndex = 3;
            // 
            // LoginMySQL
            // 
            this.LoginMySQL.Location = new System.Drawing.Point(55, 94);
            this.LoginMySQL.Name = "LoginMySQL";
            this.LoginMySQL.Size = new System.Drawing.Size(220, 22);
            this.LoginMySQL.TabIndex = 2;
            // 
            // BazaMySQL
            // 
            this.BazaMySQL.Location = new System.Drawing.Point(55, 53);
            this.BazaMySQL.Name = "BazaMySQL";
            this.BazaMySQL.Size = new System.Drawing.Size(220, 22);
            this.BazaMySQL.TabIndex = 1;
            // 
            // HostMySQL
            // 
            this.HostMySQL.Location = new System.Drawing.Point(55, 19);
            this.HostMySQL.MaxLength = 15;
            this.HostMySQL.Name = "HostMySQL";
            this.HostMySQL.Size = new System.Drawing.Size(220, 22);
            this.HostMySQL.TabIndex = 0;
            this.HostMySQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // lblPostep
            // 
            this.lblPostep.AutoSize = true;
            this.lblPostep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostep.Location = new System.Drawing.Point(33, 35);
            this.lblPostep.Name = "lblPostep";
            this.lblPostep.Size = new System.Drawing.Size(213, 18);
            this.lblPostep.TabIndex = 9;
            this.lblPostep.Text = "Status Wysyłania Wiadomości ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblczas);
            this.groupBox1.Controls.Add(this.StatusWysylania);
            this.groupBox1.Controls.Add(this.lblPostep);
            this.groupBox1.Location = new System.Drawing.Point(561, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblczas
            // 
            this.lblczas.AutoSize = true;
            this.lblczas.Location = new System.Drawing.Point(10, 76);
            this.lblczas.Name = "lblczas";
            this.lblczas.Size = new System.Drawing.Size(36, 13);
            this.lblczas.TabIndex = 16;
            this.lblczas.Text = "Czas :";
            // 
            // StatusWysylania
            // 
            this.StatusWysylania.Location = new System.Drawing.Point(6, 9);
            this.StatusWysylania.Name = "StatusWysylania";
            this.StatusWysylania.Size = new System.Drawing.Size(279, 23);
            this.StatusWysylania.Step = 1;
            this.StatusWysylania.TabIndex = 15;
            // 
            // ListaAdresow
            // 
            this.ListaAdresow.FormattingEnabled = true;
            this.ListaAdresow.Location = new System.Drawing.Point(12, 38);
            this.ListaAdresow.Name = "ListaAdresow";
            this.ListaAdresow.Size = new System.Drawing.Size(246, 576);
            this.ListaAdresow.TabIndex = 10;
            this.ListaAdresow.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // CzyszczeniePol
            // 
            this.CzyszczeniePol.Location = new System.Drawing.Point(597, 436);
            this.CzyszczeniePol.Name = "CzyszczeniePol";
            this.CzyszczeniePol.Size = new System.Drawing.Size(222, 39);
            this.CzyszczeniePol.TabIndex = 12;
            this.CzyszczeniePol.Text = "Wyczyść Wszystko ";
            this.CzyszczeniePol.UseVisualStyleBackColor = true;
            this.CzyszczeniePol.Click += new System.EventHandler(this.CzyszczeniePol_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 640);
            this.Controls.Add(this.CzyszczeniePol);
            this.Controls.Add(this.ListaAdresow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MassM";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox HasloSMTP;
        private System.Windows.Forms.TextBox LoginSMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HostSMTP;
        private System.Windows.Forms.CheckBox HTML;
        private System.Windows.Forms.Button PrzyciskWyslij;
        private System.Windows.Forms.Button Zalacznik;
        private System.Windows.Forms.ListBox ZalacznikTextBox;
        private System.Windows.Forms.TextBox TematTextBox;
        private System.Windows.Forms.TextBox Adresat;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox BodyTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZałacznikToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem wyślijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HasloMySQL;
        private System.Windows.Forms.TextBox LoginMySQL;
        private System.Windows.Forms.TextBox BazaMySQL;
        private System.Windows.Forms.TextBox HostMySQL;
        private System.Windows.Forms.Button LogowanieMySQL;
        private System.Windows.Forms.Label lblPostep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Polecenie;
        private System.Windows.Forms.ListBox ListaAdresow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button CzyszczeniePol;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar StatusWysylania;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem dodatkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprawdzaniePortówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytorBazyDanychToolStripMenuItem;
        private System.Windows.Forms.Label lblczas;
    }
}

