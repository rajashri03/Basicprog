using System;

namespace BasicCoreProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select Option\n1)FlipCoin\n2)LeapYear");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        HeadTails headTailsobj = new HeadTails();
                        headTailsobj.CheckHeadTails();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.FindLeapYEar();
                        break;
                }
            }
        }
    }
}
