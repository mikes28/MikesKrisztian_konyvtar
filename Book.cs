using System;
using System.Linq;

namespace _0307
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int PageCount { get; }
        public int ReleaseYear { get; }

        public Book(string title, string author, int pageCount, int releaseYear)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
            ReleaseYear = releaseYear;
        }

        public static Book GetBookByTitle(string title, Book[] books)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;

        }

        public void EditBookData(string newTitle, string newAuthor, int newPageCount, int newReleaseYear)
        {
            Book updatedBook = new Book(newTitle, newAuthor, newPageCount, newReleaseYear);
            Console.WriteLine($"Edited Book: {updatedBook}");
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, PageCount: {PageCount}, ReleaseYear: {ReleaseYear}";
        }
    }
}