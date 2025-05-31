using System;
using System.Collections.Generic;

class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string isbn, string title)
    {
        ISBN = isbn;
        Title = title;
        IsBorrowed = false;
    }
}

class Student
{
    public string Name { get; set; }
    public Dictionary<Book, DateTime> BorrowedBooks { get; set; }

    public Student(string name)
    {
        Name = name;
        BorrowedBooks = new Dictionary<Book, DateTime>();
    }

    public void BorrowBook(Book book, DateTime dueDate)
    {
        BorrowedBooks[book] = dueDate;
    }

    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.ContainsKey(book))
        {
            BorrowedBooks.Remove(book);
        }
    }
}

class Library
{
    private List<Book> books = new List<Book>();
    private List<Student> students = new List<Student>();

    public void AddBook(string isbn, string title)
    {
        books.Add(new Book(isbn, title));
        Console.WriteLine($"Book '{title}' added.");
    }

    public void DeleteBook(string isbn)
    {
        Book book = books.Find(b => b.ISBN == isbn);
        if (book != null && !book.IsBorrowed)
        {
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' deleted.");
        }
        else
        {
            Console.WriteLine("Book not found or currently borrowed.");
        }
    }

    public void RegisterStudent(string name)
    {
        students.Add(new Student(name));
        Console.WriteLine($"Student '{name}' registered.");
    }

    public void BorrowBook(string studentName, string isbn, int daysToReturn)
    {
        Student student = students.Find(s => s.Name == studentName);
        Book book = books.Find(b => b.ISBN == isbn);

        if (student != null && book != null && !book.IsBorrowed)
        {
            book.IsBorrowed = true;
            DateTime dueDate = DateTime.Now.AddDays(daysToReturn);
            student.BorrowBook(book, dueDate);
            Console.WriteLine($"{studentName} borrowed '{book.Title}' (Due: {dueDate.ToShortDateString()})");
        }
        else
        {
            Console.WriteLine("Borrow failed. Book may not be available or student not registered.");
        }
    }

    public void ShowBorrowedBooks()
    {
        foreach (var student in students)
        {
            foreach (var entry in student.BorrowedBooks)
            {
                Console.WriteLine($"{student.Name} borrowed '{entry.Key.Title}' (Due: {entry.Value.ToShortDateString()})");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        // Sample interactions
        library.AddBook("001", "C# Programming");
        library.AddBook("002", "Data Structures");

        library.RegisterStudent("Alice");
        library.RegisterStudent("Bob");

        library.BorrowBook("Alice", "001", 14);
        library.BorrowBook("Bob", "002", 7);

        Console.WriteLine("\n--- Borrowed Books ---");
        library.ShowBorrowedBooks();

        Console.WriteLine("\nTrying to delete borrowed book:");
        library.DeleteBook("001");  // Should not delete

        Console.WriteLine("\nDeleting available book:");
        library.DeleteBook("003");  // Should fail (not found)

        Console.ReadLine();
    }
}
