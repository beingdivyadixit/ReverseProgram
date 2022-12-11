using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Number & Press 2 For Word ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
               case 1:
                    Console.WriteLine("Please enter the Number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    PalindromeProgram.PalindromeNumber(num);
                    break; 
                case 2:
                    Console.WriteLine("Please Word the Number");
                    string word = Console.ReadLine();
                    PalindromeProgram.PalindromeWord(word);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
