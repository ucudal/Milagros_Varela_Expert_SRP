using System;

namespace SRP
{
    public class Book // Esta clase construye cada libro y colabora con Shelve enviándole la información.
    {

        public string Title { get ; set;}
        public string Author { get ; set;}
        public string Code { get ;  set;}

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    }
}
