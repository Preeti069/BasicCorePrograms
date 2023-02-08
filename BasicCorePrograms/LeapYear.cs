using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public static void leapyear()
        {
            Console.WriteLine("Enter any year to check leap status");
            int leap = Convert.ToInt32(Console.ReadLine());
            if ((leap % 4 == 0) || (leap % 100 == 0))
            {
                Console.WriteLine($"{leap} is a Leap Year!");
            }
            else
            {
                Console.WriteLine($"{leap} is NOT a Leap Year!");
            }
            Console.ReadLine();
        }
    }
}
