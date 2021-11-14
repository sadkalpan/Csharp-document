using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_project
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("enter a number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            
            int change = evenodd(first);
            if(change == 1)
            {
                Console.WriteLine("your entry is odd: ");
            }
            else
            {
                Console.WriteLine("your entry is even: ");
            }
            Console.ReadLine();
            */
            Console.Write("enter a number... ");
            int second = Convert.ToInt32(Console.ReadLine());
            numbercontrol(second);

            Console.ReadLine();
        }
        
        //static int evenodd(int first)
        //{
        //    return first % 2;

        //}
        
        static void numbercontrol(int second)
        {
            if(second % 2 == 1)
            {
                Console.WriteLine("number is odd.");

            }
            else
            {
                Console.WriteLine("number is even.");
            }
            //Console.ReadLine();
        }
    
    
    
    }
}
