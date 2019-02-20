using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    /*Class Person*/
    class Person
    {
        /*Class attributes: name, surname*/
        private string name;
        private string surname;
        /*Public static attribute for the class Person*/
        public static int age = 18;

        /*Person constructor*/
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        /*class Property "getName"*/
        public string getName
        {
            get
            {
                return name;
            }
        }

        /*class Property "getSurname"*/
        public string getSurname
        {
            get
            {
                return surname;
            }
        }
    }
}
