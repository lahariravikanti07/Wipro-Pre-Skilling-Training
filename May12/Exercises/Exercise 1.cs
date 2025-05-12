using System;

// Step 1: Create the interface
public interface IDeviceControl
{
    void TurnOn();
    void TurnOff();
}

// Step 2: Implement the interface in SmartTV class
public class SmartTV : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("SmartTV is now ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("SmartTV is now OFF");
    }
}

// Step 2: Implement the interface in Speaker class
public class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("Speaker is now ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("Speaker is now OFF");
    }
}

// Step 3: Main program to test the functionality
public class Program
{
    public static void Main(string[] args)
    {
        // Create IDeviceControl references for both SmartTV and Speaker
        IDeviceControl tv = new SmartTV();
        IDeviceControl speaker = new Speaker();

        // Turn both devices ON
        tv.TurnOn();
        speaker.TurnOn();

        // Turn both devices OFF
        tv.TurnOff();
        speaker.TurnOff();
    }
}
