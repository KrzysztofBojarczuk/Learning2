using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal simpleExpression1 = 5 - 10;
            decimal simpleExpression2 = 4 * 10;
            decimal complexExpression = (((6 * 7) - 4) + simpleExpression1)/simpleExpression2;
            Console.WriteLine(simpleExpression1);
            Console.WriteLine(simpleExpression2);
            Console.WriteLine(complexExpression);
        }
    }
}
