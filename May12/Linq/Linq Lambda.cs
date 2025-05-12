using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Anil", "Sharma", "Lucky", "Krishna", "Siva", "Naresh", "Suresh", "Suman" };

        // Using LINQ Queries
        UsingLINQExtensions(names);
    }

    private static void UsingLINQExtensions(string[] names)
    {
        IEnumerable<string> query = names
                                     .Where(s => s.Length == 5)
                                     .OrderBy(s => s)
                                     .Select(s => s.ToUpper());

        foreach (string item in query)
            Console.WriteLine(item);

        Console.Read();

    }
}