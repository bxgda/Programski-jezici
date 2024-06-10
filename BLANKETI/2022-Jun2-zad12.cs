using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* jebem li ga da li ovako treba ili treba pravim lancanu listu od nulu... */

namespace Probni
{
    public class Klasa : IEnumerator<Object>
    {
        private LinkedList<Object> lista = new LinkedList<Object>();
        private LinkedListNode<Object> trenutni = new LinkedListNode<object>(1);

        public void Add(Object o)
        {
            lista.AddLast(o);
        }

        public object Current {
            get {
                return trenutni.Value;
            }
        }

        public bool MoveNext()
        {
            if (trenutni.Next != null)
                trenutni = trenutni.Next;

            return trenutni.Next == null;
        }

        public void Reset()
        {
            if (lista.First != null)
                trenutni = lista.First;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Klasa k = new Klasa();
            
            k.Add(1);
            k.Add(2);
            k.Add(3);
            k.Add("String neki");
            k.Add(5.034);
            k.Add(6.2f);
            k.Add("Proba");
            k.Add(true);
            k.Add(9);
            k.Add(false);

            k.Reset();
            do {
                Console.WriteLine(k.Current);
            } while (!k.MoveNext());

        }
    }
}