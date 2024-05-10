using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    internal class SaksijskaBiljka : Biljka
    {
        private float djubrivo;
        private float cenaPoKG;

        public SaksijskaBiljka()
            : base()
        {
            this.djubrivo = 0;
            this.cenaPoKG = 0;
            tipBiljke = Tip.SAKSIJSKA;
        }

        public SaksijskaBiljka(string naziv, bool jeVisegodisnja, float kolicinaVode, float djubrivo, float cenaPoKG)
            : base (naziv, jeVisegodisnja, kolicinaVode) 
        {
            this.djubrivo = djubrivo;
            this.cenaPoKG = cenaPoKG;
            tipBiljke = Tip.SAKSIJSKA;
        }

        public override float CenaOdrzavanja()
        {
            if(jeVisegodisnja)
                return (kolicinaVode * 10 + djubrivo * cenaPoKG) * 1.1f;
            return kolicinaVode * 10 + djubrivo * cenaPoKG;
        }

        public override void UpisiBinarno(BinaryWriter bw)
        {
            base.UpisiBinarno(bw);
            bw.Write(djubrivo);
            bw.Write(cenaPoKG);
        }

        public override void CitajBinarno(BinaryReader br)
        {
            base.CitajBinarno(br);
            djubrivo = br.ReadSingle();
            cenaPoKG = br.ReadSingle();
        }

        public override void StampajNaEkran()
        {
            base.StampajNaEkran();
            Console.WriteLine($"kolicina djubriva: {djubrivo}, cena po kg: {cenaPoKG}\ncena odrzavanja: {CenaOdrzavanja()}\n");
        }
    }
}
