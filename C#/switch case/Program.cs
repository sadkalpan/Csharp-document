using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 1500;
            Console.WriteLine("welcome to our atm");
            Console.WriteLine("please choose the number: ");
            Console.WriteLine("1- one is showing your balance : ");
            Console.WriteLine("2- two is to taking money from your balance : ");
            Console.WriteLine("3- three is to give money : ");
            Console.WriteLine("4- is exiting the ATM");

            Console.WriteLine("please choose the number: ");
            string number = Console.ReadLine();
            
            switch (number)
            {
                case "1":
                    Console.WriteLine("your currently balance is " + balance);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("enter your want to taking money amount : ");
                    int take = Convert.ToInt32(Console.ReadLine());

                    if(take > balance)
                    {
                        Console.WriteLine("your current balance is under your taking request : ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("your current balance is : " + (balance - take));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("enter the amount of money that you want to give : ");
                    int give = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("your currently balasnce is : " + (balance + give));
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("quiting the atm machine : ");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("please enter the exist number. ");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
