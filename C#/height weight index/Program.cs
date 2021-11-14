using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace height_weight_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your weight : ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your height : ");
            double height = Convert.ToDouble(Console.ReadLine());

            double weight_height_index = (weight / (height * height));

            if (weight_height_index < 18)
            {
                Console.WriteLine("your index is low");
                Console.ReadLine();
            }
            else if (weight_height_index > 18 && 25 > weight_height_index)
            {
                Console.WriteLine("your index is normal");
                Console.ReadLine();
            }

            else if(weight_height_index > 25)
            {
                Console.WriteLine("your index is high");
                Console.ReadLine();
            }
        
        }
    }
}
