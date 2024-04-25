using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab_Auto
{
    internal class PotencijalnaEksplozija : Exception
    {
        public PotencijalnaEksplozija(string message) : base(message) { }

    }
}
