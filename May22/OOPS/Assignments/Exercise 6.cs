using System;
using System.Collections.Generic;

// 1. Abstract Animal class
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine($"{Name} is feeding. Feeding the animal.");
    }
}

// 2. Derived classes
public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion roars!");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Elephant trumpets!");
    }
}

public class Monkey : Animal
{
    public Monkey(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Monkey screeches!");
    }
}

// 3. Zoo class
public class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
        Console.WriteLine($"{animal.Name} added to the zoo.");
    }

    public void MakeAllSounds()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }

    public void FeedAllAnimals()
    {
        foreach (var animal in animals)
        {
            animal.Feed();
        }
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        Zoo zoo = new Zoo();

        Lion lion = new Lion("Leo", 5);
        Elephant elephant = new Elephant("Ella", 10);
        Monkey monkey = new Monkey("Momo", 3);

        zoo.AddAnimal(lion);
        zoo.AddAnimal(elephant);
        zoo.AddAnimal(monkey);

        Console.WriteLine("\n--- Making Sounds ---");
        zoo.MakeAllSounds();

        Console.WriteLine("\n--- Feeding Animals ---");
        zoo.FeedAllAnimals();
    }
}
