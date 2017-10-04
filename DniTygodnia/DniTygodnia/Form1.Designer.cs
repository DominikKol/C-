namespace DniTygodnia
{
    partial class FormDatownik
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
            this.groupBoxWczoraj = new System.Windows.Forms.GroupBox();
            this.buttonKolorPierwszoplanowy = new System.Windows.Forms.Button();
            this.labelWczoraj = new System.Windows.Forms.Label();
            this.buttonPoprzedni = new System.Windows.Forms.Button();
            this.groupBoxDzisiaj = new System.Windows.Forms.GroupBox();
            this.buttonKolorTła = new System.Windows.Forms.Button();
            this.labelDzisiaj = new System.Windows.Forms.Label();
            this.buttonBieżący = new System.Windows.Forms.Button();
            this.groupBoxJutro = new System.Windows.Forms.GroupBox();
            this.buttonCzcionka = new System.Windows.Forms.Button();
            this.labelJutro = new System.Windows.Forms.Label();
            this.buttonNastępny = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Zegar = new System.Windows.Forms.Timer(this.components);
            this.groupBoxWczoraj.SuspendLayout();
            this.groupBoxDzisiaj.SuspendLayout();
            this.groupBoxJutro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWczoraj
            // 
            this.groupBoxWczoraj.Controls.Add(this.buttonKolorPierwszoplanowy);
            this.groupBoxWczoraj.Controls.Add(this.labelWczoraj);
            this.groupBoxWczoraj.Controls.Add(this.buttonPoprzedni);
            this.groupBoxWczoraj.Location = new System.Drawing.Point(5, 6);
            this.groupBoxWczoraj.Name = "groupBoxWczoraj";
            this.groupBoxWczoraj.Size = new System.Drawing.Size(200, 200);
            this.groupBoxWczoraj.TabIndex = 1;
            this.groupBoxWczoraj.TabStop = false;
            // 
            // buttonKolorPierwszoplanowy
            // 
            this.buttonKolorPierwszoplanowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKolorPierwszoplanowy.Location = new System.Drawing.Point(32, 143);
            this.buttonKolorPierwszoplanowy.Name = "buttonKolorPierwszoplanowy";
            this.buttonKolorPierwszoplanowy.Size = new System.Drawing.Size(130, 50);
            this.buttonKolorPierwszoplanowy.TabIndex = 2;
            this.buttonKolorPierwszoplanowy.Text = "Zmień kolor pierwszoplanowy";
            this.buttonKolorPierwszoplanowy.UseVisualStyleBackColor = true;
            this.buttonKolorPierwszoplanowy.Click += new System.EventHandler(this.buttonKolorPierwszoplanowy_Click);
            // 
            // labelWczoraj
            // 
            this.labelWczoraj.AutoSize = true;
            this.labelWczoraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWczoraj.Location = new System.Drawing.Point(5, 10);
            this.labelWczoraj.MaximumSize = new System.Drawing.Size(180, 0);
            this.labelWczoraj.Name = "labelWczoraj";
            this.labelWczoraj.Size = new System.Drawing.Size(66, 20);
            this.labelWczoraj.TabIndex = 0;
            this.labelWczoraj.Text = "wczoraj:";
            // 
            // buttonPoprzedni
            // 
            this.buttonPoprzedni.Enabled = false;
            this.buttonPoprzedni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPoprzedni.Location = new System.Drawing.Point(32, 112);
            this.buttonPoprzedni.Name = "buttonPoprzedni";
            this.buttonPoprzedni.Size = new System.Drawing.Size(130, 23);
            this.buttonPoprzedni.TabIndex = 1;
            this.buttonPoprzedni.Text = "<< &poprzedni";
            this.buttonPoprzedni.UseVisualStyleBackColor = true;
            this.buttonPoprzedni.Click += new System.EventHandler(this.buttonPoprzedni_Click);
            // 
            // groupBoxDzisiaj
            // 
            this.groupBoxDzisiaj.Controls.Add(this.buttonKolorTła);
            this.groupBoxDzisiaj.Controls.Add(this.labelDzisiaj);
            this.groupBoxDzisiaj.Controls.Add(this.buttonBieżący);
            this.groupBoxDzisiaj.Location = new System.Drawing.Point(210, 6);
            this.groupBoxDzisiaj.Name = "groupBoxDzisiaj";
            this.groupBoxDzisiaj.Size = new System.Drawing.Size(200, 200);
            this.groupBoxDzisiaj.TabIndex = 0;
            this.groupBoxDzisiaj.TabStop = false;
            // 
            // buttonKolorTła
            // 
            this.buttonKolorTła.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKolorTła.Location = new System.Drawing.Point(32, 143);
            this.buttonKolorTła.Name = "buttonKolorTła";
            this.buttonKolorTła.Size = new System.Drawing.Size(130, 50);
            this.buttonKolorTła.TabIndex = 2;
            this.buttonKolorTła.Text = "Zmień kolor tła";
            this.buttonKolorTła.UseVisualStyleBackColor = true;
            this.buttonKolorTła.Click += new System.EventHandler(this.buttonKolorTła_Click);
            // 
            // labelDzisiaj
            // 
            this.labelDzisiaj.AutoSize = true;
            this.labelDzisiaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDzisiaj.Location = new System.Drawing.Point(6, 10);
            this.labelDzisiaj.MaximumSize = new System.Drawing.Size(180, 0);
            this.labelDzisiaj.Name = "labelDzisiaj";
            this.labelDzisiaj.Size = new System.Drawing.Size(56, 20);
            this.labelDzisiaj.TabIndex = 0;
            this.labelDzisiaj.Text = "dzisiaj:";
            // 
            // buttonBieżący
            // 
            this.buttonBieżący.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBieżący.Location = new System.Drawing.Point(32, 112);
            this.buttonBieżący.Name = "buttonBieżący";
            this.buttonBieżący.Size = new System.Drawing.Size(130, 23);
            this.buttonBieżący.TabIndex = 1;
            this.buttonBieżący.Text = "&bieżący";
            this.buttonBieżący.UseVisualStyleBackColor = true;
            this.buttonBieżący.Click += new System.EventHandler(this.buttonBieżący_Click);
            // 
            // groupBoxJutro
            // 
            this.groupBoxJutro.Controls.Add(this.buttonCzcionka);
            this.groupBoxJutro.Controls.Add(this.labelJutro);
            this.groupBoxJutro.Controls.Add(this.buttonNastępny);
            this.groupBoxJutro.Location = new System.Drawing.Point(415, 6);
            this.groupBoxJutro.Name = "groupBoxJutro";
            this.groupBoxJutro.Size = new System.Drawing.Size(200, 200);
            this.groupBoxJutro.TabIndex = 2;
            this.groupBoxJutro.TabStop = false;
            // 
            // buttonCzcionka
            // 
            this.buttonCzcionka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCzcionka.Location = new System.Drawing.Point(32, 143);
            this.buttonCzcionka.Name = "buttonCzcionka";
            this.buttonCzcionka.Size = new System.Drawing.Size(130, 50);
            this.buttonCzcionka.TabIndex = 2;
            this.buttonCzcionka.Text = "Zmień czcionkę etykiet";
            this.buttonCzcionka.UseVisualStyleBackColor = true;
            this.buttonCzcionka.Click += new System.EventHandler(this.buttonCzcionka_Click);
            // 
            // labelJutro
            // 
            this.labelJutro.AutoSize = true;
            this.labelJutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJutro.Location = new System.Drawing.Point(6, 10);
            this.labelJutro.MaximumSize = new System.Drawing.Size(180, 0);
            this.labelJutro.Name = "labelJutro";
            this.labelJutro.Size = new System.Drawing.Size(44, 20);
            this.labelJutro.TabIndex = 0;
            this.labelJutro.Text = "jutro:";
            // 
            // buttonNastępny
            // 
            this.buttonNastępny.Enabled = false;
            this.buttonNastępny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastępny.Location = new System.Drawing.Point(32, 112);
            this.buttonNastępny.Name = "buttonNastępny";
            this.buttonNastępny.Size = new System.Drawing.Size(130, 23);
            this.buttonNastępny.TabIndex = 1;
            this.buttonNastępny.Text = "&następny >>";
            this.buttonNastępny.UseVisualStyleBackColor = true;
            this.buttonNastępny.Click += new System.EventHandler(this.buttonNastępny_Click);
            // 
            // Zegar
            // 
            this.Zegar.Enabled = true;
            this.Zegar.Tick += new System.EventHandler(this.Zegar_Tick);
            // 
            // FormDatownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 209);
            this.Controls.Add(this.groupBoxDzisiaj);
            this.Controls.Add(this.groupBoxJutro);
            this.Controls.Add(this.groupBoxWczoraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDatownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxWczoraj.ResumeLayout(false);
            this.groupBoxWczoraj.PerformLayout();
            this.groupBoxDzisiaj.ResumeLayout(false);
            this.groupBoxDzisiaj.PerformLayout();
            this.groupBoxJutro.ResumeLayout(false);
            this.groupBoxJutro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWczoraj;
        private System.Windows.Forms.GroupBox groupBoxDzisiaj;
        private System.Windows.Forms.GroupBox groupBoxJutro;
        private System.Windows.Forms.Button buttonPoprzedni;
        private System.Windows.Forms.Label labelWczoraj;
        private System.Windows.Forms.Label labelDzisiaj;
        private System.Windows.Forms.Button buttonBieżący;
        private System.Windows.Forms.Label labelJutro;
        private System.Windows.Forms.Button buttonNastępny;
        private System.Windows.Forms.Button buttonKolorPierwszoplanowy;
        private System.Windows.Forms.Button buttonKolorTła;
        private System.Windows.Forms.Button buttonCzcionka;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer Zegar;

    }
}

