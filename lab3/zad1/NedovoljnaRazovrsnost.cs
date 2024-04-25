using System.Runtime.Serialization;

namespace lab3zad1
{
    [Serializable]
    internal class NedovoljnaRazovrsnost : Exception
    {
        public NedovoljnaRazovrsnost()
        {
        }

        public NedovoljnaRazovrsnost(string? message) : base(message)
        {
        }

        public NedovoljnaRazovrsnost(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}