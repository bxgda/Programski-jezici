using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_19059
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizija t1 = new Televizija("RTS", 50000.0f);

            Emisija s1 = new Serija("GOT", 8.8f, Emisija.Dan.NEDELJA, 20, 50000, false);
            Emisija s2 = new Serija("Vratice se rode", 2.8f, Emisija.Dan.SUBOTA, 15, 60000, true);
            Emisija s3 = new Serija("Peaky Blinders", 10.0f, Emisija.Dan.PETAK, 20, 100000, false);

            Emisija st1 = new StudijskaEmisija("Slagalica", 9.5f, Emisija.Dan.UTORAK, 10000, 2, 5000);
            Emisija st2 = new StudijskaEmisija("Vece sa Ivanom", 6.8f, Emisija.Dan.SREDA, 15000, 20, 1000);
            Emisija st3 = new StudijskaEmisija("AmiG show", 3.2f, Emisija.Dan.CETVRTAK, 8000, 15, 1500);

            t1.UbaciEmisiju(s1);
            t1.UbaciEmisiju(s2);
            t1.UbaciEmisiju(s3);
            t1.UbaciEmisiju(st1);
            t1.UbaciEmisiju(st2);
            t1.UbaciEmisiju(st3);

            t1.TVNaKonzolu();

            Console.WriteLine("-------------------------------");

            t1.IzbaciPoGledanosti();
            t1.TVNaKonzolu();

            Console.WriteLine("-------------------------------");

            t1.SortirajPoDanima();
            t1.TVNaKonzolu();

            Console.WriteLine("-------------------------------");

            t1.ProveriRaspored();
        }
    }
}
