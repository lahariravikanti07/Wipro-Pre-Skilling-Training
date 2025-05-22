using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    // Book class
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string author, bool isAvailable)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Author: {Author}, Available: {IsAvailable}";
        }
    }

    // Library class
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding sample books
            library.AddBook(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", true));
            library.AddBook(new Book(2, "To Kill a Mockingbird", "Harper Lee", true));
            library.AddBook(new Book(3, "1984", "George Orwell", false));
            library.AddBook(new Book(4, "Animal Farm", "George Orwell", true));
            library.AddBook(new Book(5, "The Catcher in the Rye", "J.D. Salinger", true));

            // Search by author
            Console.WriteLine("Search results for author 'George Orwell':");
            var booksByOrwell = library.SearchByAuthor("George Orwell");
            foreach (var book in booksByOrwell)
            {
                Console.WriteLine(book);
            }

            // Search by title
            Console.WriteLine("\nSearch results for title containing 'the':");
            var booksWithTitle = library.SearchByTitle("the");
            foreach (var book in booksWithTitle)
            {
                Console.WriteLine(book);
            }
        }
    }
}
