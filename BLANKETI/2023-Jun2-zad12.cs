using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Probni
{
    public interface IMatrica
    {
        double this[int i, int j] { get; }
        int Dimenzija { get; }
    }

    public class DijagonalnaMatrica : IMatrica
    {
		 // dovoljno je samo niz da se pamti jer je matrica dijagonalna
        private double[] dijagonala;

        public DijagonalnaMatrica(int dim) {
            dijagonala = new double[dim];
            Random r = new Random();
            for (int i = 0; i < dim; i++) {
                dijagonala[i] = r.Next(1, 10);
            }            
        }

        public double this[int i, int j] {
            get {
				// samo ako su zatrazeni elementi sa dijagonale vrati validan element
                if (i == j) {
                    return dijagonala[i];
                }
				// za sve ostalo vrati nulu
                return 0;
            }
        }

        public int Dimenzija {
            get {
                return dijagonala.Length;
            }
        }
    }

    public class DonjetrougaonaMatrica : IMatrica
    {
        private double[,] matrica;

        public DonjetrougaonaMatrica(int dim) {
            matrica = new double[dim, dim];
            Random r = new Random();
            for (int i = 0; i < dim; i++)
                for (int j = 0; j < i; j++)
                    matrica[i, j] = r.Next(1, 10);       
        }

        public double this[int i, int j] {
            get {
                if (i >= j) { // sve ispod glavne dijagonale
                    return matrica[i, j];
                }
                return 0;
            }
        }

        public int Dimenzija {
            get {
                return matrica.GetLength(0);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMatrica m1 = new DijagonalnaMatrica(5);
            IMatrica m2 = new DonjetrougaonaMatrica(5);
            for (int i = 0; i < m1.Dimenzija; i++)
            {
                for (int j = 0; j < m1.Dimenzija; j++)
                    Console.Write(m1[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < m2.Dimenzija; i++)
            {
                for (int j = 0; j < m2.Dimenzija; j++)
                    Console.Write(m2[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}