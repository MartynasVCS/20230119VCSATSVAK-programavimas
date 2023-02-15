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

            // Naudojant for ciklą
            for (int i = 0; i < pazymiai.Length; i++)
            {
                suma += pazymiai[i];
            }
            Console.WriteLine($"Pažymių suma: {suma}");

            // Naudojant foreach
            suma = 0;
            foreach (int pazymys in pazymiai)
            {
                suma += pazymys;
            }
            Console.WriteLine($"Pažymių suma: {suma}");

            // Suma be ciklo
            Console.WriteLine($"Pažymių suma: {pazymiai.Sum()}");

            // Min/Max algoritmas
            int didziausiasPazymys = pazymiai[0];
            for (int i = 0; i < pazymiai.Length; i++)
            {
                if (i > didziausiasPazymys)
                {
                    didziausiasPazymys = i;
                }
            }
            Console.WriteLine($"Didžiausias pažymys: {didziausiasPazymys}");

            // Min/Max paprastuoju būdu
            Console.WriteLine($"Didžiausias pažymys: {pazymiai.Max()}");
            Console.WriteLine($"Mažiausias pažymys: {pazymiai.Min()}");
            Console.WriteLine($"Pažymių vidurkis: {pazymiai.Average()}");

            // Kas daugiau '3 Paskaita 45 skaidrė'

            if ('#' > '%')
            {
                Console.WriteLine("'#' yra daugiau už '%'");
            } else
            {
                Console.WriteLine("'%' yra daugiau už '#'");
            }

            Console.WriteLine(Convert.ToInt32('#'));
            Console.WriteLine(Convert.ToInt32('%'));

            // Užduotis 25 pavyzdys
            string ivedimas = Console.ReadLine();
            string[] ivedimasIsskaidytas = ivedimas.Split(' ');
            int[] ivedimasSkaiciai = new int[ivedimasIsskaidytas.Length];
            for (int i = 0; i < ivedimasSkaiciai.Length; i++)
            {
                ivedimasSkaiciai[i] = Convert.ToInt32(ivedimasIsskaidytas[i]);
            }

            Console.WriteLine(ivedimas);
        }
    }
}
