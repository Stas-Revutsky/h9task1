using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    internal class Circle : Shape, IComparable
    {
        private double radius;
        public double Radius { get { return radius; } set { radius = value; } }

        public override double Area()
        {
            return radius * Math.PI * 2;
        }
        public override double Perimeter()
        {
            return radius * Math.Pow(Math.PI, 2);
        }

        public override void Print()
        {
            Console.WriteLine($"It's a circle with name {Name}, radius {radius}, area" +
                $" {Math.Round(Area(), 2)} and perimeter {Math.Round(Perimeter(), 2)}");
        }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
    }
}
