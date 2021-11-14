using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("the values is : " + i);
            }
            Console.ReadLine();
        
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
            
            int i = 100;

            while (i >= 0)
            {
                Console.WriteLine(i);
                i-=2;
            }
             */

            int i = 1;
            int sum = 0;
            do
            {
                sum = sum + i;
                i++;
            }
            while (i <= 100);
            Console.WriteLine("summaration is : " + sum);

            Console.ReadLine();
         
        }    
    }
}
