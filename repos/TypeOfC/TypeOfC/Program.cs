using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfC
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxInt = int.MaxValue;
            Console.WriteLine("Max int->" + maxInt);

            long maxLong = long.MaxValue;
            Console.WriteLine("Max int->" + maxLong);

            decimal maxDec = decimal.MaxValue;
            Console.WriteLine("Max int->" + maxDec);

            float maxFloat = float.MaxValue;
            Console.WriteLine("Max int->" + maxFloat);

            double maxDouble = double.MaxValue;
            Console.WriteLine("Max int->" + maxDouble);

            var name = "Valerio";

            Console.WriteLine("name è di tipo -> {0}", name.GetTypeCode());

            Console.ReadLine();
        }
    }
}
