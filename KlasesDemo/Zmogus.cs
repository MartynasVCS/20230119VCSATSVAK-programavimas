using System;

namespace KlasesDemo
{
    internal class Zmogus
    {
        internal string vardas { get; }
        internal double ugis { get; }
        internal int amzius { get; }

        internal Zmogus()
        {

        }

        internal Zmogus(string vardas, double ugis, int amzius)
        {
            this.vardas = vardas;
            this.ugis = ugis;
            this.amzius = amzius;
        }

        internal Zmogus(string vardas)
        {
            this.vardas = vardas;
            this.ugis = ugis;
            this.amzius = amzius;
        }

        internal void Pasisveikina()
        {
            if (vardas == null)
            {
                Console.WriteLine("I was never given a name");
            }
            else
            {
                Console.WriteLine($"Labas, mano vardas yra {vardas}");
            }
        }

        internal virtual void PasakojaApieSave()
        {
            if (ugis == 0)
            {
                Console.WriteLine("Aš nežinau kas esu");
            }
            else
            {
                Console.WriteLine($"Mano ūgis yra {ugis}, mano amžius yra {amzius}");
            }
        }

        internal void Atsisveikina()
        {
            Console.WriteLine("Ate");
        }

        internal void AtsisveikinaSuKituZmogumi(string kitoZmogausVardas)
        {
            Console.WriteLine($"Ate {kitoZmogausVardas}");
        }
    }
}
