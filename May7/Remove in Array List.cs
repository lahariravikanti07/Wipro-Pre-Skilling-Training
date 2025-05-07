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

        list.Remove(42); // Removes the element with value 5
        list.Remove(0); // Removes the element at index 0
        Console.WriteLine("Count after removal: " + list.Count);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}

// Remove can be done in 2 ways
       // One is by giving the name of the element
       // Second is by giving the index of the element 