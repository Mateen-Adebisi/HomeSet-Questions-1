using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeSet12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();

                
           int n,i,j=0,lrg,lrg2nd;

           Console.WriteLine("Enter The Element of the array");
           string  hig = Console.ReadLine();

           Console.WriteLine("input {0} Elements in  List:\n",n);

           for(i = 0; i<n; i++)
           {
               Console.WriteLine("Elements - {0} :",i);
               num[i] = Convert.ToInt32(Console.ReadLine());
           }

           lrg = 0;

           for (i=0;i<n;i++)
           {
               if(lrg< num[i])
               {
                   lrg= num[i];
                   j=i;
               }
           }

           lrg2nd=0;
           for (i=0;i<n;i++)
           {
               if(1==j)
               {
                  i++;
                  i--;
               }
               else
               {
                   if(lrg2nd<num[i])
                   {
                       lrg2nd=num[i];
                   }
               }
           }

        //     lrg3nd=0;
        //    for (i=0;i<n;i++)
        //    {
        //        if(1==j)
        //        {
        //           i++;
        //           i--;
        //        }
        //        else
        //        {
        //            if(lrg3nd<num[i])
        //            {
        //                lrg3nd=num[i];
        //            }
        //        }
        //    }

           Console.WriteLine("The second Largest Element in the List is : {0}\n\n",lrg2nd);
          
             




        }
    }
}
