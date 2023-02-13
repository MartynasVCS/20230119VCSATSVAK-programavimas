using System;

namespace IvedimasDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Įveskite teksto eilutę: ");
            string ivedimas = Console.ReadLine();
            Console.WriteLine($"Jūs įvedėte: {ivedimas}.");
            Console.WriteLine();

            // Galime nekurti kintamojo, bet taip yra sunkiau skaityti.
            Console.WriteLine("Įveskite teksto eilutę:");
            Console.WriteLine($"Jūs įvedėte: {Console.ReadLine()}.");
            Console.WriteLine();

            Console.Write("Įveskite pirmą skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite antrą skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Suma: {skaicius1 + skaicius2}");
            string penki = Convert.ToString(5);
            Console.WriteLine();

            Console.Write("Įveskite true arba false: ");
            bool trueFalse = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Įvedėte: {trueFalse}");
            Console.WriteLine();

            Console.Write("Įveskite simbolį: ");
            char simbolis = Convert.ToChar(Console.Read());
            Console.ReadLine(); // Šios eilutės reikia jeigu darome papildomą įvedimą po Console.Read()
            Console.WriteLine($"Įvedėte: {simbolis}");
            Console.Write("Įveskite dar ką nors: ");
            string papildomasIvedimas = Console.ReadLine();
            Console.WriteLine($"Įvedėte: {papildomasIvedimas}");
            Console.WriteLine();

            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.Write("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas yra {vardas} o amžius {amzius}");
            Console.WriteLine();

            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(5));
            Console.WriteLine(Math.Pow(5, 1/2));
            Console.WriteLine(Math.Pow(5, 2));
        }
    }
}
