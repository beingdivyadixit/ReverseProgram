using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            ReverseProgram.ReverseNumber(num);
        }
    }
}
