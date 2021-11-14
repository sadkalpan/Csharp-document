using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numberofdoors = 2;
            //string colorofcars = "red";
            //string modelofcars = "ferrari";

            car Car = new car(4, "mercedes", "white");
            
            Console.WriteLine("the door number: " + Car.numberofdoors);
            Console.WriteLine("the color of car: " + Car.colorofcars);
            Console.WriteLine("model of car: " + Car.modelofcars);
            
            Car.opendoor();
            Car.startengine();
            
            

            Console.ReadLine();

        }
    }
}
