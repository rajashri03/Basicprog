using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgramming
{
    internal class LeapYear
    {
        public void FindLeapYEar()
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not leap Year");
            }
        }
    }
}
