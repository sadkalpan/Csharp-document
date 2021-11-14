using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_properties2
{
    class Program
    {
        static void Main(string[] args)
        {
            kilo k1 = new kilo();

            k1.kilo1 = 85;
            k1.kilo2 = 85;

            Console.WriteLine("property olan kilo: "+k1.kilo1);
            Console.WriteLine("encapshule olan kilo: "+k1.kilo2);

            Console.ReadLine();
        }
    }
}
