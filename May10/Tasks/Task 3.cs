using System;

class AreaCalculator
{
    // Area of a rectangle
    public double Area(double length, double breadth)
    {
        return length * breadth;
    }

    // Area of a circle
    public double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Area of a triangle
    public double Area(double baseLength, double height, bool isTriangle)
    {
        return 0.5 * baseLength  * height;
    }

    static void Main()
    {
        AreaCalculator calc = new AreaCalculator();

        // Rectangle: length = 10, breadth = 5
        double rectArea = calc.Area(10, 5);
        Console.WriteLine("Area of Rectangle: " + rectArea);

        // Circle: radius = 7
        double circleArea = calc.Area(7);
        Console.WriteLine("area of Circle: " + circleArea);

        // Triangle: base = 8, height = 4
        double triangleArea = calc.Area(8, 4, true);
        Console.WriteLine("Area of Triangle: " + triangleArea);
    }
}