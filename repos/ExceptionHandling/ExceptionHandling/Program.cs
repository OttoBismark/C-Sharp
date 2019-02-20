using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Try-catch block*/
            try //If you try to attempt an error(for example, divided by zero, catch the error)
            {
                Console.Write("Insert first number ->");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert second number ->");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write(num1 / num2);
            }
            catch (Exception e) /*Catch the handling exception*/
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
