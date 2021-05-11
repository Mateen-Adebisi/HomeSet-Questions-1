using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeSet10
{
    class Program
    { 

        static void Main(string[] args)
        {

            List<long> main = new List<long> {1, 3, 2, 3, 2, 2, 3, 2, 2, 6, 655, 344, 2, 677 };

            long maxNum = main.Max();

            long minNum = main.Min();

            Console.WriteLine("Smallest Number = {0}", minNum);

            Console.WriteLine("Smallest Number = {0}", maxNum);

            Console.WriteLine(minNum * maxNum);


        }
        
    }
}
