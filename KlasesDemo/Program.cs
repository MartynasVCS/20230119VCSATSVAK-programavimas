using System;
using System.Collections.Generic;

namespace KlasesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zmogus zmogusPetras = new Zmogus("Petras", 1.65, 45);
            Zmogus zmogusMartynas = new Zmogus("Martynas", 1.98, 34);

            zmogusPetras.Pasisveikina();
            zmogusMartynas.Pasisveikina();
            Console.WriteLine();

            zmogusPetras.PasakojaApieSave();
            zmogusMartynas.PasakojaApieSave();
            Console.WriteLine();

            zmogusPetras.AtsisveikinaSuKituZmogumi(zmogusMartynas.vardas);
            zmogusMartynas.Atsisveikina();
            Console.WriteLine();

            List<Zmogus> zmones = new List<Zmogus>();
            zmones.Add(zmogusPetras);
            zmones.Add(zmogusMartynas);
            zmones.Add(new Zmogus("Paulius", 1.77, 18));
            zmones.Add(new Zmogus());

            zmones[2].Pasisveikina();
            zmones[3].Pasisveikina();
            zmones[3].PasakojaApieSave();
            Console.WriteLine();

            Studentas studentasAntanas = new Studentas("Antanas", 1.82, 29, 536641, "KTU");
            Studentas studentasJonas = new Studentas(536641, "KTU");
            studentasAntanas.Pasisveikina();
            studentasAntanas.PasakojaApieSave();
            Console.WriteLine();
        }
    }
}
