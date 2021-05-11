using System;
using System.Collections.Generic;

namespace HomeSet14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>{"jollor", "indomie", "bread"};

            Console.WriteLine($"i like to eat {food[0]}");

            Console.WriteLine($"=========================");

            Console.WriteLine($"i also like to eat {food[1]}");

            Console.WriteLine($"=============================");

            Console.WriteLine($"i like to eat {food[2]} but a littel");

            Console.WriteLine($"=======================================");
        }
    }
}
