using System;

namespace MetodaiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings.Greet();

            Console.Write("Įveskite savo vardą: ");
            string name = Console.ReadLine();
            Greetings.GreetUserByName(name);

            Console.Write("Įveskite savo pavardę: ");
            string surname = Console.ReadLine();
            Greetings.GreetUserByNameAndSurname(name, surname);

            int sum = Calculator.Sum(5, 7);
            Console.WriteLine(sum);
        }
    }
}
