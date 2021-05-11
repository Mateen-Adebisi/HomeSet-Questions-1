using System;
using System.Collections.Generic;

namespace HomeSet11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Add = new List<int>{1, 2, 4, 5, 6, 67, 7, 8, 8};


            int  List = Add.Count - 1;
            int Ex;
            Ex = Add[0];
            Add[0] = List;
            List = Ex;

            Console.WriteLine("Swapping");
            Console.WriteLine("First Number: " + Add[0]);
            Console.WriteLine("Second Number: " + List);

            for (int i = 0; i < Add.Count; i++)
            {
                Console.Write(Add[i]);
            }

        }
    }
}
