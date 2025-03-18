using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(string name) : base(name)
        {
            Console.WriteLine("Rectangle created");
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
        }
    }
}
