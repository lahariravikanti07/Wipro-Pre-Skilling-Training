using System;
using System.Threading;

class Program
{
    static void PrintMessage(object message)
    {
        string msg = (string)message;   // Cast to correct type
        Console.WriteLine("Message: " + msg);
    }
    static void Main()
    {
        Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        thread.Start("Hello from the thread");
    }


}