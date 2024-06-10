    class Buffer
    {
        private int[] niz;
        private int brTr;

        private readonly object lockObject = new object();

        public Buffer(int n)
        {
            niz = new int[n];
            brTr = 0;
        }

        public void Add(int el)
        {
            Monitor.Enter(lockObject);
            try
            {    
                if (brTr == niz.Length)
                    throw new Exception("Buffer je pun");
                
                niz[brTr] = el;
                brTr++;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Monitor.Exit(lockObject);
            }
        }

        public void Remove(int pos)
        {
                    
            Monitor.Enter(lockObject);

            try {
                if (brTr == 0 || pos < 0 || pos >= brTr)
                    throw new Exception("Buffer je prazan ili je pozicija van opsega");
                for (int i = pos; i < brTr - 1; i++)
                    niz[i] = niz[i + 1];
                brTr--;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Monitor.Exit(lockObject);
            }

        }
    }