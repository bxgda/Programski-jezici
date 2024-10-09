using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    internal class StablastaBiljka : Biljka
    {
        private DateTime datumSledecegPresadjivanja;

        public StablastaBiljka()
            : base()
        {
            datumSledecegPresadjivanja = DateTime.Today;
            tipBiljke = Tip.STABLASTA;
        }

        public StablastaBiljka(string naziv, bool jeVisegodisnja, float kolicinaVode, DateTime datumSledecegPresadjivanja)
            : base(naziv, jeVisegodisnja, kolicinaVode)
        {
            this.datumSledecegPresadjivanja = datumSledecegPresadjivanja;
            tipBiljke = Tip.STABLASTA;
        }

        public override float CenaOdrzavanja()
        {
            if (datumSledecegPresadjivanja == DateTime.Today)
                return kolicinaVode * 100.0f + 2000.0f;
            return kolicinaVode * 100.0f;
        }

        public override void UpisiBinarno(BinaryWriter bw)
        {
            base.UpisiBinarno(bw);
            bw.Write(datumSledecegPresadjivanja.ToBinary());
        }

        public override void CitajBinarno(BinaryReader br)
        {
            base.CitajBinarno(br);
            datumSledecegPresadjivanja = DateTime.FromBinary(br.ReadInt64());
        }

        public override void StampajNaEkran()
        {
            base.StampajNaEkran();
            Console.WriteLine($"datum sledeceg presadjivanja je: {datumSledecegPresadjivanja}\ncena odrzavanja: {CenaOdrzavanja()}\n");
        }
    }
}
