using System;

namespace SRP
{
    public class Shelve
    {

        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public void ShelveBook(Book book, String sector, String shelve)
        {
            this.Book = book;
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}