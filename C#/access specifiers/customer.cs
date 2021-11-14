using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_specifiers
{
    class customer
    {
        public string name;

        public string lastname;

        public int salary;

        public string gender;

        private int age;

        public customer()
        {
            Console.WriteLine("müşteri sınıfının yapcı metodu çalıştı.");
        }
        public void customerinfo()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("lastname: " + lastname);
            Console.WriteLine("salary: " + salary);
            Console.WriteLine("gender: " + gender);
            //Console.WriteLine("age: " + age);
        }

        private void namelastname(string cname, string clastname)
        {
            Console.WriteLine("customer name/lastname: " + cname + "  " + clastname);
        }


    }
}
