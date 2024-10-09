using System;
using System.Runtime.Serialization;

namespace lab3_1
{
    [Serializable]
    internal class NedovoljnaRaznovrsnost : Exception
    {
        public NedovoljnaRaznovrsnost()
        {
        }

        public NedovoljnaRaznovrsnost(string message) : base(message)
        {
        }

        public NedovoljnaRaznovrsnost(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NedovoljnaRaznovrsnost(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}