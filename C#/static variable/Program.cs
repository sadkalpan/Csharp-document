using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            worker c = new worker(1907, "SADIK", "ALPAN");


            c.showinfo();

            c.raise(1000);
           
            Console.ReadLine();
            
        }
    }
}
