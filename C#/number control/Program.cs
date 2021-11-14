using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_control
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 20, 30, 40, 40, 40, 40,  50, 60};
            int amount = 0;

            Console.WriteLine("enter the number: ");
            int entry = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == entry)
                {
                   amount ++;
                }
            }
            
            if(amount != 0)
            {
                Console.WriteLine("this number has alredy used " + amount + " times");
            }
            else
            {
                Console.WriteLine("this nunber is not exist");
            }
            Console.ReadLine();
        
        
        
        
        
        }
    }
}
