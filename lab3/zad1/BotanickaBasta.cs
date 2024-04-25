using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab3zad1.Biljka;

namespace lab3zad1
{
    internal class BotanickaBasta
    {
        private string naziv;
        private int brojPosetilaca;
        private float cenaUlaznice;
        private List<Biljka> lista;
        public BotanickaBasta()
        {
            naziv = "";
            brojPosetilaca = 0;
            cenaUlaznice = 0.0f;
            lista = new List<Biljka>();
        }
        
        private float ukupnoOdrzavanje()
        {
            float cena = 0.0f;
            foreach (var b in lista)
                cena += b.cenaOdrzavanja();
            return cena;
        }

        public BotanickaBasta(string naziv, int brojPosetilaca, float cenaUlaznice)
        {
            this.naziv = naziv;
            this.brojPosetilaca = brojPosetilaca;
            this.cenaUlaznice = cenaUlaznice;
            this.lista = new List<Biljka>();
        }

        public void dodajBiljku(Biljka b)
        {
            lista.Add(b);
        }

        public void izbaciVisakBiljaka()
        {
            float dnevnazarada = brojPosetilaca * cenaUlaznice;
            float ukupno = ukupnoOdrzavanje();
            lista.Sort((b1, b2) => b1.cenaOdrzavanja().CompareTo(b2.cenaOdrzavanja()));     // custom compareable
            int i = lista.Count - 1;
            while (i >= 0 && ukupno > dnevnazarada)
            {
                if (lista[i].JeVisegodisnja == true)
                {
                    ukupno -= lista[i].cenaOdrzavanja();
                    lista.Remove(lista[i]);
                }
                i--;
            }
        }

        public void sortiraj()
        {
            lista.Sort();
        }

        public bool proveriRaspored()
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
            throw new NedovoljnaRazovrsnost("nedostaje ili saksijska ili stablasta biljka!");
        }

        public void upisiBinarno(string imeFajla)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream(imeFajla, FileMode.Create)))
            {
                bw.Write(naziv);
                bw.Write(brojPosetilaca);
                bw.Write(cenaUlaznice);
                bw.Write(lista.Count);
                foreach (var b in lista)
                    b.upisiBinarno(bw);
            }
        }

        public void citajBinarno(string imeFajla)
        {
            using (BinaryReader br = new BinaryReader(new FileStream(imeFajla, FileMode.Open)))
            {
                naziv = br.ReadString();
                brojPosetilaca = br.ReadInt32();
                cenaUlaznice = br.ReadSingle();
                int n = br.ReadInt32();
                Biljka b;
                for (int i = 0; i < n; i++)
                {
                    Tip tipb = (Tip)br.ReadByte();
                    if (tipb == Tip.SAKSIJSKA)
                        b = new SaksijskaBiljka();
                    else
                        b = new StablastaBiljka();
                    b.citaj(br);
                    lista.Add(b);
                }
                
            }
        }

        public void stampaj()
        {
            Console.WriteLine("ukupno odrzavanje: " + ukupnoOdrzavanje() + ", naziv baste: " + naziv + ", broj posetilaca: " + brojPosetilaca + ", cena ulaznice: " + cenaUlaznice + "\n");
            foreach (var b in lista)
                b.stampajNaKonzolu();
        }
    }
}
