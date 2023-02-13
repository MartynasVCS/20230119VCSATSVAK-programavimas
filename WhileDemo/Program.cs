using System;

namespace WhileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // For ir While palyginimas
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int skaicius = 0;
            while (skaicius <= 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }

            // Ne visiškai geras pavyzdys, bet pusiau veikiantis pavyzdys
            // parodantis kaip apsisaugoti nuo netinkamo vartotojo įvedimo
            int ivedimas = 0;
            while (ivedimas <= 0)
            {
                try
                {
                    Console.Write("Įveskite naturalųjį skaičių: ");
                    ivedimas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Įvedėte skaičių {ivedimas}");
                } 
                catch
                {
                    Console.WriteLine("Įvedėte netinkamą reikšmę!");
                }
            }
        }
    }
}
