using System;

namespace IsvedimasDemo
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

            int sudetisPriesDaugyba = (3 + 3) * 3;
            Console.WriteLine(3 + 3 * 3);

            int dalybaSveikojiDalis = 7 / 3;
            int dalybaLiekana = 7 % 3;
            Console.WriteLine($"Dalyba 7 iš 3, sveikoji dalis: {dalybaSveikojiDalis}, liekana: {dalybaLiekana}");

            // Dokumentacija apie explicit conversion
            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
            double dalybaRealioji = (double) 7 / 3;
            Console.WriteLine($"Reali dalyba 7 iš 3: {dalybaRealioji}");

            // Kintamjo reikšmės didinimas
            int skaicius = 5;

            // Žemiau pateiktos eilutės daro tą patį: padidina esamą reikšmę penketu
            skaicius = skaicius + 5;
            skaicius += 5;

            // Kintamojo didinimas/mažinimas vienetu
            Console.WriteLine();
            Console.WriteLine(skaicius);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius);

            skaicius = 15;
            Console.WriteLine();
            Console.WriteLine(skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(skaicius);
        }
    }
}
