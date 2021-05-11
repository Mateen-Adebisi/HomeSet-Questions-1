using System;
using System.Collections.Generic;

namespace HomeSet6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Prime = new List<int>();

            for (int i = 0; i <= 10; i++)
            {
                 if(i % 2 != 0)
                {
                    Prime.Add(i);
                   // Console.WriteLine(i);
                }
               
            }
        }
    }
}
