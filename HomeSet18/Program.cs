using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeSet18
{
    class Program
    {
        static void Main(string[] args)
        {

            List<long> line = new List<long>{ 2999, 34, 50, 48, 44, 55, 7};
           
            long MinValue = line.Min();

            Console.WriteLine($"the smallest Number: {MinValue}");


            for (int i = 0; i < line.Count; i++)
            {
                if (MinValue == line[i])
                {
                    Console.WriteLine($"the smallest index: {i}");
                }
            }
        }
    }
}
