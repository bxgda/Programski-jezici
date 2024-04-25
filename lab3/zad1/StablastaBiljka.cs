using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3zad1
{
    internal class StablastaBiljka : Biljka
    {
        DateTime datumPresadjivanja;

        public StablastaBiljka()
            : base()
        {
            datumPresadjivanja = DateTime.Today;
            tipBiljke = Tip.STABLASTA;
        }

        public StablastaBiljka(string naziv, bool jeVisegodisnja, float kolicinaVode, DateTime datumPresadjivanja) 
            : base(naziv, jeVisegodisnja, kolicinaVode)
        {
            this.datumPresadjivanja = datumPresadjivanja;
            this.tipBiljke = Tip.STABLASTA;
        }

        public override float cenaOdrzavanja()
        {
            if (datumPresadjivanja.Date == DateTime.Today)
                return kolicinaVode * 100.0f + 2000.0f;
            return kolicinaVode * 100.0f;
        }

        public override void citaj(BinaryReader br)
        {
            base.citaj(br);
            datumPresadjivanja = DateTime.FromBinary(br.ReadInt64());
        }

        public override void upisiBinarno(BinaryWriter bw)
        {
            base.upisiBinarno(bw);
            bw.Write(datumPresadjivanja.ToBinary());
        }

        public override void stampajNaKonzolu()
        {
            base.stampajNaKonzolu();
            Console.WriteLine("datum presadjivanja: " + datumPresadjivanja.Date.ToString("dd/MM/yyyy"));
            Console.WriteLine();
        }
    }
}
