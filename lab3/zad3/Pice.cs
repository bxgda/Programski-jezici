using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    internal class Pice : Stavka
    {
        private float kolicinaLitri;
        private float cenaPoLitru;
        private bool jeDomace;

        public Pice()
            : base()
        {
            kolicinaLitri = 0;
            cenaPoLitru = 0;
            jeDomace = false;
            jeloPice = true;
        }

        public Pice(string naziv, DateTime datum, bool jeVeganska, float kolicinaLitri, float cenaPoLitru, bool jeDomace)
            : base(naziv, datum, jeVeganska)
        {
            this.kolicinaLitri = kolicinaLitri;
            this.cenaPoLitru = cenaPoLitru;
            this.jeDomace = jeDomace;
            jeloPice = true;
        }

        public override float VratiCenu()
        {
            if (!jeDomace)
                return cenaPoLitru * kolicinaLitri * 1.3f;
            return cenaPoLitru * kolicinaLitri;
        }

        public override void UpisiBinarno(BinaryWriter bw)
        {
            base.UpisiBinarno(bw);
            bw.Write(kolicinaLitri);
            bw.Write(cenaPoLitru);
            bw.Write(jeDomace);
        }

        public override void CitajBinarno(BinaryReader br)
        {
            base.CitajBinarno(br);
            kolicinaLitri = br.ReadSingle();
            cenaPoLitru = br.ReadSingle();
            jeDomace = br.ReadBoolean();
        }

        public override void IspisiNaEkran()
        {
            base.IspisiNaEkran();
            Console.WriteLine($"kolicina litri: {kolicinaLitri}\ncena po litru: {cenaPoLitru}\njeDomace: {jeDomace}\n" +
                $"cena: {VratiCenu()}\n");
        }
    }
}
