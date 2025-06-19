using System.Collections.Generic;

namespace Biblioteka
{
    public static class BookStorage
    {
        public static List<Book> Books = new List<Book>();
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
    }
}
