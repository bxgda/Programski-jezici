using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restoran r = new Restoran("restoran");
            r.DodajStavku(new Jelo("jelo1", new DateTime(2025, 5, 10), true, 100, Jelo.Kvalitet.PRIHVATLJIV));
            r.DodajStavku(new Jelo("jelo2", new DateTime(2025, 5, 10), false, 200, Jelo.Kvalitet.DOBAR));
            r.DodajStavku(new Jelo("jelo3", new DateTime(2025, 5, 10), true, 300, Jelo.Kvalitet.ODLICAN));
            r.DodajStavku(new Jelo("jelo4", new DateTime(2025, 5, 10), false, 400, Jelo.Kvalitet.PRIHVATLJIV));
            r.DodajStavku(new Pice("pice1", new DateTime(2025, 5, 10), true, 0.5f, 100, true));
            r.DodajStavku(new Pice("pice2", new DateTime(2025, 5, 10), false, 1, 200, false));
            r.DodajStavku(new Pice("pice3", new DateTime(2025, 5, 10), true, 1.5f, 300, true));
            r.DodajStavku(new Pice("pice4", new DateTime(2022, 5, 10), false, 2, 400, false));

            r.NaEkran();

            Console.WriteLine("---------------------------------");

            r.SortirajRastuce();

            r.NaEkran();

            Console.WriteLine("---------------------------------");

            Restoran r2 = new Restoran("restoran2");

            r.UFajlBinarni("restoran.bin");

            r2.IzFajlaBinarnog("restoran.bin");

            r2.NaEkran();

            Console.WriteLine("---------------------------------");

            r2.JelImaVegansko();

            Console.WriteLine("---------------------------------");

            r2.IzbaciIstekaoRokTrajanja();

            r2.NaEkran();

            Console.WriteLine("---------------------------------");
        }
    }
}
