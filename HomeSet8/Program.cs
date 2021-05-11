using System;
using System.Collections.Generic;
using System.IO;

namespace HomeSet8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> myname = new List<string>();

            Console.WriteLine("Enter Numbers");
            string Min = Console.ReadLine();

            RefreshList();
            myname.Add(Min);

            for (int i = 0; i < myname.Count; i++)
            {
                Console.WriteLine(myname[i]);
            }

        } 
        
        public static void RefreshList()
        {
            List<string> vari = new List<string>();

            string[] aspirantsInFile = File.ReadAllLines("files//Mateen.txt");
            foreach (string aspirant in aspirantsInFile)
            {
                vari.Add(aspirant);
            }
        }
    }
}
