using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Film
    {
        public enum Zanr
        {
            DRAMA,
            RATNI,
            HOROR,
            BAJKA
        }

        private string naslov;
        private string roditelj;
        private float ocena;
        private DateTime premijera;
        private Zanr zanrFilma;
        private int uzrast;

        public string Naslov { get { return naslov; } set { naslov = value; } }
        public string Roditelj { get { return roditelj; } set { roditelj = value; } }
        public float Ocena { get { return ocena; } set { ocena = value; } }
        public DateTime Premijera { get { return premijera; } set { premijera = value; } }
        public Zanr ZanrFilma { get { return zanrFilma; } set { zanrFilma = value; } }
        public int Uzrast { get { return uzrast; } set { uzrast = value; } }

        public Film()
        {
            naslov = string.Empty;
            roditelj = string.Empty;
            ocena = 0.0f;
            premijera = DateTime.Today;
            zanrFilma = Zanr.DRAMA;
            uzrast = 0;
        }

        public Film(string naslov, string roditelj, float ocena, DateTime premijera, Zanr zanrFilma, int uzrast)
        {
            this.naslov = naslov;
            this.roditelj = roditelj;
            this.ocena = ocena;
            this.premijera = premijera;
            this.zanrFilma = zanrFilma;
            this.uzrast = uzrast;
        }

        public override string ToString()
        {
            if (zanrFilma == Zanr.BAJKA)
                return naslov + " " + roditelj + " " + ocena + " " + premijera.ToShortDateString() + " " + zanrFilma;
            return naslov + " " + roditelj + " " + ocena + " " + premijera.ToShortDateString() + " " + zanrFilma + " " + uzrast;
        }
    }
}
