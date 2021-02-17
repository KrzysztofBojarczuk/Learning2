using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = new int[8];
            myInts[2] = 8;
            myInts[7] = 14;

            foreach(int myInt in myInts)
            {
                Console.WriteLine(myInt);
            }
           


        }
    }
}
