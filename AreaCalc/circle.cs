using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    internal class Circle : Shape
    {
       

        public Circle(string name) : base(name)
        {
           
        }

        public override void Display()
        {
            Console.WriteLine("being displayed here:" + CalculateArea());
        }

        public override double CalculateArea()
        {
            return 0;
        }
    }
}
