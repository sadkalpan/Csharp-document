using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //animal a = new animal();

            //a.animal_name = "boncuk";
            //a.animal_gender = "male";
            //a.animal_color = "white";
            //a.animal_age = 3;

            //a.showanimalinfo();

            cat c = new cat();

            c.animal_name = "pamuk";
            c.animal_gender = " female";
            c.animal_color = "brown";
            c.animal_age = 5;
            c.showanimalinfo();

            Console.ReadLine();
        }
    }
}
