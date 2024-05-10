using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BotanickaBasta b1 = new BotanickaBasta("Jevremovac", 4, 3000.0f);

            Biljka biljka1 = new StablastaBiljka("Jabuka", true, 5.0f, new DateTime(2003, 5, 10));
            Biljka biljka2 = new StablastaBiljka("Kruska", false, 7.0f, new DateTime(2004, 7, 15));
            Biljka biljka3 = new StablastaBiljka("Aronija", true, 3.0f, new DateTime(2005, 11, 18));
            Biljka biljka4 = new StablastaBiljka("Tresnja", true, 12.0f, new DateTime(2006, 12, 20));
            Biljka biljka5 = new StablastaBiljka("Marela", false, 12.0f, DateTime.Today);

            Biljka biljka6 = new SaksijskaBiljka("Seflera", true, 10.0f, 1.0f, 500);
            Biljka biljka7 = new SaksijskaBiljka("kaktus", true, 1.0f, 0.0f, 200);
            Biljka biljka8 = new SaksijskaBiljka("Orhideja", false, 6.0f, 10.0f, 1000);

            b1.DodajBiljku(biljka1);
            b1.DodajBiljku(biljka2);
            b1.DodajBiljku(biljka3);
            b1.DodajBiljku(biljka4);
            b1.DodajBiljku(biljka5);
            b1.DodajBiljku(biljka6);
            b1.DodajBiljku(biljka7);
            b1.DodajBiljku(biljka8);

            b1.StampajNaKonzolu();

            Console.WriteLine("--------------------------------------------------------\n");

            b1.UpisiBinarno("podaci.bin");

            BotanickaBasta b2 = new BotanickaBasta();
            b2.CitajBinarno("podaci.bin");
            b2.StampajNaKonzolu();

            Console.WriteLine("--------------------------------------------------------\n");

            b1.IzbaciVisakBiljaka();
            b1.SortirajOpadajuce();

            b1.StampajNaKonzolu();

            Console.WriteLine("--------------------------------------------------------\n");

        }
    }
}
