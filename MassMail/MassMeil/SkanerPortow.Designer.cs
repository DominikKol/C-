namespace MassMeil
{
    partial class SkanerPortow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SkanStart = new System.Windows.Forms.Button();
            this.Host = new System.Windows.Forms.TextBox();
            this.StatusSkanu = new System.Windows.Forms.ProgressBar();
            this.Logtxt = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skanujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skanujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do:";
            // 
            // SkanStart
            // 
            this.SkanStart.Location = new System.Drawing.Point(20, 19);
            this.SkanStart.Name = "SkanStart";
            this.SkanStart.Size = new System.Drawing.Size(108, 43);
            this.SkanStart.TabIndex = 4;
            this.SkanStart.Text = "SkanStart";
            this.SkanStart.UseVisualStyleBackColor = true;
            this.SkanStart.Click += new System.EventHandler(this.SkanStart_Click);
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(44, 13);
            this.Host.MaxLength = 15;
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(95, 20);
            this.Host.TabIndex = 1;
            this.Host.Text = "192.168.1.1";
            this.Host.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Host_KeyPress);
            // 
            // StatusSkanu
            // 
            this.StatusSkanu.Location = new System.Drawing.Point(12, 305);
            this.StatusSkanu.Name = "StatusSkanu";
            this.StatusSkanu.Size = new System.Drawing.Size(598, 23);
            this.StatusSkanu.Step = 1;
            this.StatusSkanu.TabIndex = 8;
            // 
            // Logtxt
            // 
            this.Logtxt.Location = new System.Drawing.Point(166, 34);
            this.Logtxt.Multiline = true;
            this.Logtxt.Name = "Logtxt";
            this.Logtxt.ReadOnly = true;
            this.Logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Logtxt.Size = new System.Drawing.Size(440, 265);
            this.Logtxt.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(36, 61);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Host);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 42);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.SkanStart);
            this.groupBox3.Location = new System.Drawing.Point(12, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 118);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Wyczyść Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.skanujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // skanujToolStripMenuItem
            // 
            this.skanujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skanujToolStripMenuItem1,
            this.wyczyśToolStripMenuItem,
            this.wyjścieToolStripMenuItem1});
            this.skanujToolStripMenuItem.Name = "skanujToolStripMenuItem";
            this.skanujToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.skanujToolStripMenuItem.Text = "Skaner";
            // 
            // skanujToolStripMenuItem1
            // 
            this.skanujToolStripMenuItem1.Name = "skanujToolStripMenuItem1";
            this.skanujToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.skanujToolStripMenuItem1.Text = "Skanuj";
            this.skanujToolStripMenuItem1.Click += new System.EventHandler(this.skanujToolStripMenuItem1_Click);
            // 
            // wyczyśToolStripMenuItem
            // 
            this.wyczyśToolStripMenuItem.Name = "wyczyśToolStripMenuItem";
            this.wyczyśToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.wyczyśToolStripMenuItem.Text = "Wyczyść Log";
            this.wyczyśToolStripMenuItem.Click += new System.EventHandler(this.wyczyśToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem1
            // 
            this.wyjścieToolStripMenuItem1.Name = "wyjścieToolStripMenuItem1";
            this.wyjścieToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.wyjścieToolStripMenuItem1.Text = "Wyjście";
            this.wyjścieToolStripMenuItem1.Click += new System.EventHandler(this.wyjścieToolStripMenuItem1_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // SkanerPortow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StatusSkanu);
            this.Controls.Add(this.Logtxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SkanerPortow";
            this.Text = "SkanerPortow";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SkanStart;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.ProgressBar StatusSkanu;
        private System.Windows.Forms.TextBox Logtxt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skanujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skanujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wyczyśToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem1;
    }
}