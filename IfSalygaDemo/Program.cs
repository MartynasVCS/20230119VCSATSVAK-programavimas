using System;

namespace IfSalygaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int skaicius = 3;

            if (skaicius > 4)
            {
                Console.WriteLine("Taip");
            }
            Console.WriteLine("Tolimesnis kodas");

            // Jei tenkinant if sąlyga norime atlikti tik vieną veiksmą tai galime rašyti taip:
            if (5 > 4) Console.WriteLine("Valio!!!");
            // Arba šitaip
            if (5 > 4) 
                Console.WriteLine("Valio!!!");
            // Bet geriau taip nedaryti ;)

            string tekstas = "Šuo";
            if (tekstas == "Šuo")
            {
                Console.WriteLine("Šuo!!!");
            }

            Console.Write("Įveskite skaičių: ");
            int ivestasSkaicius = Convert.ToInt32(Console.ReadLine());
            if (ivestasSkaicius % 2 == 0)
            {
                Console.WriteLine($"Įvestas skaičius: {ivestasSkaicius}");
                Console.WriteLine($"Skaičius penktuoju laipsniu: {Math.Pow(ivestasSkaicius, 5)}");
            }

            Console.WriteLine("Pabaiga");

            if (true == true) { }
            else if (true) { }
            else if (true) { }
            else if (true) { }
            else if (true) { }
            else if (true) { }
            else if (true) { }
            else { }
        }
    }
}
