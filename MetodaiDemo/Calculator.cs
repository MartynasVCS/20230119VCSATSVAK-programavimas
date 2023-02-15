using System;

namespace MetodaiDemo
{
    internal class Calculator
    {
        /// <summary>
        /// Returns the integer sum of two integer inputs
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns></returns>
        internal static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        // Rekursinė funkcija
        internal static void RecursiveRoot(double skaicius)
        {
            skaicius = Math.Sqrt(skaicius);
            Console.WriteLine(skaicius);
            // Pabandyti pakeisti į 'skacius > 0'
            if (skaicius > 1)
            {
                RecursiveRoot(skaicius);
            }
        }
    }
}
