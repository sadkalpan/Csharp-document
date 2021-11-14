using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose process what would you do");
            string number = Console.ReadLine();
            //Console.ReadLine();

            int balance = 1000;

            if (number == "1")
            {
                Console.WriteLine("current balance : " + balance);
                Console.ReadLine();
            }

            else if (number == "2")
            {
                Console.WriteLine("amount the money that you want to deposite ");
                int deposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your balance is : " + (balance + deposit));
                Console.ReadLine();
            }
            else if (number == "3")
            {
                Console.WriteLine("amont the money that you take");
                int take = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your balance is : " + (balance - take));
                Console.ReadLine();
            }
            else if (number == "q")
            {
                Console.WriteLine("exiting is continued");
                Console.WriteLine("your request is completed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("wrong log in,please try again");
                Console.ReadLine();
            }
        
        }
    }
}
