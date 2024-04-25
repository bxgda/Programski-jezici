using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab_Auto
{
    internal class EAuto : Auto
    {
        private double kolElekEnergije;
        private double cenaElekEnergije;
        private DateTime datumIstekaBaterije;

        public double KolElekEnergije { get { return this.kolElekEnergije; } set { this.kolElekEnergije = value; } }
        public double CenaElekEnergije { get { return this.cenaElekEnergije; } set { this.cenaElekEnergije = value; } }
        public DateTime DatumIstekaBaterije { get { return this.datumIstekaBaterije; } set { this.datumIstekaBaterije = value; } }

        public EAuto() : base() 
        {
            this.kolElekEnergije = this.cenaElekEnergije = 0;
            this.datumIstekaBaterije = DateTime.Now;
        }

        public EAuto(string naziv, int godProizvodnje, double kolElekEnergije, double cenaElekEnergije, DateTime datumIstekaBaterije) : base(naziv, godProizvodnje)
        {
            this.kolElekEnergije = kolElekEnergije;
            this.cenaElekEnergije = cenaElekEnergije;
            this.datumIstekaBaterije = datumIstekaBaterije;
        }

        public override double CenaKilometra()
        {
            int godina = DateTime.Now.Year;
            return (kolElekEnergije * cenaElekEnergije) * ((godina - godProizvodnje) * 0.05 + 1);
        }

        public override void CitajIzFajla(StreamReader sr)
        {
            base.CitajIzFajla(sr);
            string[] linija = sr.ReadLine().Split(',');
            kolElekEnergije = double.Parse(linija[0]);
            cenaElekEnergije = double.Parse(linija[1]);
            datumIstekaBaterije = DateTime.Parse(linija[2]);
        }

        public override void UpisiUFajl(StreamWriter sw)
        {
            base.UpisiUFajl(sw);
            sw.WriteLine(kolElekEnergije + ", " + cenaElekEnergije + ", " + datumIstekaBaterije.Date);
        }
    }
}
