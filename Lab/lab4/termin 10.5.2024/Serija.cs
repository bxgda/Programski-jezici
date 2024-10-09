using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_19059
{
    class Serija : Emisija
    {
        private int brojEpizoda;
        private float cenaSvihEpizoda;
        private bool jeDomaca;

        public Serija()
            : base()
        {
            brojEpizoda = 0;
            cenaSvihEpizoda = 0.0f;
            jeDomaca = false;
        }

        public Serija(string naziv, float gledanost, Dan danPrikazivanja, int brojEpizoda, float cenaSvihEpizoda, bool jeDomaca)
            : base(naziv, gledanost, danPrikazivanja)
        {
            this.brojEpizoda = brojEpizoda;
            this.cenaSvihEpizoda = cenaSvihEpizoda;
            this.jeDomaca = jeDomaca;
        }

        public override float CenaEmisije()
        {
            if (jeDomaca)
                return cenaSvihEpizoda / brojEpizoda;
            return (cenaSvihEpizoda / brojEpizoda) * 1.25f;
        }

        public override void UpisiUFajl(StreamWriter sw)
        {
            base.UpisiUFajl(sw);
            sw.WriteLine($"broj epizoda: {brojEpizoda}\ncena svih ep: {cenaSvihEpizoda}\nje domaca: {jeDomaca}\n" +
                $"cena emisije: {CenaEmisije()}\n");
        }

        public override void NaEkran()
        {
            base.NaEkran();
            Console.WriteLine($"broj epizoda: {brojEpizoda}\ncena svih ep: {cenaSvihEpizoda}\nje domaca: {jeDomaca}\n" +
                $"cena emisije: {CenaEmisije()}\n");
        }
    }
}
