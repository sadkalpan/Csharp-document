using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 0;
            int evensum = 0;
            int oddsum = 0;
            int odd = 0;
            //int amount = 0;
            int i = 0, j = 0;

            int[] number = new int[5];
            for (i = 0; i < number.Length
                ; i++)
            {
                Console.WriteLine("enter a " + (i + 1) + ".number:");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = 0; j < number.Length; j++)
                {
                    if(number[j]%2 == 1)
                    {
                    oddsum += number[j];
                    odd++;
                    }
                        else 
                        {
                        evensum += number[j];
                        even++;
                        }    
            }

            if(evensum > oddsum)
            {
                Console.WriteLine("evensum is grater.");
            }
            else
            {
                Console.WriteLine("oddsum is grater.");
            }
            Console.WriteLine("amount of odd is : " + odd +" and oddsum is " + oddsum +" amount of even is : " + even + " and evensum is " + evensum);
            Console.ReadLine();
            
            
        }
    }
}
