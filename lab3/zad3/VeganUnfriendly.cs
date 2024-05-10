using System;
using System.Runtime.Serialization;

namespace lab3_3
{
    [Serializable]
    internal class VeganUnfriendly : Exception
    {
        public VeganUnfriendly()
        {
        }

        public VeganUnfriendly(string message) : base(message)
        {
        }

        public VeganUnfriendly(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VeganUnfriendly(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}