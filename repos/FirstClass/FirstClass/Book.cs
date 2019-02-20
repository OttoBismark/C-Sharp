using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Book
    {
        /*Attributes*/
        private string title;
        private string author;
        private int pages;

        /*Book constructor*/
        public Book(string author, string title, int pages)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
        }

        /*Public Method getTitle()*/
        public string getTitle()
        {
            return title;
        }

        /*Public Method getAuthor()*/
        public string getAuthor()
        {
            return author;
        }

        /*Public Method getPages()*/
        public int getPages()
        {
            return pages;
        }
    }
}
