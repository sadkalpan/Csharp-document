using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer();

            customer1.Weight = 95; /*deger atamasından dolayı set blokları calısır.*/
            Console.WriteLine(customer1.Weight);
            Console.ReadLine();
        }
    }
}
