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

namespace lab5_zad3
{
    public partial class Form1 : Form
    {
        List<Film> lista;
        
        public Form1()
        {
            InitializeComponent();
            lista = new List<Film>();
        }

        private void comboZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboZanr.SelectedItem.ToString() == "Bajka")
            {
                nudUzrast.Enabled = false;
                nudUzrast.Value = 0;
            }
            else
                nudUzrast.Enabled = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            NapraviFilm(f);
            lista.Add(f);
            PrikaziListu();
            ResetKontrole();
        }

        private void ResetKontrole()
        {
            txtNaslov.Text = string.Empty;
            txtRod.Text = string.Empty;
            nudOcena.Value = (decimal)0;
            dtp.Value = DateTime.Today;
            comboZanr.SelectedIndex = 0;
            nudUzrast.Value = 0;
            txtNaslov.Focus();
        }

        private void PrikaziListu()
        {
            lbLista.Items.Clear();
            lbLista.Items.AddRange(lista.ToArray());
        }

        private void NapraviFilm(Film f)
        {
            f.Naslov = txtNaslov.Text;
            f.Roditelj = txtRod.Text;
            f.Ocena = (float)nudOcena.Value;
            f.Premijera = dtp.Value;
            switch (comboZanr.SelectedItem.ToString())
            {
                case "Drama":
                    f.ZanrFilma = Film.Zanr.DRAMA;
                    break;
                case "Ratni":
                    f.ZanrFilma = Film.Zanr.RATNI;
                    break;
                case "Horor":
                    f.ZanrFilma = Film.Zanr.HOROR;
                    break;
                case "Bajka":
                    f.ZanrFilma = Film.Zanr.BAJKA;
                    break;
                default:
                    break;
            }
            f.Uzrast = (int)nudUzrast.Value;
        }

        private void lbLista_DoubleClick(object sender, EventArgs e)
        {
            Film f = (Film)lbLista.SelectedItem;
            PodaciOFilmu podaci = new PodaciOFilmu(f);
            podaci.ShowDialog();
        }
    }
}
