using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_specifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //public -- private -- protect(bunu anlamak için inheritance yi anlama gerek once) -- internal

            customer Customer = new customer();

            Customer.name = "sadik";
            Customer.lastname = "ALPAN";
            Customer.salary = 15000;
            Customer.gender = "male";
            //Customer.age = 21;
            Customer.customerinfo();

            Console.ReadLine();
        }
    }
}
