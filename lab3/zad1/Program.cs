namespace lab3zad1
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

            b1.dodajBiljku(biljka1);
            b1.dodajBiljku(biljka2);
            b1.dodajBiljku(biljka3);
            b1.dodajBiljku(biljka4);
            b1.dodajBiljku(biljka5);
            b1.dodajBiljku(biljka6);
            b1.dodajBiljku(biljka7);
            b1.dodajBiljku(biljka8);

            b1.stampaj();

            Console.WriteLine("--------------------------------------------------------\n");

            b1.upisiBinarno("podaci.bin");

            BotanickaBasta b2 = new BotanickaBasta();
            b2.citajBinarno("podaci.bin");
            b2.stampaj();

            Console.WriteLine("--------------------------------------------------------\n");


            b2.izbaciVisakBiljaka();
            b2.sortiraj();

            b2.stampaj();

            Console.WriteLine("--------------------------------------------------------\n");

            try
            {
                if(b2.proveriRaspored())
                    Console.WriteLine("Dobar raspored!\n");
            }
            catch(NedovoljnaRazovrsnost nr)
            {
                Console.WriteLine(nr.Message + "\n");
            }

            b2.stampaj();

            Console.WriteLine("--------------------------------------------------------\n");
        }
    }
}
