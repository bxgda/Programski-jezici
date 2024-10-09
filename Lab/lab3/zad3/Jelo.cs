using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    internal class Jelo : Stavka
    {
        public enum Kvalitet
        {
            PRIHVATLJIV, 
            DOBAR,      
            ODLICAN     
        }

        private float nabavnaCena;
        private Kvalitet kvalitetJela;

        public Jelo()
            : base()
        {
            nabavnaCena = 0;
            kvalitetJela = Kvalitet.PRIHVATLJIV;
            jeloPice = false;
        }

        public Jelo(string naziv, DateTime datum, bool jeVeganska, float nabavnaCena, Kvalitet kvalitetJela)
            : base(naziv, datum, jeVeganska)
        {
            this.nabavnaCena = nabavnaCena;
            this.kvalitetJela = kvalitetJela;
            jeloPice = false;
        }

        public override float VratiCenu()
        {
            float cena = 0;
            if (kvalitetJela == Kvalitet.ODLICAN)
                cena = nabavnaCena * 3;
            else if (kvalitetJela == Kvalitet.DOBAR)
                cena = nabavnaCena * 2;
            else if (kvalitetJela == Kvalitet.PRIHVATLJIV)
                cena = nabavnaCena;
            if (datum < DateTime.Today.AddDays(3))
                cena = cena * 0.8f;
            return cena;
        }

        public override void UpisiBinarno(BinaryWriter bw)
        {
            base.UpisiBinarno(bw);
            bw.Write(nabavnaCena);
            bw.Write((byte)kvalitetJela);
        }

        public override void CitajBinarno(BinaryReader br)
        {
            base.CitajBinarno(br);
            nabavnaCena = br.ReadSingle();
            kvalitetJela = (Kvalitet)br.ReadByte();
        }

        public override void IspisiNaEkran()
        {
            base.IspisiNaEkran();
            Console.WriteLine($"nabavna cena: {nabavnaCena}\nkvalitet jela: {kvalitetJela}\ncena: {VratiCenu()}\n");
        }
    }
}
