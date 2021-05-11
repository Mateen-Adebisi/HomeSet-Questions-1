using System;

namespace HomeSet17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Any Number : ");
                string UserInput = Console.ReadLine();

                UserInput = UserInput.Replace(" ", string.Empty);

                do
                {
                    Console.Write(UserInput[0] + " Occurs ");
                    
                    int trials = 0;

                    for (int i = 0; i < UserInput.Length; i++)
                    {
                        if (UserInput[0] == UserInput[i])
                        {
                            trials++;
                        }
                    }
                    Console.WriteLine($"{trials} times");
                    UserInput = UserInput.Replace(UserInput[0].ToString(), string.Empty);
                }
                while (UserInput.Length > 0);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
