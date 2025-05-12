using System;

// Step 1: Create the interface
public interface IAnimalActions
{
    void Eat();
    void Sleep();
}

// Step 2: Implement the interface in the Lion class
public class Lion : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Lion is eating meat");
    }

    public void Sleep()
    {
        Console.WriteLine("Lion is sleeping");
    }
}

// Step 2: Implement the interface in the Elephant class
public class Elephant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }

    public void Sleep()
    {
        Console.WriteLine("Elephant is sleeping");
    }
}

// Step 3: Main method to test the classes
public class Program
{
    public static void Main(string[] args)
    {
        // Using IAnimalActions reference for Lion
        IAnimalActions lion = new Lion();
        lion.Eat();
        lion.Sleep();

        // Using IAnimalActions reference for Elephant
        IAnimalActions elephant = new Elephant();
        elephant.Eat();
        elephant.Sleep();
    }
}