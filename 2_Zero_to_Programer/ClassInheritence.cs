using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Bob";
            myDog.NumberOfLegs = 4;
            myDog.Bark();

            Console.WriteLine(myDog.Name);
        }
    }

    class Animal
    {
        public string things;
        public string Name { get; set; }
        public string Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }

        public void Eat()
        {

        }
    }

    class Dog : Animal
    {
       
        public int NumberOfLegs { get; set; }
        public void Bark()
        {
            things = "stuff";
            Console.WriteLine("Woof woof!");
        }
    }
}
