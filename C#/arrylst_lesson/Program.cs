using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrylst_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList collections = new ArrayList();

            collections.Add("sadık");
            collections.Add("ahmet");
            collections.Add("mehmet");

            //collections.Remove("sadık");
            //int Count = collections.Count;
            //collections.Clear();
            //bool control = collections.Contains("sadık");
            //int indx = collections.IndexOf("ahmet");
            //collections.Insert(1, "ALPAN");
            //collections.Reverse();

            //foreach (var a in collections)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("which index: " + indx);
            //Console.WriteLine("are there in? " + control);
            //Console.WriteLine("the number of array..." + Count);

            ArrayList number = new ArrayList();

            number.Add(500);
            number.Add(1);
            number.Add(2);
            number.Add(8);
            number.Add(6);
            number.Add(100);

            //number.Sort();
            //string donustur = number.ToString();

            foreach (var s in number)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
