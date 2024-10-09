using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab5_zad1.Automobil;

namespace lab5_zad1
{
    internal class Automobil
    {
        public enum Gorivo
        {
            BENZIN,
            DIZEL,
            GAS
        }

        private string proizvodjac;
        private string model;
        private float zapreminaMotora;
        private DateTime datumProizvodnje;
        private Gorivo vrstaGoriva;
        private bool atest;

        public string Proizvodjac {  get { return proizvodjac; } set { proizvodjac = value;} }
        public string Model { get { return model; } set { model = value; } }
        public float ZapreminaMotora { get { return zapreminaMotora; } set { zapreminaMotora = value; } }
        public DateTime DatumProizvodnje { get { return datumProizvodnje; } set {  datumProizvodnje = value; } }
        public Gorivo VrstaGoriva {  get { return vrstaGoriva; } set { vrstaGoriva = value; } }
        public bool Atest {  get { return atest; } set {  atest = value; } }

        public Automobil()
        {
            proizvodjac = string.Empty;
            model = string.Empty;
            zapreminaMotora = 0.0f;
            datumProizvodnje = DateTime.Today;
            vrstaGoriva = Gorivo.BENZIN;
            atest = false;
        }

        public Automobil(string proizvodjac, string model, float zapreminaMotora, DateTime datumProizvodnje, Gorivo vrstaGoriva, bool atest)
        {
            this.proizvodjac = proizvodjac;
            this.model = model;
            this.zapreminaMotora = zapreminaMotora;
            this.datumProizvodnje = datumProizvodnje;
            this.vrstaGoriva = vrstaGoriva;
            this.atest = atest;
        }

        public override string ToString()
        {
            if (!atest)
                return proizvodjac + " " + model + " " + zapreminaMotora + " " + datumProizvodnje.ToShortDateString() + " " + vrstaGoriva.ToString();
            else
                return proizvodjac + " " + model + " " + zapreminaMotora + " " + datumProizvodnje.ToShortDateString() + " " + vrstaGoriva.ToString() + " " + atest;
        }

        public void upisiTekstualno(StreamWriter sw)
        {
            sw.WriteLine($"{proizvodjac}\n{model}\n{zapreminaMotora}\n{datumProizvodnje}\n{vrstaGoriva}\n{atest}");
        }

        public static void upisiListu(string imeFajla, List<Automobil> lista)
        {
            using (StreamWriter sw = new StreamWriter(imeFajla))
            {
                sw.WriteLine(lista.Count);
                foreach (Automobil a in lista)
                    a.upisiTekstualno(sw);
            }
        }

        internal static List<Automobil> ucitajListu(string imeFajla)
        {
            List<Automobil> lista = new List<Automobil>();
            using (StreamReader sr = new StreamReader(imeFajla))
            {
                int n = int.Parse(sr.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Automobil a = new Automobil();
                    a.Ucitaj(sr);
                    lista.Add(a);
                }       
            }
            return lista;
        }

        private void Ucitaj(StreamReader sr)
        {
            proizvodjac = sr.ReadLine();
            model = sr.ReadLine();
            zapreminaMotora = float.Parse(sr.ReadLine());
            datumProizvodnje = DateTime.Parse(sr.ReadLine());
            string vrstaG = sr.ReadLine();
            if (vrstaG == "BENZIN")
                vrstaGoriva = Gorivo.BENZIN;
            if (vrstaG == "DIZEL")
                vrstaGoriva = Gorivo.DIZEL;
            if (vrstaG == "GAS")
                vrstaGoriva = Gorivo.GAS;
            atest = bool.Parse(sr.ReadLine());
        }
    }
}
