using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab_Auto
{
    internal class AutoSUS : Auto
    {
        private double potrosnjaGoriva;
        private double cenaGoriva;

        public double PotrosnjaGoriva { get { return this.potrosnjaGoriva; } set { this.potrosnjaGoriva = value; } }
        public double CenaGoriva { get { return this.cenaGoriva; } set { this.cenaGoriva = value; } }

        public AutoSUS() : base()
        {
            potrosnjaGoriva = cenaGoriva = 0;
        }

        public AutoSUS(string naziv, int godProizvodnje, double potrosnjaGoriva, double cenaGoriva) : base(naziv, godProizvodnje)
        {
            this.potrosnjaGoriva = potrosnjaGoriva;
            this.cenaGoriva = cenaGoriva;
        }

        public override double CenaKilometra()
        {
            int godina = DateTime.Now.Year;
            return cenaGoriva * potrosnjaGoriva + (1 + 0.1 * (godina - godProizvodnje));
        }

        public override void CitajIzFajla(StreamReader sr)
        {
            base.CitajIzFajla(sr);
            string[] linija = sr.ReadLine().Split(',');
            potrosnjaGoriva = double.Parse(linija[0]);
            cenaGoriva = double.Parse(linija[1]);
        }

        public override void UpisiUFajl(StreamWriter sw)
        {
            base.UpisiUFajl(sw);
            sw.WriteLine(potrosnjaGoriva + ", " + cenaGoriva);
        }
    }
}
