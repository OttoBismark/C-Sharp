using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The instance of the book's class with the constructor*/
            Book book = new Book("Stephen King", "Shining", 200);

            Console.WriteLine(book.getAuthor() + ", "+book.getTitle()+", "+book.getPages());

            Person p1 = new Person("Valerio", "Valentino");
            Console.Write(p1.getName + ", " + p1.getSurname);
            Console.Write("Age : " + Person.age);
            Console.WriteLine();

            /*New instance of Mother Class*/
            Mother m = new Mother("Bubba");
            /*New instance of Daughter Class, derived by the Mother Class*/
            Daughter d = new Daughter("Forrest", "Gump");
            Console.Write("mother's name -> " + m.getName);
            Console.WriteLine();
            Console.Write("daughter's name -> " + d.getName + "... and second name -> " + d.getSecondName);

            Console.ReadLine();
        }
    }
}
