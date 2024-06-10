using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Probni
{
    public class Radnik
    {
        public long Jmbg { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public double Plata { get; set; }

        public Radnik() { }

        public Radnik(long jmbg, string ime, string prezime, double plata)
        {
            Jmbg = jmbg;
            Ime = ime;
            Prezime = prezime;
            Plata = plata;
        }

        public static Dictionary<long, Radnik> ProcitajFajl(string putanjaDoFajla)
        {
            Dictionary<long, Radnik> radnici = new Dictionary<long, Radnik>();

            using (StreamReader sr = new StreamReader(new FileStream(putanjaDoFajla, FileMode.Open)))
            {
                while (!sr.EndOfStream)
                {
                    Radnik r = new Radnik();
                    r.Jmbg = long.Parse(sr.ReadLine());
                    r.Ime = sr.ReadLine();
                    r.Prezime = sr.ReadLine();
                    r.Plata = double.Parse(sr.ReadLine());

                    if (!radnici.ContainsKey(r.Jmbg))
                        radnici.Add(r.Jmbg, r);

                    // razdi i ovako jer su ovo indekseri i svaki put samo setuje opet r iako ga ima vec
                    // radnici[r.Jmbg] = r;
                }
            }

            return radnici;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, Radnik> radnici = Radnik.ProcitajFajl("radnici.txt");

            foreach (var radnik in radnici)
            {
                Console.WriteLine(radnik.Value.Ime + " " + radnik.Value.Prezime + " " + radnik.Value.Plata);
            }
        }
    }
}