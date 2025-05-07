using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list  = new ArrayList();
        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        if (list.Contains("Apple"))
            Console.WriteLine("Found 'Apple' in the list.");
        else
            Console.WriteLine("Not found");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}