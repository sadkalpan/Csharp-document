using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_a_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name : ");

            string name = Console.ReadLine();

            Console.WriteLine("enter your surname : ");

            string surname = Console.ReadLine();

            Console.WriteLine("enter your salary day : ");

            string salary = Console.ReadLine();

            Console.WriteLine("user name : " + name);
            Console.WriteLine("user surname : " + surname);
            Console.WriteLine("user salary : " + salary);
            Console.ReadLine();
        }
    }
}
