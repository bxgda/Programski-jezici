using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    internal abstract class Stavka
    {
        protected string naziv;
        protected DateTime datum;
        protected bool jeVeganska;
        protected bool jeloPice;    // jelo 0, pice 1

        public DateTime Datum{ get { return datum; } }
        public bool JeVeganska { get { return jeVeganska; } }

        public Stavka()
        {
            naziv = string.Empty;
            datum = DateTime.Today;
            jeVeganska = false;
        }

        public Stavka(string naziv, DateTime datum, bool jeVeganska)
        {
            this.naziv = naziv;
            this.datum = datum;
            this.jeVeganska = jeVeganska;
        }

        public abstract float VratiCenu();

        public virtual void UpisiBinarno(BinaryWriter bw)
        {
            bw.Write(jeloPice);
            bw.Write(naziv);
            bw.Write(datum.ToBinary());
            bw.Write(jeVeganska);
        }

        public virtual void CitajBinarno(BinaryReader br)
        {
            naziv = br.ReadString();
            datum = DateTime.FromBinary(br.ReadInt64());
            jeVeganska = br.ReadBoolean();
        }

        public virtual void IspisiNaEkran()
        {
            Console.WriteLine($"naziv: {naziv}\ndatum: {datum.ToString("dd/MM/yyyy")}\njeVeganska: {jeVeganska}");
        }
    }
}
