using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Operatori matematici elementari*/
            Console.WriteLine("2 + 2 = " + (2 + 2));
            Console.WriteLine("2 - 2 = " + (2 - 2));
            Console.WriteLine("2 * 2 = " + (2 * 2));
            Console.WriteLine("2 / 2 = " + (2 / 2));
            Console.WriteLine("2 % 2 = " + (2 % 2));

            int i = 0;
            /*Operatori di incremento e decremento*/
            Console.WriteLine("i++ = "+ (i++));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("++i = " + (++i)); 
            Console.WriteLine("--i = " + (--i));


            Console.ReadLine();
        }
    }
}
