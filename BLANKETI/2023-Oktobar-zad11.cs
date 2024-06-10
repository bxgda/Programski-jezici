using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Probni
{
    public interface IEnumerator<T>
    {
        T Current { get; }
        bool MoveNext();
        void Reset();
    }

    public class NizEnumerator<T> : IEnumerator<T>
    {
        private T[] niz;
        private int pozicija = -1;

        public NizEnumerator(T[] niz)
        {
            this.niz = niz;
        }

        public T Current
        {
            get
            {
                return niz[pozicija];
            }
        }

        public bool MoveNext()
        {
            pozicija++;
            return pozicija < niz.Length;
        }

        public void Reset()
        {
            pozicija = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float[] niz = { 1.0f, 2.0f, 3.0f, 4.0f };
            IEnumerator<float> enumerator = new NizEnumerator<float>(niz);

            enumerator.Reset();
            while (enumerator.MoveNext())         
                Console.WriteLine(enumerator.Current);

        }
    }
}