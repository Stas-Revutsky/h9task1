using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    internal class Square : Shape, IComparable
    {
        private double side;
        public double Side { get { return side; } set {  side = value; } }

        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return side * 4;
        }

        public override void Print()
        {
            Console.WriteLine($"It's a square with name {Name}, side {side}, " +
                $"area {Math.Round(Area(), 2)} and perimeter {Math.Round(Perimeter(), 2)}");
        }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
    }
}
