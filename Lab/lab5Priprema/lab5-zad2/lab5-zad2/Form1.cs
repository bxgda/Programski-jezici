using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_zad2
{
    public partial class Form1 : Form
    {
        List<Komponenta> lista;
        
        public Form1()
        {
            InitializeComponent();
            lista = new List<Komponenta>();
        }

        private void cbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVrsta.SelectedItem.ToString() == "Procesor")
            {
                nudGB.Enabled = false;
                nudGB.Value = 0;
            }
            else
                nudGB.Enabled = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Komponenta k = new Komponenta();
            NapraviKomp(k);
            lista.Add(k);
            PrikaziListu();
        }

        private void PrikaziListu()
        {
            lbLista.Items.Clear();
            lbLista.Items.AddRange(lista.ToArray());
        }

        private void NapraviKomp(Komponenta k)
        {
            k.Proizvodjac = lblProizvodjac.Text;
            k.Naziv = lblNaziv.Text;
            k.Datum = dtp.Value;
            k.Cena = (float)nudCena.Value;
            switch (cbVrsta.SelectedItem.ToString())
            {
                case "Procesor":
                    k.Komp = Komponenta.Vrsta.PROCESOR;
                    break;
                case "Memorija":
                    k.Komp = Komponenta.Vrsta.MEMORIJA;
                    break;
                default:
                    break;
            }
            k.Takt = (float)nudTakt.Value;
            k.Kapacitet = (float)nudGB.Value;
        }

        private void lbLista_DoubleClick(object sender, EventArgs e)
        {
            if (lbLista.SelectedIndex != -1)
            {
                Komponenta k = lista[lbLista.SelectedIndex];
                lblProizvodjac.Text = k.Proizvodjac;
                lblNaziv.Text = k.Naziv;
                dtp.Value = k.Datum;
                if (k.Komp == Komponenta.Vrsta.PROCESOR)
                    cbVrsta.SelectedIndex = 0;
                if (k.Komp == Komponenta.Vrsta.MEMORIJA)
                    cbVrsta.SelectedIndex = 1;
                nudTakt.Value = (decimal)k.Takt;
                nudGB.Value = (decimal)k.Kapacitet;
            }
        }
    }
}
