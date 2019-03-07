using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarat_Kezelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jarat_Kezelo b = new Bank();
            b.UjSzamla("Bela", "1234");
            b.UjSzamla("John", "1111");
            b.Utal("1234", "1111", 10000);
            Console.WriteLine(b.Egyenleg("1234"));
            Console.WriteLine(b.Egyenleg("1111"));

            Console.ReadLine();
        }
    }
}
