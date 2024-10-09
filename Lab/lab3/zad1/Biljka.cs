using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    internal abstract class Biljka : IComparable<Biljka>
    {
        public enum Tip
        {
            SAKSIJSKA,
            STABLASTA
        }

        protected string naziv;
        protected bool jeVisegodisnja;
        protected float kolicinaVode;
        protected Tip tipBiljke;

        public bool JeVisegodisnja
        {
            get
            {
                return jeVisegodisnja;
            }
        }

        protected Biljka()
        {
            this.naziv = string.Empty;
            this.jeVisegodisnja = false;
            this.kolicinaVode = 0;
        }

        protected Biljka(string naziv, bool jeVisegodisnja, float kolicinaVode)
        {
            this.naziv = naziv;
            this.jeVisegodisnja = jeVisegodisnja;
            this.kolicinaVode = kolicinaVode;
        }

        public abstract float CenaOdrzavanja();

        public virtual void UpisiBinarno(BinaryWriter bw)
        {
            bw.Write((byte)tipBiljke);
            bw.Write(naziv);
            bw.Write(jeVisegodisnja);
            bw.Write(kolicinaVode);
        }

        public virtual void CitajBinarno(BinaryReader br)
        {
            naziv = br.ReadString();
            jeVisegodisnja = br.ReadBoolean();
            kolicinaVode = br.ReadSingle();
        }

        public virtual void StampajNaEkran()
        {
            Console.WriteLine($"Naziv: {naziv}");
            if(jeVisegodisnja)
                Console.WriteLine("visegodisnja");
            else
                Console.WriteLine("jednogodisnja");
            Console.WriteLine($"kolicina vode: {kolicinaVode}, tip: {tipBiljke}");
        }

        public int CompareTo(Biljka other)
        {
            if (other == null) return 0;
            if (this.kolicinaVode < other.kolicinaVode) return 1;
            else if (this.kolicinaVode == other.kolicinaVode) return 0;
            else return -1;
        }
    }
}
