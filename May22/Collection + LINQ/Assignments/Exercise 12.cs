using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Create a list of names
        List<string> names = new List<string>
        {
            "Alice", "Bob", "Eve", "Oscar", "Uma", "Ian", "Charlie", "Andrew", "Olivia", "Victor"
        };

        // Step 2: Use LINQ to filter names starting with a vowel
        var vowelNames = names
            .Where(name => "AEIOU".Contains(char.ToUpper(name[0])))
            .ToList();

        // Step 3: Print the result
        Console.WriteLine("Names starting with a vowel:");
        foreach (var name in vowelNames)
        {
            Console.WriteLine(name);
        }
    }
}
