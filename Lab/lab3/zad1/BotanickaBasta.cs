using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab3_1.Biljka;

namespace lab3_1
{
    internal class BotanickaBasta
    {
        private string naziv;
        private int brojPosetioca;
        private float cenaUlaznice;
        private List<Biljka> lista;
        
        public BotanickaBasta()
        {
            naziv = string.Empty;
            brojPosetioca = 0;
            cenaUlaznice = 0.0f;
            lista = new List<Biljka>();
        }

        public BotanickaBasta(string naziv, int brojPosetioca, float cenaUlaznice)
        {
            this.naziv = naziv;
            this.brojPosetioca = brojPosetioca;
            this.cenaUlaznice = cenaUlaznice;
            lista = new List<Biljka>();
        }

        public void DodajBiljku(Biljka b)
        {
            lista.Add(b);
        }

        public void IzbaciVisakBiljaka()
        {
            //lista.Sort((b1, b2) => b1.CenaOdrzavanja().CompareTo(b2.CenaOdrzavanja()));
            //while (lista.Count >= 0 && (UkupnoOdrzavanje() > (brojPosetioca * cenaUlaznice)))
            //{
            //    int i = 0;
            //    while (i < lista.Count && !lista[i++].JeVisegodisnja) ;
            //    if (i == lista.Count)
            //        break;
            //    if (lista[i].JeVisegodisnja == true)
            //        lista.Remove(lista[i]);
            //}

            float dnevnazarada = brojPosetioca * cenaUlaznice;
            float ukupno = UkupnoOdrzavanje();
            lista.Sort((b1, b2) => b1.CenaOdrzavanja().CompareTo(b2.CenaOdrzavanja()));     // custom compareable
            int i = lista.Count - 1;
            while (i >= 0 && ukupno > dnevnazarada)
            {
                if (lista[i].JeVisegodisnja == true)
                {
                    ukupno -= lista[i].CenaOdrzavanja();
                    lista.Remove(lista[i]);
                }
                i--;
            }
        }

        private float UkupnoOdrzavanje()
        {
            float cena = 0.0f;
            foreach (var b in lista)
                cena += b.CenaOdrzavanja();
            return cena;
        }

        public void SortirajOpadajuce()
        {
            lista.Sort();
        }

        public bool ProveriRaspored()
        {
            bool imaStablasta = false;
            bool imaSaksijska = false;
            foreach (var b in lista)
            {
                if (b is StablastaBiljka)
                    imaStablasta = true;
                if (b is SaksijskaBiljka)
                    imaSaksijska = true;
                if (imaStablasta && imaSaksijska)
                    return true;
            }
            throw new NedovoljnaRaznovrsnost("nedovoljna raznovrsnost!");
        }

        public void UpisiBinarno(string imeFajla)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream(imeFajla, FileMode.Create)))
            {
                bw.Write(naziv);
                bw.Write(brojPosetioca);
                bw.Write(cenaUlaznice);
                bw.Write(lista.Count);
                foreach (var b in lista)
                    b.UpisiBinarno(bw);
            }
        }

        public void CitajBinarno(string imeFajla)
        {
            using (BinaryReader br = new BinaryReader(new FileStream(imeFajla, FileMode.Open)))
            {
                naziv = br.ReadString();
                brojPosetioca = br.ReadInt32();
                cenaUlaznice = br.ReadSingle();
                int brBiljaka = br.ReadInt32();
                Biljka b;
                Tip tipB;
                for (int i = 0; i < brBiljaka; i++)
                {
                    tipB = (Tip)br.ReadByte();
                    if (tipB == Tip.SAKSIJSKA)
                        b = new SaksijskaBiljka();
                    else
                        b = new StablastaBiljka();
                    b.CitajBinarno(br);
                    lista.Add(b);
                }
            }
        }

        public void StampajNaKonzolu()
        {
            Console.WriteLine($"Naziv: {naziv}, brojPosetioca: {brojPosetioca}, cena ulaznice: {cenaUlaznice}\n" +
                $"ukupno odrzavanje: {UkupnoOdrzavanje()}\ndnevna zarada: {cenaUlaznice * brojPosetioca}\nbiljke {lista.Count}:\n");
            foreach (var b in lista)
                b.StampajNaEkran();
        }
    }
}
