using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    internal class AutoSUS : Auto
    {
        private float potrosnja;
        private float cenaGoriva;

        public AutoSUS()
            : base()
        {
            potrosnja = 0;
            cenaGoriva = 0;
            tipAuta = Tip.SUS;
        }

        public AutoSUS(string naziv, int godina, float potrosnja, float cenaGoriva)
            : base(naziv, godina)
        {
            this.potrosnja = potrosnja;
            this.cenaGoriva = cenaGoriva;
            tipAuta = Tip.SUS;
        }

        public override float CenaPoKM()
        {
            float cena = potrosnja * cenaGoriva;
            int n = DateTime.Now.Year - godina;
            for (int i = 0; i < n; i++)
                cena *= 1.1f;
            return cena;
        }

        public override void UpisUFajl(StreamWriter sw)
        {
            base.UpisUFajl(sw);
            sw.WriteLine($"{potrosnja}\n{cenaGoriva}");
        }

        public override void CitanjeIzFajla(StreamReader sr)
        {
            base.CitanjeIzFajla(sr);
            potrosnja = float.Parse(sr.ReadLine());
            cenaGoriva = float.Parse(sr.ReadLine());
        }

        public override void IspisNaEkran()
        {
            base.IspisNaEkran();
            Console.WriteLine($"potrosnja: {potrosnja}\ncena goriva: {cenaGoriva}\ncena po km: {CenaPoKM()}\n");
        }
    }
}
