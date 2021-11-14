using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_in_machine
{
    class Program
    {
        static void Main(string[] args)
        {

            int attemp_number = 3;
            while (true)
            {
                Console.WriteLine("please enter the password");
                string password = Console.ReadLine();

                if (password == "sdk")
                {
                    Console.WriteLine("congrulations");
                    break;
                }
                else
                {
                    Console.WriteLine("your attemp is fail.");
                    

                    if (attemp_number > 0)
                    {
                        attemp_number -= 1;
                    }
                    if(attemp_number == 0)
                    {
                        Console.WriteLine("your right is up");
                        //Console.ReadLine();
                        break;
                    }
                } 
            }
         Console.ReadLine();

        }
    }
}
