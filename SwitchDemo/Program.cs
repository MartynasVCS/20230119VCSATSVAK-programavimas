using System;

namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reiksme = "Katė";

            switch (reiksme)
            {
                case "šuo":
                    Console.WriteLine("Neteisingas");
                    break;
                case "Šuo":
                    Console.WriteLine("Teisingas!");
                    break;
                // default atvejis nėra privalomas
                default:
                    Console.WriteLine("Visi kiti atvejai");
                    break;
            }

            // Analogiškas atvejis su if
            if (reiksme == "šuo")
            {
                Console.WriteLine("Neteisingas");
            }
            else if (reiksme == "šuo")
            {
                Console.WriteLine("Teisingas!");
            }
            else
            {
                Console.WriteLine("Visi kiti atvejai");
            }
        }
    }
}
