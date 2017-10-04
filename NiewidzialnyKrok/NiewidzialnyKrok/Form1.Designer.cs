namespace NiewidzialnyKrok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlusPierwszy = new System.Windows.Forms.Button();
            this.MinusPierwszy = new System.Windows.Forms.Button();
            this.PlusDrugi = new System.Windows.Forms.Button();
            this.MinusDrugi = new System.Windows.Forms.Button();
            this.MinusTrzeci = new System.Windows.Forms.Button();
            this.PlusTrzeci = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Zegar = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nieprzezroczystość: 100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(56, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Krok zmian: 10%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(56, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Krok Zegara: 1000ms";
            // 
            // PlusPierwszy
            // 
            this.PlusPierwszy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlusPierwszy.Location = new System.Drawing.Point(6, 19);
            this.PlusPierwszy.Name = "PlusPierwszy";
            this.PlusPierwszy.Size = new System.Drawing.Size(28, 33);
            this.PlusPierwszy.TabIndex = 0;
            this.PlusPierwszy.Text = "+\r\n&+";
            this.PlusPierwszy.UseVisualStyleBackColor = true;
            this.PlusPierwszy.Click += new System.EventHandler(this.PlusPierwszy_Click);
            // 
            // MinusPierwszy
            // 
            this.MinusPierwszy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinusPierwszy.Location = new System.Drawing.Point(6, 61);
            this.MinusPierwszy.Name = "MinusPierwszy";
            this.MinusPierwszy.Size = new System.Drawing.Size(28, 33);
            this.MinusPierwszy.TabIndex = 1;
            this.MinusPierwszy.Text = "-\r\n&-";
            this.MinusPierwszy.UseVisualStyleBackColor = true;
            this.MinusPierwszy.Click += new System.EventHandler(this.MinusPierwszy_Click);
            // 
            // PlusDrugi
            // 
            this.PlusDrugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlusDrugi.Location = new System.Drawing.Point(6, 19);
            this.PlusDrugi.Name = "PlusDrugi";
            this.PlusDrugi.Size = new System.Drawing.Size(28, 33);
            this.PlusDrugi.TabIndex = 0;
            this.PlusDrugi.Text = "+";
            this.PlusDrugi.UseVisualStyleBackColor = true;
            this.PlusDrugi.Click += new System.EventHandler(this.PlusDrugi_Click);
            // 
            // MinusDrugi
            // 
            this.MinusDrugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinusDrugi.Location = new System.Drawing.Point(6, 61);
            this.MinusDrugi.Name = "MinusDrugi";
            this.MinusDrugi.Size = new System.Drawing.Size(28, 33);
            this.MinusDrugi.TabIndex = 1;
            this.MinusDrugi.Text = "-";
            this.MinusDrugi.UseVisualStyleBackColor = true;
            this.MinusDrugi.Click += new System.EventHandler(this.MinusDrugi_Click);
            // 
            // MinusTrzeci
            // 
            this.MinusTrzeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinusTrzeci.Location = new System.Drawing.Point(6, 61);
            this.MinusTrzeci.Name = "MinusTrzeci";
            this.MinusTrzeci.Size = new System.Drawing.Size(28, 33);
            this.MinusTrzeci.TabIndex = 1;
            this.MinusTrzeci.Text = "-";
            this.MinusTrzeci.UseVisualStyleBackColor = true;
            this.MinusTrzeci.Click += new System.EventHandler(this.MinusTrzeci_Click);
            // 
            // PlusTrzeci
            // 
            this.PlusTrzeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlusTrzeci.Location = new System.Drawing.Point(6, 19);
            this.PlusTrzeci.Name = "PlusTrzeci";
            this.PlusTrzeci.Size = new System.Drawing.Size(28, 33);
            this.PlusTrzeci.TabIndex = 0;
            this.PlusTrzeci.Text = "+";
            this.PlusTrzeci.UseVisualStyleBackColor = true;
            this.PlusTrzeci.Click += new System.EventHandler(this.PlusTrzeci_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PlusPierwszy);
            this.groupBox1.Controls.Add(this.MinusPierwszy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieprzezroczystość";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PlusDrugi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.MinusDrugi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Krok przeroczystości";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MinusTrzeci);
            this.groupBox3.Controls.Add(this.PlusTrzeci);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Krok Zegara";
            // 
            // Zegar
            // 
            this.Zegar.Tick += new System.EventHandler(this.Zegar_Tick);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Image = global::NiewidzialnyKrok.Properties.Resources.clock_time_2__Kopiowanie___2_;
            this.Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start.Location = new System.Drawing.Point(290, 250);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(114, 75);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 342);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NiewidzialnyKrok";
            this.Shown += new System.EventHandler(this.FormAnimacja_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlusPierwszy;
        private System.Windows.Forms.Button MinusPierwszy;
        private System.Windows.Forms.Button PlusDrugi;
        private System.Windows.Forms.Button MinusDrugi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MinusTrzeci;
        private System.Windows.Forms.Button PlusTrzeci;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer Zegar;
    }
}

