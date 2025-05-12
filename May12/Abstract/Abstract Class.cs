abstract class Shape
{
    public abstract void Draw(); // Abstract method
    public void Display()
    {
        Console.WriteLine("This is a shape");
    }
}

class Circle : Shape{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle";)
    }
}

class Program{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Draw();
    }
}