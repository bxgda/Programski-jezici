using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_19059
{
    class StudijskaEmisija : Emisija
    {
        private float plataVoditelja;
        private int brojGostiju;
        private float honorar;

        public StudijskaEmisija()
            : base()
        {
            plataVoditelja = 0.0f;
            brojGostiju = 0;
            honorar = 0;
        }

        public StudijskaEmisija(string naziv, float gledanost, Dan danPrikazivanja, float plataVoditelja, int brojGostiju, float honorar)
            : base(naziv, gledanost, danPrikazivanja)
        {
            this.plataVoditelja = plataVoditelja;
            this.brojGostiju = brojGostiju;
            this.honorar = honorar;
        }

        public override float CenaEmisije()
        {
            if (danPrikazivanja == Dan.SUBOTA || danPrikazivanja == Dan.NEDELJA)
                return (plataVoditelja + brojGostiju * honorar) * 1.2f;
            return plataVoditelja + brojGostiju * honorar;
        }

        public override void UpisiUFajl(StreamWriter sw)
        {
            base.UpisiUFajl(sw);
            sw.WriteLine($"plata voditelja: {plataVoditelja}\nbroj gostiju: {brojGostiju}\nhonorar: {honorar}\n" +
                $"cena emisije: {CenaEmisije()}\n");
        }

        public override void NaEkran()
        {
            base.NaEkran();
            Console.WriteLine($"plata voditelja: {plataVoditelja}\nbroj gostiju: {brojGostiju}\nhonorar: {honorar}\n" +
                $"cena emisije: {CenaEmisije()}\n");
        }
    }
}
