using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab3_2.Auto;

namespace lab3_2
{
    internal class TaxiSluzba
    {
        private string naziv;
        private float predjeniKM;
        private float ukupnaNaplacenaCena;
        private List<Auto> lista;

        public TaxiSluzba()
        {
            naziv = string.Empty;
            predjeniKM = 0;
            ukupnaNaplacenaCena = 0;
            lista = new List<Auto>();
        }

        public TaxiSluzba(string naziv, float predjeniKM, float ukupnaNaplacenaCena)
        {
            this.naziv = naziv;
            this.predjeniKM = predjeniKM;
            this.ukupnaNaplacenaCena = ukupnaNaplacenaCena;
            lista = new List<Auto>();
        }

        public void DodajAuto(Auto a)
        {
            lista.Add(a);
        }

        public void IzbaciPreskupaVozila()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].CenaPoKM() > (ukupnaNaplacenaCena / predjeniKM))
                { 
                    lista.Remove(lista[i]);
                    i--;
                }
            }
        }

        public void SortirajOpadajuce()
        {
            lista.Sort();
        }

        public void ProveriBaterije()
        {
            foreach (EAuto ea in lista.OfType<EAuto>())
                if (ea.IstekRokaBaterija < DateTime.Now)
                    throw new PotencijalnaExplozija("istekao rok baterije!");
        }

        public void UpisiUFajl(string imeFajla)
        {
            using (StreamWriter sw = new StreamWriter(imeFajla))
            {
                sw.WriteLine($"{naziv}\n{predjeniKM}\n{ukupnaNaplacenaCena}");
                sw.WriteLine(lista.Count);
                foreach (var a in lista)
                    a.UpisUFajl(sw);
            }
        }

        public void UcitajIzFajla(string imeFajla)
        {
            using (StreamReader sr = new StreamReader(imeFajla))
            {
                naziv = sr.ReadLine();
                predjeniKM = float.Parse(sr.ReadLine());
                ukupnaNaplacenaCena = float.Parse(sr.ReadLine());
                int n = int.Parse(sr.ReadLine());
                Auto a = null;
                Tip tipA;
                for (int i = 0; i < n; i++)
                {
                    tipA = (Tip)Enum.Parse(typeof(Tip), sr.ReadLine());
                    if (tipA == Tip.EL)
                        a = new EAuto();
                    else if (tipA == Tip.SUS)
                        a = new AutoSUS();
                    a.CitanjeIzFajla(sr);
                    lista.Add(a);
                }
            }
        }

        public void IspisNaEkran()
        {
            Console.WriteLine($"naziv: {naziv}\npredjeniKm: {predjeniKM}\nukupna napl. cena: {ukupnaNaplacenaCena}\n");
            foreach (var a in lista)
                a.IspisNaEkran();
        }
    }
}
