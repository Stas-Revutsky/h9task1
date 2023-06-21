using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    public abstract class Shape : IComparable
    {
        private string name;
        public string Name { get { return name; } }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Perimeter();
        public abstract double Area();
        public abstract void Print();
        public virtual int CompareTo(object obj)
        {
            Shape? s1 = obj as Shape;
            if (s1 == null)
                throw new ArgumentException("Object is not a shape");
            else
                return this.Area().CompareTo(s1.Area());
        }
    }
}
