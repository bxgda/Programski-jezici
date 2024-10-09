using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxiSluzba ts = new TaxiSluzba("Prvi taxi", 5600, 430000);

            EAuto e1 = new EAuto("Tesla Model 3", 2022, 0.2f, 30, new DateTime(2030, 12, 31));
            EAuto e2 = new EAuto("Nissan Leaf", 2021, 0.18f, 30, new DateTime(2032, 6, 24));
            EAuto e3 = new EAuto("BMW i3", 2020, 0.25f, 30, new DateTime(2025, 1, 5));

            AutoSUS s1 = new AutoSUS("Audi A4", 2019, 6.5f, 192.8f);
            AutoSUS s2 = new AutoSUS("BMW 5", 2018, 6.5f, 192.8f);
            AutoSUS s3 = new AutoSUS("Mercedes C-Class", 2020, 6.5f, 192.8f);

            ts.DodajAuto(e1);
            ts.DodajAuto(e2);
            ts.DodajAuto(e3);
            ts.DodajAuto(s1);
            ts.DodajAuto(s2);
            ts.DodajAuto(s3);

            ts.IspisNaEkran();

            Console.WriteLine("--------------------------------------------");

            ts.UpisiUFajl("vozila1.txt");

            TaxiSluzba t = new TaxiSluzba("Eko taxi", 7000, 540000);
            t.UcitajIzFajla("vozila1.txt");
            
            t.IzbaciPreskupaVozila();
           
            t.SortirajOpadajuce();

            t.IspisNaEkran();
            Console.WriteLine("--------------------------------------------");

            try
            {
                t.ProveriBaterije();
            }
            catch (PotencijalnaExplozija pe)
            {
                Console.WriteLine(pe.Message);
            }

            t.UpisiUFajl("vozila3.txt");

        }
    }
}
