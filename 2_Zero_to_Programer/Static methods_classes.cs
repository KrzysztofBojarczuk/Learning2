using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Color = "Blur";
            Car myCar2 = new Car();
            myCar2.Color = "Red";

            Console.WriteLine(myCar.Color);
            Console.WriteLine(myCar2.Color);

            
            int total = Math.Add(5, 3);

           
            int total2 = Math.Add(6, 12);

            Console.WriteLine(total);
            Console.WriteLine(total2);
        }
    }
    class Car
    {
        public string Color { get; set; }
    }

    class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

}
