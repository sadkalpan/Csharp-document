using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_the_variable
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            int a = 500;
            byte b = (byte)a;

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();

            string sayi1 = "1";
            string sayi2 = "2";
            Console.WriteLine(sayi1 + sayi2);

            int a = int.Parse(sayi1);
            int b = int.Parse(sayi2);
            Console.WriteLine(a + b);

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);
            Console.WriteLine(a + b);

            int sayi1 = 10;
            int sayi2 = 5;

            string a = sayi1.ToString();
            string b = sayi2.ToString();
            Console.WriteLine(a + b);
            
            double sayi1 = 5.22;
            int a = Convert.ToInt32(sayi1);
            Console.WriteLine(a);
            Console.WriteLine(sayi1.GetType());
            
            Console.WriteLine("enter your age: ");
            string userage = Console.ReadLine();
            int a = int.Parse(userage);
            int b = Convert.ToInt32(userage);
            Console.WriteLine("yasiniz: " + a);
            Console.WriteLine("yasiniz : " + b);
            */
            Console.WriteLine("enter your salary: ");
            string salary1 = Console.ReadLine();

            Console.WriteLine("enter your friends salary: ");
            string salary2 = Console.ReadLine();

            int a = Convert.ToInt32(salary1);
            int b = int.Parse(salary2);
            Console.WriteLine("total salary: " + (a + b));
            
            Console.ReadLine();

        }
    }
}
