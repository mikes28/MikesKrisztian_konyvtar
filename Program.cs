using System;

namespace _0307
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new("Book1", "Author1", 300, 2001),
                new("Book2", "Author2", 400, 2002),
                new("Book3", "Author3", 500, 2003)
            };

            Book book = Book.GetBookByTitle("Book2", books);
            if (book == null)
            {
                Console.WriteLine("No book found");
            }
            else
            {
                Console.WriteLine(book.ToString());
            }
            if (book != null)
            {
                book.EditBookData("NewBook2", "NewAuthor2", 450, 2022);
            }
        }
    }
}