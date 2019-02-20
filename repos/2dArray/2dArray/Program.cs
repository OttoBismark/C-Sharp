using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix =
        {
            {1,2 },
            {3,4 }
        };

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine("-" + matrix[i,j]);
            }
        }

        /*Another way to declare a 2 dimentional array*/
        int[,] twoDimArray = new int[2, 3];

        Console.ReadLine();
    }
}

