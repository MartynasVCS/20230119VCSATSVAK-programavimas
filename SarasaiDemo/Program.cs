using System;
using System.Collections.Generic;
using System.Linq;

namespace SarasaiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vardai = new List<string>();
            vardai.Add("Paulius");
            vardai.Add("Klemenesas");

            List<int> pazymiai = new List<int> { 10, 9, 8, 6, 9 };
            pazymiai.Add(10);

            List<char> simboliai = new List<char>
            {
                'm',
                'a',
                'r'
            };

            // Masyvo ir sąrašo skirtumai
            int[] masyvas = new int[] { 1, 2, 3, 4, };

            // Ilgis
            Console.WriteLine(masyvas.Length);
            Console.WriteLine(pazymiai.Count);

            // Reikšmių pasiekimas
            Console.WriteLine(masyvas[0]);
            Console.WriteLine(pazymiai[0]);

            // Atsitiktinis dydis
            Console.WriteLine();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(random.Next(15, 18));
            }

            // Kas yra string?
            string fraze = "SveikiGyvi";
            char[] frazesRaides = fraze.ToCharArray();

            Console.WriteLine(frazesRaides.Length);
            Console.WriteLine(fraze.Length);
        }
    }
}
