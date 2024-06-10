using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Probni
{
    class Program
    {
        static void Main(string[] args)
        {
            CitajIspisi();
        }

        public static void CitajIspisi() {

            using (StreamReader sr = new StreamReader("Ulaz.txt")) // using regulise zatvaranje fajla
            {
                while (!sr.EndOfStream)
                {
                    string linija = sr.ReadLine();

                    if (linija.Contains("stop"))
                        break;
                    
                    Console.WriteLine(linija);
                }
            }
        }
    }
}