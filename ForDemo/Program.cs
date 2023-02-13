using System;

namespace ForDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                // Čia rašom veiksmus norim atlikti
                Console.WriteLine("Labas");
            }

            for (int i = 0; i < 25; i += 5)
            {
                // Čia rašom veiksmus norim atlikti
                Console.WriteLine("Ate");
            }

            for (double i = 1000000; i > 5; i = Math.Sqrt(i))
            {
                // Čia rašom veiksmus norim atlikti
                Console.WriteLine(i);
            }

            // amžinas ciklas
            for (int i = 0; i >= 0; i++)
            {
                // Čia rašom veiksmus norim atlikti
                Console.WriteLine("Kada pabaiga?");
            }

            /* 
             * Rasti visų skaičių, 
             * žemesnių už 1000 ir 
             * didesnių už 0 
             * bei kurie dalinasi iš 
             * 3 arba 5
             * sumą.
             */

            int suma = 0;

            for (int i = 0; i < 1000; i++ )
            {
                if ( i % 3 == 0 || i % 5 == 0 )
                {
                    suma += i;
                }
            }
            
            Console.WriteLine(suma);
        }
    }
}
