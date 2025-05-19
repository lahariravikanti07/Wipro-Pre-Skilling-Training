using System;
using System.Collections.Generic;

namespace LibraryBookManagement
{
    // Book class with Title and Author
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"\"{Title}\" by {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Queue for borrowed books
            Queue<Book> borrowedBooks = new Queue<Book>();
            borrowedBooks.Enqueue(new Book("1984", "George Orwell"));
            borrowedBooks.Enqueue(new Book("To Kill a Mockingbird", "Harper Lee"));
            borrowedBooks.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            borrowedBooks.Enqueue(new Book("Pride and Prejudice", "Jane Austen"));
            borrowedBooks.Enqueue(new Book("Moby-Dick", "Herman Melville"));

            // Show and return the next borrowed book
            Console.WriteLine("Next borrowed book to be returned:");
            Console.WriteLine(borrowedBooks.Peek());
            Console.WriteLine("Returning the book...");
            borrowedBooks.Dequeue();

            // Stack for newly purchased books
            Stack<Book> newBooks = new Stack<Book>();
            newBooks.Push(new Book("The Silent Patient", "Alex Michaelides"));
            newBooks.Push(new Book("Where the Crawdads Sing", "Delia Owens"));
            newBooks.Push(new Book("Atomic Habits", "James Clear"));

            // Show and process the last purchased book
            Console.WriteLine("\nLast purchased book:");
            Console.WriteLine(newBooks.Peek());
            Console.WriteLine("Processing the book...");
            newBooks.Pop();

            // Display remaining borrowed books
            Console.WriteLine("\nRemaining borrowed books:");
            foreach (var book in borrowedBooks)
            {
                Console.WriteLine(book);
            }

            // Display remaining new books
            Console.WriteLine("\nRemaining new books:");
            foreach (var book in newBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
