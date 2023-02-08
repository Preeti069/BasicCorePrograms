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
            Console.WriteLine("1:Flipcoin \n2:Leap Year \n3:PowerOf2 \n4:HarmonicNumber \n5:Factors " +
                "\n6:QuotientAndReminder \n7:Swap Two Numbers \n8:EvenOrOdd");
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
                case 3:
                    Console.WriteLine("Entered Number to print Power Of two :");
                    PowerOf2.Power();
                    break;
                case 4:
                    Console.WriteLine("Finding Harmonic value till Nth number :");
                    HarmonicNumber.harmonicnumber();
                    break;
                case 5:
                    Console.WriteLine("Prime Factorization Program");
                    Factors.factors();
                    break;
                case 6:
                    Console.WriteLine("Quotient And Reminder Program :");
                    QuotientAndReminder.QuoientReminder();
                    break;
                case 7:
                    Console.WriteLine("Program to Swap Two Numbers :");
                    SwapNumbers.swapNumbers();
                    break;
                case 8:
                    Console.WriteLine("Program to Check Whether a Number is Even or Odd");
                    EvenOrOdd.EvenOdd();
                    break;
                default:
                    Console.WriteLine("Please enter number within range");
                    break;
            }
            Console.ReadLine();
        }
    }
}