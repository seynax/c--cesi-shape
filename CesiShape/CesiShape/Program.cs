using CesiShape.Shape;
using System.Runtime.InteropServices;

public static class Program
{
    public static double askDouble(String name)
    {
        Console.Write(name + " : ");
        double result = 0.0D;

        while(!Double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Enter valid number !");
        }

        return result;
    }

    public static void Main(String[] args)
    {
        IList<Shape> shapes = new List<Shape>();
        var isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Triangle[0], Circle[1], Rectangle[2], calculate[3]");

            switch(Console.ReadLine())
            {
                case "0":
                    var side0 = askDouble("side 0");
                    var side1 = askDouble("side 1");
                    var side2 = askDouble("side 2");
                    shapes.Add(new Triangle(side0, side1, side2));
                    break;
                case "1":
                    var radius = askDouble("radius");
                    shapes.Add(new Circle(radius));
                    break;
                case "2":
                    var width = askDouble("width");
                    var height = askDouble("height");
                    shapes.Add(new Rectangle(width, height));
                    break;
                case "3":
                    isRunning = false;
                    break;
            }
        }

        Console.WriteLine(ShapeUtils.area(shapes));
        Console.ReadLine();
    }
}