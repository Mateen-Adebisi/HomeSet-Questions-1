using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeSet13
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> search = new List<string> { "mateen", "123456", "fareed" };

            Console.WriteLine("Enter the regisdtrationNum");
            string input = Console.ReadLine();

            foreach (var searchs in search)
            {
                if (search[1].Trim() == input)
                {

                    Console.WriteLine(searchs);
                }
                else if (search == null)
                {
                    Console.WriteLine("Item Not Found");
                    break;
                }
                else
                {
                    Console.WriteLine("Item Not Found");
                    break;
                }
            }
        }
    }

}
