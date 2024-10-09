using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Komponenta
    {
        public enum Vrsta
        {
            PROCESOR,
            MEMORIJA
        }

        private string proizvodjac;
        private string naziv;
        private DateTime datum;
        private float cena;
        private Vrsta komp;
        private float takt;
        private float kapacitet;

        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public float Cena { get => cena; set => cena = value; }
        public float Takt { get => takt; set => takt = value; }
        public float Kapacitet { get => kapacitet; set => kapacitet = value; }
        public Vrsta Komp { get => komp; set => komp = value; }

        public Komponenta()
        {
            proizvodjac = string.Empty;
            naziv = string.Empty;
            datum = DateTime.Today;
            cena = 0;
            takt = 0;
            kapacitet = 0;
        }

        public Komponenta(string proizvodjac, string naziv, DateTime datum, float cena, Vrsta komp, float takt, float kapacitet)
        {
            this.proizvodjac = proizvodjac;
            this.naziv = naziv;
            this.datum = datum;
            this.cena = cena;
            this.Komp = komp;
            this.takt = takt;
            this.kapacitet = kapacitet;
        }

        public override string ToString()
        {
            return proizvodjac + " " + naziv + " " + datum.ToShortDateString() + " " + cena + " " + komp + " " + takt + " " + kapacitet;
        }
    }
}
