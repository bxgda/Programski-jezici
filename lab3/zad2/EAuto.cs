using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    internal class EAuto : Auto
    {
        private float kolicinaElEnergije;
        private float cenaPoKWH;
        private DateTime istekRokaBaterije;

        public DateTime IstekRokaBaterija { get { return this.istekRokaBaterije; } }

        public EAuto()
            : base()
        {
            kolicinaElEnergije = 0;
            cenaPoKWH = 0;
            istekRokaBaterije = DateTime.Today;
            tipAuta = Tip.EL;
        }

        public EAuto(string naziv, int godina, float kolicinaElEnergije, float cenaPoKWH, DateTime istekRokaBaterije)
            : base(naziv, godina)
        {
            this.kolicinaElEnergije = kolicinaElEnergije;
            this.cenaPoKWH = cenaPoKWH;
            this.istekRokaBaterije = istekRokaBaterije;
            tipAuta = Tip.EL;
        }

        public override float CenaPoKM()
        {
            float cena = kolicinaElEnergije * cenaPoKWH;
            int n = DateTime.Now.Year - godina;
            for (int i = 0; i < n; i++)
                cena *= 1.05f;
            return cena;
        }

        public override void UpisUFajl(StreamWriter sw)
        {
            base.UpisUFajl(sw);
            sw.WriteLine($"{kolicinaElEnergije}\n{cenaPoKWH}\n{istekRokaBaterije}");
        }

        public override void CitanjeIzFajla(StreamReader sr)
        {
            base.CitanjeIzFajla(sr);
            kolicinaElEnergije = float.Parse(sr.ReadLine());
            cenaPoKWH = float.Parse(sr.ReadLine());
            istekRokaBaterije = DateTime.Parse(sr.ReadLine());
        }

        public override void IspisNaEkran()
        {
            base.IspisNaEkran();
            Console.WriteLine($"kolicina el en: {kolicinaElEnergije}\ncena za kwh: {cenaPoKWH}" +
                $"\nistek baterije: {istekRokaBaterije.ToString("dd/MM/yyyy")}\ncena po km: {CenaPoKM()}\n");
        }
    }
}
