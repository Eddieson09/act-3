using System;

namespace Activity5
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape iskwer = new Square("Yellow", 10);
            iskwer.DisplayInfo();
            Console.WriteLine("Area." + iskwer.GetArea());
            iskwer.Dispose();

            Shape bilog = new Circle("Green", 5);
            bilog.DisplayInfo();
            Console.WriteLine("Area." + bilog.GetArea());
            bilog.Dispose();
        }
    }

    public abstract class Shape : IDisposable
    {
        public string Color { get; set; }
        public double Dimension { get; set; }

        public Shape(string color, double dimension)
        {
            Color = color;
            Dimension = dimension;
            Console.WriteLine("Shape Created");
        }

        public abstract double GetArea();
        public abstract string Name { get; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
            Console.WriteLine($"Color: {Color}");
        }

        public void Dispose()
        {
            Console.WriteLine("Shape Destroyed");
            GC.SuppressFinalize(this);
        }

        ~Shape()
        {
            Console.WriteLine("Shape Finalized");
        }
    }

    public class Square : Shape
    {
        public Square(string color, double sideLength) : base(color, sideLength) { }

        public override double GetArea()
        {
            return Dimension * Dimension;
        }

        public override string Name => "Square";
    }

    public class Circle : Shape
    {
        public Circle(string color, double radius) : base(color, radius) { }

        public override double GetArea()
        {
            return Math.PI * Dimension * Dimension;
        }

        public override string Name => "Circle";
    }
}