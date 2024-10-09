using System;
using System.Runtime.Serialization;

namespace lab3_2
{
    [Serializable]
    internal class PotencijalnaExplozija : Exception
    {
        public PotencijalnaExplozija()
        {
        }

        public PotencijalnaExplozija(string message) : base(message)
        {
        }

        public PotencijalnaExplozija(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PotencijalnaExplozija(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}