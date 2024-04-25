using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab_Auto
{
    internal abstract class Auto
    {
        protected string naziv;
        protected int godProizvodnje;

        public string Naziv { get { return this.naziv; } set { this.naziv = value; } }
        public int GodProizvodnje { get { return this.godProizvodnje; } set { this.godProizvodnje = value; } }

        public Auto() 
        { 
            naziv = string.Empty;
            godProizvodnje = 0;
        }

        public Auto(string naziv, int godProizvodnje)
        {
            this.naziv = naziv;
            this.godProizvodnje = godProizvodnje;
        }

        public abstract double CenaKilometra();
        public virtual void UpisiUFajl(StreamWriter sw)
        {
            sw.WriteLine(naziv + ", " + godProizvodnje);
        }
        public virtual void CitajIzFajla(StreamReader sr)
        {
            string[] linija = sr.ReadLine().Split(',');
            naziv = linija[0];
            godProizvodnje = int.Parse(linija[1]);
        }
    }
}
