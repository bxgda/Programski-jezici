using System;
using System.Runtime.Serialization;

namespace Lab4_19059
{
    [Serializable]
    internal class PogresanRaspored : Exception
    {
        public PogresanRaspored()
        {
        }

        public PogresanRaspored(string message) : base(message)
        {
        }

        public PogresanRaspored(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PogresanRaspored(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}