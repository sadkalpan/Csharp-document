using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int change = takesquare(number);

            if(change > 25)
            {
                Console.WriteLine("the number's square is grsater than 25. ");
            }
            else if(change == 25)
            {
                Console.WriteLine("the number's square is equal to 25. ");
            }
            else 
            {
                Console.WriteLine("the numbser's square is lower than 25");
            }
            Console.ReadLine();


        }
    
        static int takesquare(int number)
        {
            return number * number;
        }
    
    }
}
