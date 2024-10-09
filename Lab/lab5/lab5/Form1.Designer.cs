
namespace lab5
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRank = new System.Windows.Forms.NumericUpDown();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTitule = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPenzija = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.lblGreska = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTitule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(211, 27);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(162, 20);
            this.tbIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(211, 53);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(162, 20);
            this.tbPrezime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ranking:";
            // 
            // nudRank
            // 
            this.nudRank.Location = new System.Drawing.Point(211, 80);
            this.nudRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRank.Name = "nudRank";
            this.nudRank.Size = new System.Drawing.Size(162, 20);
            this.nudRank.TabIndex = 6;
            this.nudRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(211, 107);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(162, 20);
            this.dtp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum rodjenja:";
            // 
            // nudTitule
            // 
            this.nudTitule.Location = new System.Drawing.Point(211, 134);
            this.nudTitule.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.nudTitule.Name = "nudTitule";
            this.nudTitule.Size = new System.Drawing.Size(162, 20);
            this.nudTitule.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj titula:";
            // 
            // cbStil
            // 
            this.cbStil.FormattingEnabled = true;
            this.cbStil.Location = new System.Drawing.Point(211, 161);
            this.cbStil.Name = "cbStil";
            this.cbStil.Size = new System.Drawing.Size(162, 21);
            this.cbStil.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stil igre:";
            // 
            // cbPenzija
            // 
            this.cbPenzija.AutoSize = true;
            this.cbPenzija.Location = new System.Drawing.Point(211, 198);
            this.cbPenzija.Name = "cbPenzija";
            this.cbPenzija.Size = new System.Drawing.Size(82, 17);
            this.cbPenzija.TabIndex = 13;
            this.cbPenzija.Text = "penzionisan";
            this.cbPenzija.UseVisualStyleBackColor = true;
            this.cbPenzija.CheckedChanged += new System.EventHandler(this.cbPenzija_CheckedChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(159, 221);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 30);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(13, 305);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(405, 134);
            this.lbLista.TabIndex = 15;
            this.lbLista.DoubleClick += new System.EventHandler(this.lbLista_DoubleClick);
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreska.Location = new System.Drawing.Point(129, 274);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(0, 13);
            this.lblGreska.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbPenzija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudTitule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.nudRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTitule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRank;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTitule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbPenzija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Label lblGreska;
    }
}

