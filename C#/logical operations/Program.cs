using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 15;
            int sayi3 = 20;
            int sayi4 = 20;

            bool a = sayi1 != sayi2 && sayi3 == sayi4;

            Console.WriteLine(!a);
            Console.ReadLine();
        }
    }
}
