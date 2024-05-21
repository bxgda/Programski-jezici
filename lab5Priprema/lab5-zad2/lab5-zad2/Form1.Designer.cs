namespace lab5_zad2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblProizvodjac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTakt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudGB = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvođač:";
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.Location = new System.Drawing.Point(225, 28);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(195, 20);
            this.lblProizvodjac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Location = new System.Drawing.Point(225, 54);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(195, 20);
            this.lblNaziv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cena:";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(225, 81);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(195, 20);
            this.dtp.TabIndex = 7;
            // 
            // nudCena
            // 
            this.nudCena.Location = new System.Drawing.Point(225, 107);
            this.nudCena.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(195, 20);
            this.nudCena.TabIndex = 8;
            // 
            // cbVrsta
            // 
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Items.AddRange(new object[] {
            "Procesor",
            "Memorija"});
            this.cbVrsta.Location = new System.Drawing.Point(225, 134);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(195, 21);
            this.cbVrsta.TabIndex = 9;
            this.cbVrsta.SelectedIndexChanged += new System.EventHandler(this.cbVrsta_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrsta komponente:";
            // 
            // nudTakt
            // 
            this.nudTakt.DecimalPlaces = 1;
            this.nudTakt.Location = new System.Drawing.Point(225, 162);
            this.nudTakt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTakt.Name = "nudTakt";
            this.nudTakt.Size = new System.Drawing.Size(195, 20);
            this.nudTakt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Radni takt:";
            // 
            // nudGB
            // 
            this.nudGB.Location = new System.Drawing.Point(225, 189);
            this.nudGB.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudGB.Name = "nudGB";
            this.nudGB.Size = new System.Drawing.Size(195, 20);
            this.nudGB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kapcitet {GB}:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(185, 245);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 36);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 310);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(502, 121);
            this.lbLista.TabIndex = 16;
            this.lbLista.DoubleClick += new System.EventHandler(this.lbLista_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudGB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudTakt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.nudCena);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblProizvodjac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTakt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudGB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbLista;
    }
}

