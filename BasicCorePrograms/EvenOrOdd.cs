using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOrOdd
    {
        public static void EvenOdd()
        {
            Console.Write("Enter a Number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            if (no % 2 == 0)
            {
                Console.Write("Entered Number is Even Number");
            }
            else
            {
                Console.Write("Entered Number is Odd Number");
            }
            Console.Read();
        }
    }
}
