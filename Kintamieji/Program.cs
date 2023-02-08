using System;

namespace Kintamieji
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Lietuviškos raidės console lange

            Console.WriteLine("Labas pasauli!");
            //Console.ReadKey(); // Ši eilutė skirta tam, kad paleidimo proceso metu console liktų atidaryta

            string vardas = "Martynas";
            string tusciasKintamasis;

            string pavarde = "???";
            int amzius = 34;
            float ugis = 1.91f;
            double svoris = 85.12345678912345;
            char simbolis = 'A';
            bool tiesa = true;
            bool melas = false;
            bool tusciasBool; // false
            int tusciasInt; // 0
            char tusciasChar; // '/0'
            string tusciasString; // null
            float tusciasFloat; // 0
            double tusciasDouble; // 0

            var kintamasis = 1; // kuriant kintamąjį privaloma nurodyti tipą
            kintamasis = 0; // vėliau perrašant reikšmę, tipas nenurodomas
        }
    }
}
