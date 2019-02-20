using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        /*Call the "SayHello() function"*/
        SayHello();
        HelloDude("Mark");
        int result = BringIt(2,3);
        Console.Write("Result ->"+ result);
        Console.ReadLine();
    }

    /*"SayHello()" body function*/
    static void SayHello()
    {
        Console.WriteLine("Hello, Dude");
    }

    /*"HelloDude()" body function*/
    static void HelloDude(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    /*"BringIt(a, b)" body function*/
    static int BringIt(int a, int b)
    {
        return a * b;
    }
    

}

