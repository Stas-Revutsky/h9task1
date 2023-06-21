using System.Linq;

namespace homework8
{
    internal class Program
    {
        static void Main()
        {
            string fileDir = "D:\\Проекти\\C#course\\filteredShapes.txt";
            List<Shape> shapes = new();
            for (int i = 0; i < 2; i++) 
            {
                string? nameToAdd = "";
                do
                {
                    Console.WriteLine("enter square's name");
                    nameToAdd = Console.ReadLine();
                } while (nameToAdd == null);
                double sideToAdd = 0;
                a1:
                try
                {
                    Console.WriteLine("Enter square's side size");
                    sideToAdd = Convert.ToDouble(Console.ReadLine());
                } catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto a1;
                }

                shapes.Add(new Square(nameToAdd, sideToAdd));
            }
            for (int i = 0; i < 2; i++)
            {
                string? nameToAdd = "";
                do
                {
                    Console.WriteLine("enter circle's name");
                    nameToAdd = Console.ReadLine();
                } while (nameToAdd == null);
                double radiusToAdd = 0;
            a1:
                try
                {
                    Console.WriteLine("Enter circle's radius");
                    radiusToAdd = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto a1;
                }

                shapes.Add(new Circle(nameToAdd, radiusToAdd));
            }
            using StreamWriter sw = new StreamWriter(fileDir, true);
            IEnumerable<Shape> filteredByArea = shapes.Where(Shape => Shape.Area() >= 10 && Shape.Area() <= 100);
            foreach (Shape shape in filteredByArea)
            {
                sw.WriteLine($"The shape {shape.Name} has a fitting perimeter of {shape.Perimeter()}");
            }
            IEnumerable<Shape> filteredByName = shapes.Where(Shape => Shape.Name.Contains('a'));
            sw.WriteLine("----------------------------");
            foreach (Shape shape in filteredByName)
            {
                sw.WriteLine($"The shape's {shape.Name} name contains the letter a");
            }

            shapes.RemoveAll(Shape => Shape.Perimeter() < 5);

            foreach (Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}