using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PalindromeProgram
    {
        public static void PalindromeNumber(int num)
        {
            int rem =0 , rev = 0;
            while (num != 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            //Console.WriteLine("Reverse = "+rev);
            if (num==rev)
            {
                Console.WriteLine("its Palindrome");
            }
            else
            {
                Console.WriteLine("it's not a Palindrome");
            }
        }

        public static void PalindromeWord(string word)
        {
            string rev = " ";
            char[] listOfChar = word.ToCharArray();
            for (int i=0; i<listOfChar.Length; i++)
            {
                rev = listOfChar[i] + rev;
            }

          //  Console.WriteLine("Reverse = "+ rev);

            if (word == rev)
            {
                Console.WriteLine("its Palindrome");
            }
            else
            {
                Console.WriteLine("it's not a Palindrome");
            }
        }
     }
}
