using System;

// Abstract class
abstract class Document
{
    // Abstract method
    public abstract void PrintContent();

    // Concrete method
    public void ShowDocumentType(string type)
    {
        Console.WriteLine($"Document Type: {type}");
    }
}

// Derived class: WordDocument
class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word document");
    }
}

// Derived class: PDFDocument
class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF document");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Document reference for WordDocument
        Document doc1 = new WordDocument();
        doc1.ShowDocumentType("Word");
        doc1.PrintContent();

        Console.WriteLine();

        // Using Document reference for PDFDocument
        Document doc2 = new PDFDocument();
        doc2.ShowDocumentType("PDF");
        doc2.PrintContent();
    }
}
