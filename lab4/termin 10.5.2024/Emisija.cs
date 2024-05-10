using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_19059
{
    internal abstract class Emisija
    {
        public enum Dan
        {
            PONEDELJAK,
            UTORAK,
            SREDA,
            CETVRTAK,
            PETAK,
            SUBOTA,
            NEDELJA
        }

        protected string naziv;
        protected float gledanost;
        protected Dan danPrikazivanja;

        public float Gledanost {get{ return gledanost; } }
        public Dan DanPrikazivanja { get { return danPrikazivanja; } }

        public Emisija()
        {
            naziv = string.Empty;
            gledanost = 0.0f;
            danPrikazivanja = Dan.PONEDELJAK;
        }

        public Emisija(string naziv, float gledanost, Dan danPrikazivanja)
        {
            this.naziv = naziv;
            if (gledanost >= 0.0f && gledanost <= 10.0f)
                this.gledanost = gledanost;
            else
                this.gledanost = 0.0f;
            this.danPrikazivanja = danPrikazivanja;
        }

        public abstract float CenaEmisije();

        public virtual void UpisiUFajl(StreamWriter sw)
        {
            sw.WriteLine($"naziv: {naziv}\ngledanost: {gledanost}\ndan prikazivanja: {danPrikazivanja}\n");
        }

        public virtual void NaEkran()
        {
            Console.WriteLine($"naziv: {naziv}\ngledanost: {gledanost}\ndan prikazivanja: {danPrikazivanja}");
        }
    }
}
