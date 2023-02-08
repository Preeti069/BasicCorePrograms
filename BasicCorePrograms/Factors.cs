using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Factors
    {
        public static void factors()
        {
            Console.WriteLine("Please enter any number to find Prime factors");
            int num = Convert.ToInt32(Console.ReadLine());
            //prime numbers starts from 2
            for (int div = 2; div * div <= num; div++)
            {
                while (num % div == 0)
                {
                    num = num / div;
                    Console.Write(div + " ");
                }
            }
            if (num != 1)
            {
                Console.Write(num);
            }
            Console.ReadLine();
        }
    }
}
