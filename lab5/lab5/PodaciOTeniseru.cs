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
    public partial class PodaciOTeniseru : Form
    {
        public PodaciOTeniseru()
        {
            InitializeComponent();
        }

        public PodaciOTeniseru(Teniser t)
        {
            InitializeComponent();
            lblIme.Text = t.Ime;
            lblPrezime.Text = t.Prezime;
            lblRank.Text = t.Rank.ToString();
            lblDatum.Text = t.Datum.ToShortDateString();
            lblStil.Text = t.StilIgre.ToString();
            lblTitule.Text = t.Titule.ToString();
            if (t.Penzija)
                lblPenzija.Text = "penzionisan";
            else
                lblPenzija.Text = string.Empty;
        }
    }
}
