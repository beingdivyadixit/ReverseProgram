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
    }
}
