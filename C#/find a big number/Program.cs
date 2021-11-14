using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_a_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] numbers = new int[4];

            //int i = 0;
            //for (i = 0; i < numbers.Length; i++)
            //{
            int first = 0, second = 0, third = 0, fourth = 0;
            Console.WriteLine("enter a number.");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a number.");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a number.");
            third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a number.");
            fourth = Convert.ToInt32(Console.ReadLine());

            bignumber(first, second, third, fourth);
            Console.ReadLine();
        } 

        static void bignumber(int first, int second, int third, int fourth)
        {

            int[] numbers = { first, second, third, fourth };


            int i = 0, j = 0;
            //for (i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("enter a four number.");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            int box = 0;

            for(i = 0; i < numbers.Length; i++)
            {
                for(j = 0; i < numbers.Length; i++)
                if(numbers[i] > numbers[j])
                    {
                        box = numbers[i];
                    }
                Console.WriteLine("bignumber is : "+ box);
                //Console.ReadLine();
            
            }


        }
    
    
    
    }
}
