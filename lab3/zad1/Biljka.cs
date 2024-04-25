using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3zad1
{
    internal abstract class Biljka : IComparable<Biljka>
    {
        public enum Tip
        {
            SAKSIJSKA, STABLASTA
        }

        private string naziv;
        protected bool jeVisegodisnja;     // 0 jednogodisnja, 1 visegodisnja
        protected float kolicinaVode;
        protected Tip tipBiljke;

        public Tip TipBiljke { get { return tipBiljke; } }

        public bool JeVisegodisnja { get { return jeVisegodisnja; } }

        protected Biljka()
        {
            naziv = "";
            jeVisegodisnja = false;
            kolicinaVode = 0;
        }

        protected Biljka(string naziv, bool jeVisegodisnja, float kolicinaVode)
        {
            this.naziv = naziv;
            this.jeVisegodisnja = jeVisegodisnja;
            this.kolicinaVode = kolicinaVode;
        }

        public abstract float cenaOdrzavanja();

        public virtual void upisiBinarno(BinaryWriter bw)
        {
            bw.Write((byte)tipBiljke);
            bw.Write(naziv);
            bw.Write(jeVisegodisnja);
            bw.Write(kolicinaVode);
        }

        public virtual void citaj(BinaryReader br)
        {
            naziv = br.ReadString();
            jeVisegodisnja = br.ReadBoolean();
            kolicinaVode = br.ReadSingle();
        }

        public int CompareTo(Biljka? other)
        {
            if (other == null) return 0;
            if (this.kolicinaVode < other.kolicinaVode) return 1;
            else if (this.kolicinaVode == other.kolicinaVode) return 0;
            else return -1;
        }

        public virtual void stampajNaKonzolu()
        {
            Console.WriteLine("naziv: " + naziv + ", jeVisegodisnja: " +  jeVisegodisnja + ", kolicinaVode: " + kolicinaVode + ", cena odrzavanja: " + cenaOdrzavanja());
        }
    }
}
