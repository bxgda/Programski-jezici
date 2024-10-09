namespace lab5_zad3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtRod = new System.Windows.Forms.TextBox();
            this.nudOcena = new System.Windows.Forms.NumericUpDown();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboZanr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudUzrast = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzrast)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roditelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocena:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(213, 48);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(146, 20);
            this.txtNaslov.TabIndex = 3;
            // 
            // txtRod
            // 
            this.txtRod.Location = new System.Drawing.Point(213, 80);
            this.txtRod.Name = "txtRod";
            this.txtRod.Size = new System.Drawing.Size(146, 20);
            this.txtRod.TabIndex = 4;
            // 
            // nudOcena
            // 
            this.nudOcena.DecimalPlaces = 1;
            this.nudOcena.Location = new System.Drawing.Point(213, 106);
            this.nudOcena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOcena.Name = "nudOcena";
            this.nudOcena.Size = new System.Drawing.Size(146, 20);
            this.nudOcena.TabIndex = 5;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(213, 132);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(146, 20);
            this.dtp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum premijere:";
            // 
            // comboZanr
            // 
            this.comboZanr.FormattingEnabled = true;
            this.comboZanr.Items.AddRange(new object[] {
            "Drama",
            "Ratni",
            "Horor",
            "Bajka"});
            this.comboZanr.Location = new System.Drawing.Point(213, 158);
            this.comboZanr.Name = "comboZanr";
            this.comboZanr.Size = new System.Drawing.Size(146, 21);
            this.comboZanr.TabIndex = 8;
            this.comboZanr.SelectedIndexChanged += new System.EventHandler(this.comboZanr_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Žanr:";
            // 
            // nudUzrast
            // 
            this.nudUzrast.Location = new System.Drawing.Point(213, 186);
            this.nudUzrast.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudUzrast.Name = "nudUzrast";
            this.nudUzrast.Size = new System.Drawing.Size(146, 20);
            this.nudUzrast.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Min. uzrast:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(177, 231);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(114, 44);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 291);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(459, 147);
            this.lbLista.TabIndex = 13;
            this.lbLista.DoubleClick += new System.EventHandler(this.lbLista_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudUzrast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboZanr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.nudOcena);
            this.Controls.Add(this.txtRod);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtRod;
        private System.Windows.Forms.NumericUpDown nudOcena;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboZanr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudUzrast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbLista;
    }
}

