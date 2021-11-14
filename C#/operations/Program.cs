using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstvalue = 10;
            int secondvalue = 7;
            int thirdvalue = 2;
            int process = firstvalue + secondvalue;
            int process1 = (firstvalue * thirdvalue) / 6;
            int process2 = firstvalue % 3;
            int sayi = 10;
            sayi++ ;

            Console.WriteLine(process);
            Console.WriteLine(process1);
            Console.WriteLine(process2);
            Console.WriteLine("sayi = " + sayi);
            Console.ReadLine();
        }
    }
}
