using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Cat : Animal
    {
        public string Color { get; set; }

        public Cat()
        {
            Name = "";
            Weight = 0;
            Color = "";
        }

        public Cat(string name, double weight, string color) : base(name, weight)
        {
            Color = color;
        }

        public override void InputData()
        {
            Console.Write("Enter Cat Name: ");
            Name = Console.ReadLine() ?? "";

            Console.Write("Enter Cat Weight: ");
            Weight = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter Cat Color: ");
            Color = Console.ReadLine() ?? "";
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}, Color: {Color}");
        }
    }
}
