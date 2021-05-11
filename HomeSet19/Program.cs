using System;
using System.Collections.Generic;

namespace HomeSet19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Num = new List<int>();

            Console.WriteLine("Enter Seroes of numbers");
            string InputMan = Console.ReadLine();

            string[] userop = InputMan.Split("-");

            for (int i = 0; i < userop.Length; i++)
            {
                int num = Convert.ToInt32(userop[i]);
                Num.Add(num);
            }
            if(Num[0] > Num[1] && Num[1] < Num[2] || Num[0] < Num[1] && Num[1] > Num[2])
            {
                Console.WriteLine("The List is arranged in no Special order");
            }
            else if(Num[0] > Num[1])
            {
                Console.WriteLine("The List is arranged in no Accending order");
            }
            else if(Num[1] > Num[0])
            {  
                Console.WriteLine("The List is arranged in no decending order");
            }
        
        }
    }
}
