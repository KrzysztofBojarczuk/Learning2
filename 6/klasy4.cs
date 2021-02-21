using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Człowiek adi = new Człowiek();
            Console.WriteLine(adi.imie);
            adi.imie = "Bartek";
            Console.WriteLine(adi.imie);


            Człowiek naz = new Człowiek();
            Console.WriteLine(naz.nazwisko);

            Człowiek adi2 = new Człowiek();
            Console.WriteLine(adi2.imie);

            adi.PrzedstawSie();
            adi2.PrzedstawSie();
            Console.ReadKey();
        }
    }
    class Człowiek
    {
        public string imie = "Adrian";
        public string nazwisko = "Kowalski";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imię " + imie);
        }
    }
}
