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
    public partial class PodaciOFilmu : Form
    {
        public PodaciOFilmu()
        {
            InitializeComponent();
        }

        public PodaciOFilmu(Film f)
            : this()
        {
            lblNaslov.Text = f.Naslov;
            lblRod.Text = f.Roditelj;
            lblOcena.Text = f.Ocena.ToString();
            lblDatum.Text = f.Premijera.ToShortDateString();
            lblZanr.Text = f.ZanrFilma.ToString();
            if (f.ZanrFilma != Film.Zanr.BAJKA)
                lblUzrast.Text = f.Uzrast.ToString();
            else
                lblUzrast.Text = string.Empty;
        }
    }
}
