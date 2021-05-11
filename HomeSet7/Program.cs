using System;
using System.Collections.Generic;

namespace HomeSet7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Odd = new List<string>();
            
            List<string> Even = new List<string>();

            List<string> Prime = new List<string>();

            Console.Write("Enter Defrent Numbers: ");
            string num = Console.ReadLine();

            foreach(var Num in num)
            {
                if(Num % 2 == 0)
                {
                    Even.Add(Num.ToString());
                }
                if (Num % 2 != 0)
                {
                    Odd.Add(Num.ToString());
                    Prime.Add(Num.ToString());
                }

                for (int i = 0; i < Odd.Count; i++)
                {
                    Console.WriteLine($"this is odd: {Odd[i]} ");
                }

                for (int i = 0; i < Even.Count; i++)
                {
                    Console.WriteLine($"this is Even: {Even[i]} ");
                }

                for (int i = 0; i < Prime.Count; i++)
                {
                    Console.WriteLine($"this is Prime: {Prime[i]} ");
                }

            }


        }
    }
}
