using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_class
{
    public class car
    {
        public int numberofdoors;
        public string modelofcars;
        public string colorofcars;

        public car(int nod, string moc, string coc)
        {
            numberofdoors = nod;
            modelofcars = moc;
            colorofcars = coc;
         
        }

        public void opendoor()
        {
            Console.WriteLine("the door is opening...");
        }
    
        public void startengine()
        {
            Console.WriteLine("the engine starting...");
        }
    
    
    }
}
