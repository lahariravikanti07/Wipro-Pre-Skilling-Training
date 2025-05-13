using System;
using System.Collections.Generic;

namespace Linq_Practice.Practice1
{
    using System;

    // Define a custom delegate that has a string parameter and returns void.
    delegate void CustomDel(string s);

    class TestClass
    {
        // Define two methods that have the same signature as CustomDel.
        static void Hello(string s)
        {
            Console.WriteLine($" Hello, {s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($" Goodbye, {s}!");
        }

        static void Main()
        {
            // Declare instances of the custom delegate.
            CustomDel hiDel, byeDel, multiDel, multiMinusDel;

            hiDel = Hello;

            // Create the delegate object byeDel that references the
            // method Goodbye.
            byeDel = Goodbye;

            // The two delegates, hiDel and byeDel, are combined to form multiDel.
            //MULTICAST DELEGATE - SIMPLE INVOCATION
            multiDel = hiDel + byeDel;

            // Remove hiDel from the multicast delegate, leaving byeDel,
            // which calls only the method Goodbye.
            multiMinusDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusDel:");
            multiMinusDel("D");

        }
    }
}