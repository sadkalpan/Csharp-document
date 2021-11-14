using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine()); 
            
            int i;
            int sum = 0;

            for(i = 0; i <= number; i++)
            {
                sum = sum + i;
            }
            int average = sum / number;

            if(average > 50)
            {
                Console.WriteLine("average is over than fifty : ");
            }
            else if(average == 50)
            {
                Console.WriteLine("average is egual to fifty : ");
            }
        
            else
            {
                Console.WriteLine("average is below the fifty");
            }
            Console.ReadLine();
        
        
        }
    }
}
