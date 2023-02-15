using System;

namespace MetodaiDemo
{
    internal class Greetings
    {
        internal static void Greet()
        {
            Console.WriteLine("Hello to my fancy app!");
        }

        internal static void GreetUserByName(string name)
        {
            Console.WriteLine("------------------");
            Console.Write("| Labas ");
            Console.Write(name);
            Console.WriteLine(" |");
            Console.WriteLine("------------------");
        }

        internal static void GreetUserByNameAndSurname(string name, string surname)
        {
            Console.WriteLine($"Labas {name} {surname}");
        }
    }
}
