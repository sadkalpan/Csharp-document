using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_variable
{
    public class worker
    {
        //public int ıd;
        //public string name;
        //public string lastname;
        //public static int salary;
        private int ıd { get; set; }
        private string name { get; set; }
        private string lastname { get; set; }
        private static int salary { get; set; }
        static worker()
        {
            salary = 2500;
        }
        
        public worker(int _ıd, string _name, string _lastname)
        {
            ıd = _ıd;
            name = _name;
            lastname = _lastname;
        }
    
        public void showinfo()
        {
            Console.WriteLine("ıd: " + ıd);
            Console.WriteLine("name: " + name); 
            Console.WriteLine("lastname: " + lastname);
        }
        public void raise(int raise)
        {
            Console.WriteLine("you get a 1000 euro raise and now your salary is:  " + (salary + raise));
        }
    
    }
}
