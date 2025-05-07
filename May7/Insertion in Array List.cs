using System;
using System.Collections;

class Program
{

    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        list.Insert(1, "Inserted");
        Console.WriteLine("Element at index 1: " + list[1]); // Output Inserted

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}