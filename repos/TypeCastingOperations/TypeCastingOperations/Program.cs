using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dichiarazione di PI Greco di tipo double*/
            double pi = 3.14;

            Console.WriteLine("PI Greco = " + pi);
            /*Casting di tipo da double a intero*/
            int integerPi = (int)pi;

            Console.WriteLine("PI Greco (intero) = " + integerPi);


            double num1 = 10.5;
            double num2 = 15;

            Console.WriteLine("Abs (num1) " + (Math.Abs(num1)));
            Console.WriteLine("Ceiling (num1) " + (Math.Ceiling(num1)));
            Console.WriteLine("Round (num1) " + (Math.Round(num1)));
            Console.WriteLine("Max (num1,num2) " + (Math.Max(num1, num2)));
            Console.WriteLine("Min (num1,num2) " + (Math.Min(num1, num2)));

            /*Operatore Random*/
            Random rand = new Random();

            /*rand.Next([inizio, fine[) per generare i prossimi numeri*/
            Console.WriteLine("Random number between 1 and 10 ->" + (rand.Next(1,11)));

            Console.ReadLine();
        }
    }
}
