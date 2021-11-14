using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            personel p = new personel();

            p.tckimlik = "12345678910";
            Console.WriteLine("your ıd no: " + p.tckimlik);
            Console.ReadLine();
        }
    }
}
