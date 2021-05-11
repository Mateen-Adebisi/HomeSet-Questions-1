using System;

namespace HomeSet15
{
    class Program
    {
        static void Main(string[] args)
        {
            //int f = 3;
            for (int i = 1; i <= 10; i++)
            {
                // if(Math.Pow(i, f) == 0)
                // {
                //     Console.WriteLine(i);
                // }
                // if (i % 8 == 0)
                // {
                //     Console.WriteLine(i);
                // }
                int total = i * i * i;
                Console.WriteLine(total);
            }
        }
    }
}
