using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_app
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            student Student = new student(1903021041, "sadik", "ALPAN", 50, 80, 90, "BEYKENT");
 
            while(control)
            {
                Console.WriteLine("welconme to our app... please choose the process number.");
                showinfo();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Student.studentinfo();
                        break;

                    case "2":
                        double stav = Student.notecalculator();
                        Console.WriteLine("student note average: " + stav);
                        break;

                    case "3":
                        Student.scname();
                        break;

                    case "4":
                        Console.WriteLine("quiting");
                        control = false;
                        break;
                }
            }
        }

        static void showinfo()
        {
            Console.WriteLine("press 1 show student information: ");
            Console.WriteLine("press 2 show student average note: ");
            Console.WriteLine("press 3 show student's school name: ");
            Console.WriteLine("press 4 quit");
        }

    }
}
