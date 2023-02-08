using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapNumbers
    {
        public static void swapNumbers()
        {
            Console.WriteLine("Enter number1 :");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2 :");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBefore swap number1 is : " + no1 + " \nBefore swap number2 is : " + no2);

            int temp;
            temp = no1;
            no1 = no2;
            no2 = temp;
            Console.WriteLine("\nAfter Swap number1 is : " + no1 + " \nAfter Swap number2 is : " + no2);
            Console.ReadLine();
        }
    }
}
