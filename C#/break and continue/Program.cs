﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_and_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 0; i <= 10; i++)
            {
                if (i == 7)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.ReadLine();
        
        }
    }
}
