using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Probni
{
    abstract class GeometrijskoTelo
    {
        public abstract double Zapremina { get; }

        // ako ima > mora da ima i < u c#-u
        public static bool operator >(GeometrijskoTelo a, GeometrijskoTelo b)
        {
            return a.Zapremina > b.Zapremina;
        }

        public static bool operator <(GeometrijskoTelo a, GeometrijskoTelo b)
        {
            return a.Zapremina < b.Zapremina;
        }
    }

    class Kvadar : GeometrijskoTelo
    {
        private double a, b, c;

        // predefinisan property Zapremina i dodati konstruktori
        public Kvadar(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Zapremina
        {
            get { return a * b * c; }
        }
    }

    class Valjak : GeometrijskoTelo
    {
        private double r, h;

        public Valjak(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public override double Zapremina
        {
            get { return r * r * Math.PI * h; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kvadar k = new Kvadar(1, 10, 3);
            Valjak v = new Valjak(1, 2);

            if (k > v)
                Console.WriteLine("Kvadar ima veću zapreminu");
            else if (k < v)
                Console.WriteLine("Valjak ima veću zapreminu");
            else
                Console.WriteLine("Zapremine su jednake");
        }
    }
}