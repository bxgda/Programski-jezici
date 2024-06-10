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
            Console.WriteLine(ZbirKorena(1, 2, 3, 4, 5));
        }

        public static double ZbirKorena(params int[] brojevi) {

            double zbir = 0.0;

            foreach (int broj in brojevi) {
                if (broj > 0)
                    zbir += Math.Sqrt(broj);
            }

            return zbir;
        }
    }
}