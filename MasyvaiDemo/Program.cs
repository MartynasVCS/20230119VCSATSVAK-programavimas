using System;
using System.Linq;

namespace MasyvaiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;

            // 0, 1, 2, 3, 4
            int[] skaiciuMasyvas = new int[5];

            // Spausdiname pagal indeksą
            Console.WriteLine(skaiciuMasyvas[0]);
            // Nėra reikšmės su indeksu 5
            //Console.WriteLine(skaiciuMasyvas[5]);

            skaiciuMasyvas[0] = 8;
            Console.WriteLine(skaiciuMasyvas[0]);

            string[] tekstoMasyvas = { "Labas", "Ate", "Sveiki", null, "Hi" };
            
            // Spausdiname visas masyvo reikšmes
            for (int i = 0; i < tekstoMasyvas.Length; i++)
            {
                Console.Write(tekstoMasyvas[i] + "\n");
            }
            Console.WriteLine();

            // Kitas būdas :D
            Console.WriteLine(tekstoMasyvas[0]); Console.WriteLine(tekstoMasyvas[1]);
            Console.WriteLine(tekstoMasyvas[2]);
            Console.WriteLine(tekstoMasyvas[3]);
            Console.WriteLine(tekstoMasyvas[4]);

            var masyvasCharSuDydziu = new char[3];
            var masyvasCharSuReiksmemis = new char[] { 'a', 'b', 'c'};
            // Analogiškas būdas 22 eilutėje esančiam bet su var
            //var masyvasCharSuReiksmemisBeNew = { 'a' };

            int[] pazymiai = new int[4];
            pazymiai[0] = 10;
            pazymiai[1] = 8;
            pazymiai[2] = 4;
            pazymiai[3] = 5;
            // Toliau tęsti negalime nes 42 eilutėje nurodėme dydį 2
            //pazymiai[2] = 

            int[] pazymiaiPagalReiksmes = { 10, 8, 4, 5 };
            // 42-44 eilučių bei 48 eilutės rezultatai yra analogiški
            
            // Paskutinė masyvo reikšmė
            Console.WriteLine(pazymiai.Last());
            Console.WriteLine(pazymiai[pazymiai.Length - 1]);

            // For palyginimas su foreach
            // Atspausdinkime teksto masyvą
            for (int i = 0; i < tekstoMasyvas.Length; i++)
            {
                Console.WriteLine(tekstoMasyvas[i]);
            }

            foreach (string tekstas in tekstoMasyvas)
            {
                Console.WriteLine(tekstas);
            }

            // Sumos algoritmas
            int suma = 0;
            for (int i = 0; i < pazymiai.Length; i++)
            {
                suma += pazymiai[i];
            }
            Console.WriteLine($"Pažymių suma: {suma}");

        }
    }
}
