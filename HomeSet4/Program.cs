using System;

namespace HomeSet4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool iftrue = true;

            int[] occur = {1, 2, 4, 5, 6, 3, 6, 4, 4, 4, 5, 6, 3, 2, 3, 5};

    
            for (int i = 0; i < occur.Length; i++)
            {
                if (occur[0] == occur[i])
                {
                    Console.WriteLine(!iftrue);
                }
                else
                {
                    Console.WriteLine(iftrue);
                }
            }


        }
    }
}
