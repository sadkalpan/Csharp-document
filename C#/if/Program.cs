using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //Console.WriteLine("bir sayi giriniz: ");
            //int note = Console.ReadLine();
            int note = 70;
            if (note > 50)
            {
                Console.WriteLine("gectiniz");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("dersten kaldınız");
                Console.ReadLine();
            }
        */
            Console.WriteLine("enter your three exam notes: ");
            int note1 = Convert.ToInt32(Console.ReadLine());
            int note2 = Convert.ToInt32(Console.ReadLine());
            int note3 = Convert.ToInt32(Console.ReadLine());

            int notesAverages = (note1 + note2 + note3) / 3;

            if (100 > notesAverages && notesAverages > 80)
            {
                Console.WriteLine("you ger a AA ");
                Console.ReadLine();
            }
            else if(80 >= notesAverages && notesAverages > 50)
            {
                Console.WriteLine("you get bb");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("you gonna fail");
                Console.ReadLine();
            }
        }
    }
}
