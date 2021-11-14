using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsuls
{
    class Program
    {
        static void Main(string[] args)
        {
            //getter and setter
            //properties
            student scapsul = new student();

            //Console.WriteLine(scapsul.name);
            scapsul.setname("sadik");
            string names = scapsul.getname();
            Console.WriteLine(names);
            Console.ReadLine();
        }
    }
}
