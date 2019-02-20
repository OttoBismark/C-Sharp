using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array of integers declaration*/
            int[] primeNumber = { 2, 3, 5, 7, 11 };

            /*Array of String declaration (with size)*/
            string[] friends = new string[3];
            friends[0] = "Al";
            friends[1] = "John";
            friends[2] = "Jack";


            Console.WriteLine(primeNumber[1]);
            Console.ReadLine();
        }
    }
}
