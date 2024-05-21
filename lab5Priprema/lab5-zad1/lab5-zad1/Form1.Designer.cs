namespace lab5_zad1
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
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.txtBoxProizvodjac = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblZapremina = new System.Windows.Forms.Label();
            this.nudZapremina = new System.Windows.Forms.NumericUpDown();
            this.gbVrsta = new System.Windows.Forms.GroupBox();
            this.radbGas = new System.Windows.Forms.RadioButton();
            this.radbDizel = new System.Windows.Forms.RadioButton();
            this.radbBenzin = new System.Windows.Forms.RadioButton();
            this.checkbAtest = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listbAutomobili = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucitajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSnimi = new System.Windows.Forms.SaveFileDialog();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.openUcitaj = new System.Windows.Forms.OpenFileDialog();
            this.lblDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudZapremina)).BeginInit();
            this.gbVrsta.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(143, 54);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(64, 13);
            this.lblProizvodjac.TabIndex = 0;
            this.lblProizvodjac.Text = "Porizvođač:";
            // 
            // txtBoxProizvodjac
            // 
            this.txtBoxProizvodjac.Location = new System.Drawing.Point(221, 47);
            this.txtBoxProizvodjac.Name = "txtBoxProizvodjac";
            this.txtBoxProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProizvodjac.TabIndex = 1;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(221, 73);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModel.TabIndex = 2;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(167, 80);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model:";
            // 
            // lblZapremina
            // 
            this.lblZapremina.AutoSize = true;
            this.lblZapremina.Location = new System.Drawing.Point(112, 106);
            this.lblZapremina.Name = "lblZapremina";
            this.lblZapremina.Size = new System.Drawing.Size(95, 13);
            this.lblZapremina.TabIndex = 4;
            this.lblZapremina.Text = "Zapremina motora:";
            // 
            // nudZapremina
            // 
            this.nudZapremina.DecimalPlaces = 3;
            this.nudZapremina.Location = new System.Drawing.Point(222, 99);
            this.nudZapremina.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudZapremina.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudZapremina.Name = "nudZapremina";
            this.nudZapremina.Size = new System.Drawing.Size(99, 20);
            this.nudZapremina.TabIndex = 5;
            this.nudZapremina.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // gbVrsta
            // 
            this.gbVrsta.Controls.Add(this.radbGas);
            this.gbVrsta.Controls.Add(this.radbDizel);
            this.gbVrsta.Controls.Add(this.radbBenzin);
            this.gbVrsta.Location = new System.Drawing.Point(23, 196);
            this.gbVrsta.Name = "gbVrsta";
            this.gbVrsta.Size = new System.Drawing.Size(298, 45);
            this.gbVrsta.TabIndex = 6;
            this.gbVrsta.TabStop = false;
            this.gbVrsta.Text = "Vrsta Goriva";
            // 
            // radbGas
            // 
            this.radbGas.AutoSize = true;
            this.radbGas.Location = new System.Drawing.Point(227, 20);
            this.radbGas.Name = "radbGas";
            this.radbGas.Size = new System.Drawing.Size(44, 17);
            this.radbGas.TabIndex = 2;
            this.radbGas.TabStop = true;
            this.radbGas.Text = "Gas";
            this.radbGas.UseVisualStyleBackColor = true;
            this.radbGas.CheckedChanged += new System.EventHandler(this.radbGas_CheckedChanged);
            // 
            // radbDizel
            // 
            this.radbDizel.AutoSize = true;
            this.radbDizel.Location = new System.Drawing.Point(122, 20);
            this.radbDizel.Name = "radbDizel";
            this.radbDizel.Size = new System.Drawing.Size(48, 17);
            this.radbDizel.TabIndex = 1;
            this.radbDizel.TabStop = true;
            this.radbDizel.Text = "Dizel";
            this.radbDizel.UseVisualStyleBackColor = true;
            // 
            // radbBenzin
            // 
            this.radbBenzin.AutoSize = true;
            this.radbBenzin.Location = new System.Drawing.Point(22, 20);
            this.radbBenzin.Name = "radbBenzin";
            this.radbBenzin.Size = new System.Drawing.Size(57, 17);
            this.radbBenzin.TabIndex = 0;
            this.radbBenzin.TabStop = true;
            this.radbBenzin.Text = "Benzin";
            this.radbBenzin.UseVisualStyleBackColor = true;
            // 
            // checkbAtest
            // 
            this.checkbAtest.AutoSize = true;
            this.checkbAtest.Location = new System.Drawing.Point(45, 262);
            this.checkbAtest.Name = "checkbAtest";
            this.checkbAtest.Size = new System.Drawing.Size(69, 17);
            this.checkbAtest.TabIndex = 7;
            this.checkbAtest.Text = "Ima atest";
            this.checkbAtest.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(45, 303);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listbAutomobili
            // 
            this.listbAutomobili.FormattingEnabled = true;
            this.listbAutomobili.Location = new System.Drawing.Point(23, 342);
            this.listbAutomobili.Name = "listbAutomobili";
            this.listbAutomobili.Size = new System.Drawing.Size(298, 82);
            this.listbAutomobili.TabIndex = 9;
            this.listbAutomobili.DoubleClick += new System.EventHandler(this.listbAutomobili_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snimiToolStripMenuItem,
            this.ucitajToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlToolStripMenuItem.Text = "Fajl";
            // 
            // snimiToolStripMenuItem
            // 
            this.snimiToolStripMenuItem.Name = "snimiToolStripMenuItem";
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.snimiToolStripMenuItem.Text = "Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.snimiToolStripMenuItem_Click);
            // 
            // ucitajToolStripMenuItem
            // 
            this.ucitajToolStripMenuItem.Name = "ucitajToolStripMenuItem";
            this.ucitajToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ucitajToolStripMenuItem.Text = "Ucitaj";
            this.ucitajToolStripMenuItem.Click += new System.EventHandler(this.ucitajToolStripMenuItem_Click);
            // 
            // saveSnimi
            // 
            this.saveSnimi.Filter = "Text file|*.txt";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(221, 125);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(100, 20);
            this.dtpDatum.TabIndex = 11;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(108, 131);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(98, 13);
            this.lblDatum.TabIndex = 12;
            this.lblDatum.Text = "Datum proizvodnje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.listbAutomobili);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.checkbAtest);
            this.Controls.Add(this.gbVrsta);
            this.Controls.Add(this.nudZapremina);
            this.Controls.Add(this.lblZapremina);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.txtBoxProizvodjac);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudZapremina)).EndInit();
            this.gbVrsta.ResumeLayout(false);
            this.gbVrsta.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.TextBox txtBoxProizvodjac;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblZapremina;
        private System.Windows.Forms.NumericUpDown nudZapremina;
        private System.Windows.Forms.GroupBox gbVrsta;
        private System.Windows.Forms.RadioButton radbDizel;
        private System.Windows.Forms.RadioButton radbBenzin;
        private System.Windows.Forms.RadioButton radbGas;
        private System.Windows.Forms.CheckBox checkbAtest;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listbAutomobili;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveSnimi;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ToolStripMenuItem ucitajToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openUcitaj;
        private System.Windows.Forms.Label lblDatum;
    }
}

