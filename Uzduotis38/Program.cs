using System;

namespace Uzduotis38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sukurkite bazinę klasę Gyvunas 
             * su protected kintamaisiais 
             * ir paveldinčia klase Gyvate. 
             * 
             * Paveldinčioje klasėje turi būti metodas, 
             * kuris išveda visus klasės kintamuosius į ekraną. 
             * 
             * Bazinės klasės konstruktorių 
             * panaudokite paveldinčioje klasėje. 
             * 
             * Išveskite paveldinčios klasės kintamuosius 
             * į ekraną.
             */

            Gyvate zaltys = new Gyvate("Žaltys", 4.5);
            zaltys.Spausdinti();
        }
    }

    internal class Gyvunas
    {
        protected string pavadinimas;

        internal Gyvunas(string pavadinimas)
        {
            this.pavadinimas = pavadinimas;
        }
    }

    internal class Gyvate : Gyvunas
    {
        protected double ilgis;

        internal Gyvate(string pavadinimas, double ilgis) : base(pavadinimas)
        {
            this.ilgis = ilgis;
        }

        internal void Spausdinti()
        {
            Console.WriteLine($"Gyvūno pavadinimas: {pavadinimas}, gyvūno ilgis: {ilgis}");
        }
    }
}
