﻿using System;
using System.Collections.Generic;

namespace HomeSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Numbers = new List<string>{ "1", "2", "4", "3", "5", "6", "5", "3", "5", "6" };

            Numbers.Reverse();
            //Console.WriteLine(Numbers);

            for (int i = 0; i < Numbers.Count; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
        }
    }
}
