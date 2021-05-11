using System;
using System.Collections.Generic;

namespace HomeSet1
{
    class Program
    {
        static void Main(string[] args)
        {
              List<string> Num = new List<string>();

            int studentScore;
            string grade;
            {
                Console.WriteLine("input your grade");
                studentScore = Convert.ToInt32(Console.ReadLine());
            }
            if (studentScore < 40)
            {
                grade = "F";
                Console.WriteLine($"you got {grade}");
                Num.Add(grade);
            }
            else if (studentScore >= 40 && studentScore <= 49)
            {
                grade = "D";
                Console.WriteLine($"you got {grade}");
                 Num.Add(grade);
            }
            else if (studentScore >= 50 && studentScore <= 59)
            {
                grade = "C";
                Console.WriteLine($"you got {grade}");
                 Num.Add(grade);
            }
            else if (studentScore >= 60 && studentScore <= 69)
            {
                grade = "B";
                Console.WriteLine($"you got {grade}");
                Num.Add(grade);
            }
            else if (studentScore >= 70)
            {
                grade = "A";
                Console.WriteLine($"you got {grade}");
                Num.Add(grade);
            }
            else
            {
                Console.WriteLine("your input is not recognized");
            }

        }
    }
}
