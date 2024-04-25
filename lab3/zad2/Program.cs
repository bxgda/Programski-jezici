using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaksiSluzba ts = new TaksiSluzba("Prvi taxi", 5600, 430000);

            EAuto e1 = new EAuto("Tesla Model 3", 2022, 0.2, 30, new DateTime(2030, 12, 31));
            EAuto e2 = new EAuto("Nissan Leaf", 2021, 0.18, 30, new DateTime(2032, 6, 24));
            EAuto e3 = new EAuto("BMW i3", 2020, 0.25, 30, new DateTime(2025, 1, 5));

            AutoSUS s1 = new AutoSUS("Audi A4", 2019, 6.5, 192.8);
            AutoSUS s2 = new AutoSUS("BMW 5", 2018, 7.2, 180);
            AutoSUS s3 = new AutoSUS("Mercedes C-Class", 2020, 6.8, 180);

            ts.dodajVozilo(e1);
            ts.dodajVozilo(e2);
            ts.dodajVozilo(e3);
            ts.dodajVozilo(s1);
            ts.dodajVozilo(s2);
            ts.dodajVozilo(s3);

            ts.upisi("vozila1.txt");

            TaksiSluzba t = new TaksiSluzba("Eko taxi", 7000, 540000);
            t.ucitaj("vozila2.txt");
            t.izbaciPreskupaVozila();
            t.sortGodina();

            try
            {
                t.proveriBaterije();
            }
            catch (PotencijalnaEksplozija pe)
            {
                Console.WriteLine(pe.Message);
            }

            t.upisi("vozila3.txt");
        }
    }
}
