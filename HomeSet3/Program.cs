using System;

namespace HomeSet3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Average = 50;
            int[] name = { 1, 3, 4, 4, 3, 5, 7, 8, 9, 4, 4, 65, 7 };

              foreach(var nam in name)
              {
                if (nam >= Average)
                {
                    Console.WriteLine($"Grade: {nam} = you Scored higher than Average");
                }
                else if(nam < Average)
                {
                    Console.WriteLine($"Grade: {nam} = you Scored below Average");
                }
              }
            
        }
    }
}
