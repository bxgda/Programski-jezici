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

namespace lab5
{
    public partial class Form1 : Form
    {
        List<Teniser> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Teniser>();
            cbStil.Items.Add(Teniser.Stil.Baseline);
            cbStil.Items.Add(Teniser.Stil.Serve_and_volley);
            cbStil.Items.Add(Teniser.Stil.All_around);
            cbStil.Items.Add(Teniser.Stil.Defensive);
            lblGreska.Text = string.Empty;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (PostojiRank((int)nudRank.Value))
            {
                lblGreska.Text = "Teniser sa zadatim rankingom vec postoji!";
            }
            else
            {
                Teniser t = new Teniser();
                NapraviTenisera(t);
                lista.Add(t);
                PrikaziListu();
                lblGreska.Text = string.Empty;
            }
        }

        private bool PostojiRank(int rank)
        {
            foreach (var t in lista)
                if (t.Rank == rank)
                    return true;
            return false;
        }

        private void PrikaziListu()
        {
            lbLista.Items.Clear();
            lbLista.Items.AddRange(lista.ToArray());
        }

        private void NapraviTenisera(Teniser t)
        {
            t.Ime = tbIme.Text;
            t.Prezime = tbPrezime.Text;
            if (cbPenzija.Checked)
                t.Rank = 0;
            else
                t.Rank = (int)nudRank.Value;
            t.Datum = dtp.Value;
            t.Titule = (int)nudTitule.Value;
            t.StilIgre = (Teniser.Stil)cbStil.SelectedItem;
            t.Penzija = cbPenzija.Checked;
        }

        private void lbLista_DoubleClick(object sender, EventArgs e)
        {
            Teniser t = (Teniser)lbLista.SelectedItem;
            PodaciOTeniseru forma1 = new PodaciOTeniseru(t);
            forma1.ShowDialog();
        }

        private void cbPenzija_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPenzija.Checked)
                nudRank.Enabled = false;
            else
                nudRank.Enabled = true;
        }
    }
}
