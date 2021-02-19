using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnmal = new Animal("Bob");

            myAnmal.SetAnimalName("Fred");

            Console.WriteLine(myAnmal.Name);
        }
    }
    class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }
        public void SetAnimalName(string name)
        {
            Name = name;
        }
    }
}
