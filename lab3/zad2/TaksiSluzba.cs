using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab_Auto
{
    internal class TaksiSluzba
    {
        private string naziv;
        private int predjeniKilometri;
        private int naplacenaCena;
        private List<Auto> vozila;

        public string Naziv { get; set; }
        public int Predjenikilometri { get; set; }
        public int NaplacenaCena { get; set; }

        public TaksiSluzba()
        {
            naziv = string.Empty;
            predjeniKilometri = 0;
            naplacenaCena = 0;
            vozila = new List<Auto>();
        }

        public TaksiSluzba(string naziv, int predjeniKilometri, int naplacenaCena)
        {
            this.naziv = naziv;
            this.predjeniKilometri = predjeniKilometri;
            this.naplacenaCena = naplacenaCena;
            vozila = new List<Auto>(100);
        }

        public void dodajVozilo(Auto a)
        {
            vozila.Add(a);
        }

        public void izbaciPreskupaVozila()
        {
            double prosek = naplacenaCena / vozila.Count;
            foreach(Auto a in vozila)
            {
                if (a.CenaKilometra() > prosek)
                    vozila.Remove(a);
            }
        }

        public void sortGodina()
        {
            vozila.Sort((a1, a2) => a2.GodProizvodnje.CompareTo(a1.GodProizvodnje)); //opadajuce
            //for (int i = 0; i < vozila.Count() - 1; i++)
            //{
            //    for (int j = i + 1; j < vozila.Count(); j++)
            //    {
            //        if (vozila[j].GodProizvodnje > vozila[i].GodProizvodnje)
            //        {
            //            Auto temp = vozila[j];
            //            vozila[j] = vozila[i];
            //            vozila[i] = temp;
            //        }
            //    }
            //}
        }

        public void proveriBaterije()
        {
            foreach (EAuto a in vozila.OfType<EAuto>())
            {
                if (a.DatumIstekaBaterije <= DateTime.Now )
                    throw new PotencijalnaEksplozija("Rok trajanja baterije je istekao");
            }
        }

        public void upisi(string putanja)
        {
            using (StreamWriter sw = new StreamWriter(putanja))
            {
                sw.WriteLine("Naziv: {0}, {1}km, {2}din", naziv, predjeniKilometri, naplacenaCena);
                foreach (Auto a in vozila)
                {
                    a.UpisiUFajl(sw);
                    sw.WriteLine();
                }
            }
        }

        public void ucitaj(string putanja)
        {
            using (StreamReader sr = new StreamReader(putanja))
            {
                while (!sr.EndOfStream)
                {
                    Auto a;
                    string tip = sr.ReadLine();
                    if (tip == "EAuto")
                        a = new EAuto();
                    else if (tip == "AutoSUS")
                        a = new AutoSUS();
                    else
                        return;
                    a.CitajIzFajla(sr);
                    vozila.Add(a);
                }
            }
        }
    }
}
