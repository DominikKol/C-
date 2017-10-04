namespace MassMeil
{
    partial class EdytorBazyDanych
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Logowanie = new System.Windows.Forms.Button();
            this.PASS = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.BazaDanych = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.polecenie = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.edytorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykonajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Logowanie);
            this.groupBox1.Controls.Add(this.PASS);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.BazaDanych);
            this.groupBox1.Controls.Add(this.Host);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logowanie do bazy danych";
            // 
            // Logowanie
            // 
            this.Logowanie.Enabled = false;
            this.Logowanie.Location = new System.Drawing.Point(45, 133);
            this.Logowanie.Name = "Logowanie";
            this.Logowanie.Size = new System.Drawing.Size(149, 23);
            this.Logowanie.TabIndex = 8;
            this.Logowanie.Text = "Wykonaj";
            this.Logowanie.UseVisualStyleBackColor = true;
            this.Logowanie.Click += new System.EventHandler(this.Logowanie_Click);
            // 
            // PASS
            // 
            this.PASS.Location = new System.Drawing.Point(45, 107);
            this.PASS.Name = "PASS";
            this.PASS.PasswordChar = '*';
            this.PASS.Size = new System.Drawing.Size(149, 20);
            this.PASS.TabIndex = 7;
            this.PASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(45, 81);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(149, 20);
            this.ID.TabIndex = 6;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BazaDanych
            // 
            this.BazaDanych.Location = new System.Drawing.Point(44, 55);
            this.BazaDanych.Name = "BazaDanych";
            this.BazaDanych.Size = new System.Drawing.Size(150, 20);
            this.BazaDanych.TabIndex = 5;
            this.BazaDanych.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(44, 29);
            this.Host.MaxLength = 15;
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(150, 20);
            this.Host.TabIndex = 4;
            this.Host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Host.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Host_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // polecenie
            // 
            this.polecenie.Location = new System.Drawing.Point(234, 37);
            this.polecenie.Multiline = true;
            this.polecenie.Name = "polecenie";
            this.polecenie.Size = new System.Drawing.Size(178, 156);
            this.polecenie.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(418, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 238);
            this.listBox1.TabIndex = 10;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(16, 215);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(105, 35);
            this.select.TabIndex = 11;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(163, 215);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(105, 35);
            this.insert.TabIndex = 12;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(307, 215);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(105, 35);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // edytorToolStripMenuItem
            // 
            this.edytorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.wykonajToolStripMenuItem,
            this.wyczyśćListBoxToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.edytorToolStripMenuItem.Name = "edytorToolStripMenuItem";
            this.edytorToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edytorToolStripMenuItem.Text = "Edytor";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // wykonajToolStripMenuItem
            // 
            this.wykonajToolStripMenuItem.Name = "wykonajToolStripMenuItem";
            this.wykonajToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wykonajToolStripMenuItem.Text = "Wykonaj";
            this.wykonajToolStripMenuItem.Click += new System.EventHandler(this.wykonajToolStripMenuItem_Click);
            // 
            // wyczyśćListBoxToolStripMenuItem
            // 
            this.wyczyśćListBoxToolStripMenuItem.Name = "wyczyśćListBoxToolStripMenuItem";
            this.wyczyśćListBoxToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wyczyśćListBoxToolStripMenuItem.Text = "Wyczyść ListBox";
            this.wyczyśćListBoxToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćListBoxToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 15;
            // 
            // EdytorBazyDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 287);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.select);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.polecenie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EdytorBazyDanych";
            this.Text = "EdytorBazyDanych";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Logowanie;
        private System.Windows.Forms.TextBox PASS;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox BazaDanych;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox polecenie;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edytorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykonajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}