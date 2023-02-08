using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public static void VowelConsonant()
        {
            Console.WriteLine("Enter any Character ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || 
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " :is Vowel");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'z'))
            {
                Console.WriteLine(ch + ": is Consonant");
            }
            else
            {
                Console.WriteLine("Invalid ");
            }
        Console.ReadLine();
        }
    }
}
