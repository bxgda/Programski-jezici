using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    internal class Restoran
    {
        private string naziv;
        private List<Stavka> lista;

        public Restoran()
        {
            naziv = string.Empty;
            lista = new List<Stavka>();
        }

        public Restoran(string naziv)
        {
            this.naziv = naziv;
            lista = new List<Stavka>();
        }

        public void DodajStavku(Stavka s)
        {
            lista.Add(s);
        }

        public void SortirajRastuce()
        {
            lista.Sort((x, y) => x.VratiCenu().CompareTo(y.VratiCenu()));
        }

        public void IzbaciIstekaoRokTrajanja()
        {
            for (int i = 0; i < lista.Count; i++)
                if (lista[i].Datum < DateTime.Now)
                {
                    lista.Remove(lista[i]);
                    i--;
                }
        }

        public void JelImaVegansko()
        {
            foreach (var s in lista)
                if (s.JeVeganska)
                    return;
            throw new VeganUnfriendly("nema vege!");
        }

        public void UFajlBinarni(string imeFajla)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream(imeFajla, FileMode.Create)))
            {
                bw.Write(naziv);
                bw.Write(lista.Count);
                foreach (var b in lista)
                    b.UpisiBinarno(bw);
            }
        }

        public void IzFajlaBinarnog(string imeFajla)
        {
            using (BinaryReader br = new BinaryReader(new FileStream(imeFajla, FileMode.Open)))
            {
                naziv = br.ReadString();
                int n = br.ReadInt32();
                bool jelopice;
                Stavka s;
                for (int i = 0; i < n; i++)
                {
                    jelopice = br.ReadBoolean();
                    if (jelopice)
                        s = new Pice();
                    else
                        s = new Jelo();
                    s.CitajBinarno(br);
                    lista.Add(s);
                }
            }
        }

        public void NaEkran()
        {
            Console.WriteLine($"naziv: {naziv}\nstavke:\n");
            foreach (var s in lista)
                s.IspisiNaEkran();
        }
    }
}
