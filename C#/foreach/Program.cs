using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {/*
            double[] os = { 1.7, 5.6, 8.9, 6.5};
            foreach(double e in os)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        */
            Console.WriteLine("Bir sayı giriniz : ");

            int[] number = new int[2];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine(number[j]);
            }

            Console.ReadLine();        
        
        
        
        
        
        
        }
    }
}
