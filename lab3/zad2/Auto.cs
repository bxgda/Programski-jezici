using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    internal abstract class Auto : IComparable<Auto>
    {
        public enum Tip
        {
            SUS, EL
        }

        protected string naziv;
        protected int godina;
        protected Tip tipAuta;

        public Auto() 
        {
            naziv = string.Empty;
            godina = 0;
        }

        public Auto(string naziv, int godina)
        {
            this.naziv = naziv;
            this.godina = godina;
        }

        public abstract float CenaPoKM();

        public virtual void UpisUFajl(StreamWriter sw)
        {
            sw.WriteLine($"{tipAuta}\n{naziv}\n{godina}");
        }

        public virtual void CitanjeIzFajla(StreamReader sr)
        {
            naziv = sr.ReadLine();
            godina = int.Parse(sr.ReadLine());
        }

        public virtual void IspisNaEkran()
        {
            Console.WriteLine($"Naziv: {naziv}\nGodina: {godina}");
        }

        public int CompareTo(Auto other)
        {
            if (other == null) return 0;
            if (this.godina < other.godina) return 1;
            else if (this.godina == other.godina) return 0;
            else return -1;
        }
    }
}
