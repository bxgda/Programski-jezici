using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3zad1
{
    internal class SaksijskaBiljka : Biljka
    {
        private float kolicinaDjubriva;
        private float cenaDjubriva;
        public SaksijskaBiljka()
            : base()
        {
            kolicinaDjubriva = kolicinaVode = 0.0f;
            tipBiljke = Tip.SAKSIJSKA;
        }

        public SaksijskaBiljka(string naziv, bool jeVisegodisnja, float kolicinaVode, float kolicinaDjubriva, float cenaDjubriva) 
            : base(naziv, jeVisegodisnja, kolicinaVode)
        {
            this.kolicinaDjubriva = kolicinaDjubriva;
            this.cenaDjubriva = cenaDjubriva;
            this.tipBiljke = Tip.SAKSIJSKA;
        }

        public override float cenaOdrzavanja()
        {
            float tmp = (kolicinaVode * 10.0f + kolicinaDjubriva * cenaDjubriva);
            if (jeVisegodisnja)
                return tmp * 1.1f;
            return tmp;
        }

        public override void citaj(BinaryReader br)
        {
            base.citaj(br);
            kolicinaDjubriva = br.ReadSingle();
            cenaDjubriva = br.ReadSingle();
        }


        public override void upisiBinarno(BinaryWriter bw)
        {
            base.upisiBinarno(bw);
            bw.Write(kolicinaDjubriva);
            bw.Write(cenaDjubriva);
        }

        public override void stampajNaKonzolu()
        {
            base.stampajNaKonzolu();
            Console.WriteLine("kolicinaDjubriva: " + kolicinaDjubriva + ", cenaDjubriva: " + cenaDjubriva);
            Console.WriteLine();
        }
    }
}
