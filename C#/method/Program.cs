using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            {            {
                //salut();
                //info();
                //summaration( 6, 7);

                //int i = 0, j = 0;
                //int[] number = new int[3];
                //for (i = 0; i < number.Length; i++)
            }
                //Console.WriteLine("please enter the number : ");
                //  number[i] = Convert.ToInt32(Console.ReadLine());
                //int second = Convert.ToInt32(Console.ReadLine());
                //int third = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter the name: ");
                string name = Console.ReadLine();
                Console.WriteLine("please enter your lastname: ");
                string lastname = Console.ReadLine();

                string changevalue = information(name, lastname);
                Console.WriteLine(changevalue);
                Console.ReadLine();
            

            }
            {
                //    int change = multiply(number[0], number[1], number[2]);

                //Console.WriteLine(change);
                //Console.ReadLine();

                Console.WriteLine("enter a number: ");
                int number = int.Parse(Console.ReadLine());
               
                int a = takesquare(number);
                if (number > 25)
                {
                    Console.WriteLine("your number is grater than 25");
                    
                }
                else
                {
                    Console.WriteLine("your number is lower than 25");
                }
                Console.ReadLine();
        }
      
        static void salut()
        {
            Console.WriteLine("hello world");
            //Console.ReadLine();
        }
     
        static void info()
        {
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("enter your salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("user name : " + name + "  salary " + salary);
            Console.ReadLine();
        }
        
        static void summaration(int first, int second)
        {
            Console.WriteLine("summaration conqulation is : " + (first + second));
            Console.ReadLine();
        }
        
        
        static int multiply(int first, int second, int third)
        {
            int result = (first * second * third);
            return result;
            
        }

        static string information(string name, string lastname)
        {
            return name + "  " + lastname;
        
        }
      
        static int takesquare(int number)
            {
                return number * number;
            }


    }
}
