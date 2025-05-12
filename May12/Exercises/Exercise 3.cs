using System;

// Step 1: Create an abstract class Book
abstract class Book
{
    //Abstract method
    public abstract void Read();

    // Concrete method
    public void GetInfo()
    {
        Console.WriteLine("This is a book");
    }
}

// Step 2: Derived class FictionBook
class FictionBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a fiction book");
    }
}

// Step 2: Derived class ScienceBook
class ScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a science book");
    }
}

// Step 3: Main method to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        // Book reference pointing to FictionBook object
        Book fiction = new FictionBook();
        fiction.GetInfo();
        fiction.Read();

        Console.WriteLine();  // Just for spacing

        // Book reference pointing to ScienceBook object
        Book science = new ScienceBook();
        science.GetInfo();
        science.Read();
    }
}