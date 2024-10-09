using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Teniser
    {
        public enum Stil
        {
            Baseline,
            Serve_and_volley,
            All_around,
            Defensive
        }
        
        private string ime;
        private string prezime;
        private int rank;
        private DateTime datum;
        private int titule;
        private Stil stilIgre;
        private bool penzija;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Rank { get => rank; set => rank = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Titule { get => titule; set => titule = value; }
        public Stil StilIgre { get => stilIgre; set => stilIgre = value; }
        public bool Penzija { get => penzija; set => penzija = value; }

        public override string ToString()
        {
            if (penzija)
                return ime + " " + prezime + " " + rank + " " + datum.ToShortDateString() + " " + titule + " " + stilIgre + " - penzionisan";
            return ime + " " + prezime + " " + rank + " " + datum.ToShortDateString() + " " + titule + " " + stilIgre;
        }
    }
}
