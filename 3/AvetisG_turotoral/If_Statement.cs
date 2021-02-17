using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();

            if (player.Equals("AI"))
            {
                Console.WriteLine("The palyer is AI.");
            }
            else if (player.Equals("Human"))
            {
                Console.WriteLine("The palyer is Human.");
            }
            else
            {
                Console.WriteLine("The palyer is not AI and not Human.");
            }
           
        }
    }
}
