using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Rectangle
    {
        private double length = 1.0;
        private double width = 1.0;

        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0.0 && value < 20.0)
                    length = value;
                else
                    Console.WriteLine("Invalid length. Must be > 0.0 and < 20.0");
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0.0 && value < 20.0)
                    width = value;
                else
                    Console.WriteLine("Invalid width. Must be > 0.0 and < 20.0");
            }
        }

        public double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public double GetArea()
        {
            return length * width;
        }
    }
}
