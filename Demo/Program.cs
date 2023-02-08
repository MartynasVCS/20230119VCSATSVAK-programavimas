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

            int sudetisPriesDaugyba = (3 + 3) * 3;
            Console.WriteLine(3 + 3 * 3);

            int dalybaSveikojiDalis = 7 / 3;
            int dalybaLiekana = 7 % 3;
            Console.WriteLine($"Dalyba 7 iš 3, sveikoji dalis: {dalybaSveikojiDalis}, liekana: {dalybaLiekana}");

            double dalybaRealioji = (double) 7 / 3;
            Console.WriteLine($"Reali dalyba 7 iš 3: {dalybaRealioji}");
        }
    }
}
