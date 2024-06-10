using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Probni
{
    interface IMatrica
    {
        double this[int i, int j] { get; set; }
        int BrojVrsta { get; }
        int BrojKolona { get; }
    }

    class Matrica : IMatrica
    {
        private double[,] mat;

        public Matrica(int r, int c)
        {
            mat = new double[r, c];
        }

        public static Matrica operator+(Matrica a, Matrica b)
        {
            if (a.BrojVrsta != b.BrojVrsta || a.BrojKolona != b.BrojKolona)
                return new Matrica(0, 0);

            Matrica rez = new Matrica(a.BrojVrsta, a.BrojKolona);
            for (int i = 0; i < a.BrojVrsta; i++)
                for (int j = 0; j < a.BrojKolona; j++)
                    rez[i, j] = a[i, j] + b[i, j];

            return rez;
        }

        public double this[int i, int j]
        {
            get {
                return mat[i, j];
            }
            set {
                mat[i, j] = value;
            }
        }

        public int BrojVrsta { get { return mat.GetLength(0); } }
        public int BrojKolona { get { return mat.GetLength(1); } }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Matrica a = new Matrica(2, 2);
            Matrica b = new Matrica(2, 2);
            a[0, 0] = b[0, 0] = 0;
            a[0, 1] = b[0, 1] = 1;
            a[1, 0] = b[1, 0] = 2;
            a[1, 1] = b[1, 1] = 3;
            Matrica c = a + b;
            for (int i = 0; i < c.BrojVrsta; i++)
            {
                for (int j = 0; j < c.BrojKolona; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}