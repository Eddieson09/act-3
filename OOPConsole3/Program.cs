using System;
namespace OOPConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape iskwer = new Square();
            iskwer.setData("Red", 5);
            iskwer.displayInfo();
            Shape bilog = new Circle();
            bilog.setData("Blue", 3);
            bilog.displayInfo();
        }
    }
    public interface Shape
    {
        double getArea(); 
        void displayInfo(); 
        void setData(string color, double sideLength); 
    }
    public class Square : Shape 
    {
        public string color;
        public double sideLength;
        public void setData(string color, double sideLength)
        {
            this.color = color;
            this.sideLength = sideLength;
        }

        public double getArea()
        {
            return sideLength * sideLength;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Color: {color}, Area: {getArea()}");
        }


    }
    public class Circle : Shape 
    {
        public string color;
        public double radius;
        public void setData(string color, double radius)
        {
            this.color = color;
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Color: {color}, Area: {getArea()}");
        }
    }
}