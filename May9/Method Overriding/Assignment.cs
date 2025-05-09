using System;

namespace ConsoleApp2{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("parent class draw");
        }
    }

    class Circle : Shape{
        public override void Draw()
        {
            Console.WriteLine("draw a circle");
        }
    }

    class Program{
        static void Main()
        {
            Circle cir = new Circle();
            cir.Draw();

            Shape shape = new Shape();
            shape.Draw();

            Shape sh = new Circle();
            sh.Draw();
        }
    }
}