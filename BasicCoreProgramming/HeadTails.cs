using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramming
{
    internal class HeadTails
    {
        public void CheckHeadTails()
        {
            int tailcount = 0, headcount = 0;
            Console.WriteLine("********Flip coin and print percentage**********");
            Console.WriteLine("Enter No. of times you want to flip the coin");
            int NumofCount = Convert.ToInt32(Console.ReadLine());

            Random randomobj = new Random();
            for (int i=0;i<NumofCount;i++)
            {
                double randomheadtail=randomobj.NextDouble();
                if(randomheadtail<0.5)
                {
                    Console.WriteLine("Tail");
                    tailcount++;
                }
                else
                {
                    Console.WriteLine("HEad");
                    headcount++;
                }
               
            }
            Console.WriteLine("------Percentage of Head vs Tail-------");
            double perOfHead = (headcount / NumofCount) * 100;
            Console.WriteLine("Percentage of head=" + perOfHead);
            double perOfTail = (tailcount / NumofCount) * 100;
            Console.WriteLine("Percentage of tail=" + perOfTail);
        }
    }
}
