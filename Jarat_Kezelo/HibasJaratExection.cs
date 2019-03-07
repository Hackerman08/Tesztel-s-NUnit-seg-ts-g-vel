using System;

namespace Jarat_Kezelo
{
    internal class HibasJaratExection : Exception
    {
        public HibasJaratExection(int keses)
            : base("Hibas keses: " + keses)
        {
            // Java:
            // super("Hibas szamlaszam: " + szamlaszam);
        }
    }
}