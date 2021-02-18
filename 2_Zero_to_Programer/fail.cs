using System;

namespace ConsoleApp9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to reserve");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }

        public static string ReverseString(string input)
        {
            foreach (char c in input)
            {
                Console.Write(c);

            }

            return "";
        }
    }
}
