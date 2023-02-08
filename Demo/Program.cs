using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Mano vardas: Martynas");

            string vardas = "Martynas";
            Console.Write("Mano vardas: ");
            Console.WriteLine(vardas);

            Console.WriteLine("Mano vardas: " + vardas);

            Console.WriteLine("Mano vardas: {0} {1}", vardas, "Š"); // galima pateikti tiesiog reikšmę, nebūtinai kintamąjį

            Console.WriteLine($"Mano vardas: {vardas} {"Š"}"); // geriausias būdas ;)

            Console.WriteLine(); // tuščia eilutė
            Console.WriteLine("Naują eilutę galima \n įterpti ir taip");
            Console.WriteLine();
        }
    }
}
