using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    internal class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
