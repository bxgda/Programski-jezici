using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_19059
{
    class Televizija
    {
        private string naziv;
        private float iznosNaRaspolaganju;
        private List<Emisija> lista;

        public Televizija()
        {
            naziv = string.Empty;
            iznosNaRaspolaganju = 0.0f;
            lista = new List<Emisija>();
        }

        public Televizija(string naziv, float iznosNaRaspolaganju)
        {
            this.naziv = naziv;
            this.iznosNaRaspolaganju = iznosNaRaspolaganju;
            lista = new List<Emisija>();
        }

        public void UbaciEmisiju(Emisija e)
        {
            lista.Add(e);
        }

        public void IzbaciPoGledanosti()
        {
            using (StreamWriter sw = new StreamWriter("log.txt"))
            {
                lista.Sort((b1, b2) => b1.Gledanost.CompareTo(b2.Gledanost));
                float ukupno = UkupnaCenaEmisija();
                while (lista.Count >= 0 && iznosNaRaspolaganju < ukupno)
                {
                    ukupno -= lista[0].CenaEmisije();
                    lista[0].UpisiUFajl(sw);
                    lista.RemoveAt(0);
                }
            }
        }

        public float UkupnaCenaEmisija()
        {
            float cena = 0.0f;
            foreach (var e in lista)
                cena += e.CenaEmisije();
            return cena;
        }

        public void SortirajPoDanima()
        {
            lista.Sort((b1, b2) => b1.DanPrikazivanja.CompareTo(b2.DanPrikazivanja));
        }

        public void ProveriRaspored()
        {
            // ovo je sigurno moglo bolje da se uradi ali se nisam setio drugog resenja a da bude tacno, svakako je optimalno jer imam samo jedan prolaz kroz listu

            bool ponSer, utoSer, sreSer, cetSer, petSer, subSer, nedSer, ponStud, utoStud, sreStud, cetStud, petStud, subStud, nedStud;
            ponSer = utoSer = sreSer = cetSer = petSer = subSer = nedSer = ponStud = utoStud = sreStud = cetStud = petStud = subStud = nedStud = false;
            foreach (var e in lista)
            {
                if (e.DanPrikazivanja == Emisija.Dan.PONEDELJAK && e is Serija)
                    ponSer = true;
                else if (e.DanPrikazivanja == Emisija.Dan.PONEDELJAK && e is StudijskaEmisija)
                    ponStud = true;
                else if (e.DanPrikazivanja == Emisija.Dan.UTORAK && e is Serija)
                    utoSer = true;
                else if (e.DanPrikazivanja == Emisija.Dan.UTORAK && e is StudijskaEmisija)
                    utoStud = true;
                else if (e.DanPrikazivanja == Emisija.Dan.SREDA && e is Serija)
                    sreSer = true;
                else if (e.DanPrikazivanja == Emisija.Dan.SREDA && e is StudijskaEmisija)
                    sreStud = true;
                else if (e.DanPrikazivanja == Emisija.Dan.CETVRTAK && e is Serija)
                    cetSer = true;
                else if (e.DanPrikazivanja == Emisija.Dan.CETVRTAK && e is StudijskaEmisija)
                    cetStud = true;
                else if (e.DanPrikazivanja == Emisija.Dan.PETAK && e is Serija)
                    petSer = true;
                else if (e.DanPrikazivanja == Emisija.Dan.PETAK && e is StudijskaEmisija)
                    petStud = true;
                else if (e.DanPrikazivanja == Emisija.Dan.SUBOTA && e is Serija)
                    subSer = true;
                else if (e.DanPrikazivanja == Emisija.Dan.SUBOTA && e is StudijskaEmisija)
                    subStud = true;
                else if (e.DanPrikazivanja == Emisija.Dan.NEDELJA && e is Serija)
                    nedSer = true;
                else if (e.DanPrikazivanja == Emisija.Dan.NEDELJA && e is StudijskaEmisija)
                    nedStud = true;
            }
            if (ponSer && utoSer && sreSer && cetSer && petSer && subSer && nedSer && ponStud && utoStud && sreStud && cetStud && petStud && subStud && nedStud)
                return;
            else
                throw new PogresanRaspored("pogresan raspored!");
        }

        public void TVNaKonzolu()
        {
            Console.WriteLine($"naziv TV-a: {naziv}\niznos na raspolaganju: {iznosNaRaspolaganju}\n");
            foreach (var e in lista)
                e.NaEkran();
        }
    }
}
