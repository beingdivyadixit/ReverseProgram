using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ReverseProgram
    {
        public static void ReverseNumber(int num)
        {
            int rem =0 , rev = 0;
            while (num != 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse = "+rev);
        }

        public static void ReverseWord(string word)
        {
            string rev = " ";
            char[] listOfChar = word.ToCharArray();
            for (int i=0; i<listOfChar.Length; i++)
            {
                rev = listOfChar[i] + rev;
            }

            Console.WriteLine("Reverse = "+ rev);

        }
     }
}
