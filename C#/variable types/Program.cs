using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 10;
            byte ikinci = 15;
            //byte ucuncu = 256; byte 0 ile 255 sayıları arasındadır.
            byte maxdeger = byte.MaxValue;
            byte mindeger = byte.MinValue;



            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            // Console.WriteLine(ucuncu);
            Console.WriteLine(mindeger);
            Console.WriteLine(maxdeger);
            Console.ReadLine();

        }
    }
}
