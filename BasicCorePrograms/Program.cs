using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1:Flipcoin \n2:Leap Year");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Flip Coin and print percentage of Heads and Tails :");
                    FlipCoin.flipcoin();
                    break;
                case 2:
                    Console.WriteLine("To Check given Year is Lear Year or Not :");
                    LeapYear.leapyear();
                    break;
                default:
                    Console.WriteLine("Please enter number within range");
                    break;
            }
            Console.ReadLine();
        }
    }
}