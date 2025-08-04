using System;
using OOPConsole;

namespace OOPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello,World!");
            // Program2 name1 = new Program2();
            // Program2 name2 = new Program2();
            // name1.Hello("Santiago");
            // name2.Hello("Taguro");

            Vehicle kotse1 = new Vehicle();
            Car kotse2 = new Car();
            Car kotse3 = new Car();
            
        }

    }
    public abstract class Vehicle
    {
        public abstract void Travel();
    }
    public class Car : Vehicle
    {

        public string wheels;
        public double color;
        public int price;
        public void UmaandarSa()
        {
            Console.WriteLine("Umaandar sa lupa");
        }
        public void InputData(string color, double price, int wheels)
        {
            this.color = color;
            this.price = price;
            this.wheels = wheels;
        }
        public void Introduce()
        {
            Console.WriteLine($"The Cars color is {color} with the price of P{price}, and it has {wheels} wheels.");
        }
        public void Passenger(string name)
        {
            Console.WriteLine($"welcome {name}!");
        }
        public void Passenger(int number)
        {
            if (number < 5)
            {
                Console.WriteLine($"kasya kayong {number}");
                return;
            }
            else
            {
                Console.WriteLine("Sobrang dami niyo na!");
            }
        }
        public override void Travel()
        {
            Console.WriteLine("Travel by land");
        }
    }
    
}