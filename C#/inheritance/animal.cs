using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class animal
    {
        public string animal_name;
        public string animal_gender;
        public string animal_color;
        public int animal_age;

        public void showanimalinfo()
        {
            Console.WriteLine("animal name: " + animal_name);
            Console.WriteLine("animal gender: " + animal_gender);
            Console.WriteLine("animal color: " + animal_color);
            Console.WriteLine("animal age:" + animal_age);
        }
    }
}
