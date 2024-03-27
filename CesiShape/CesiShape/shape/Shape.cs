using System.Runtime.ConstrainedExecution;

namespace CesiShape.Shape
{
    public static class ShapeUtils
    {
        public static double area(IList<Shape> shapes)
        {
            double area = 0.0D;
            foreach (var shape in shapes)
            {
                area += shape.area();
            }

            return area;
        }

        public static double area(params Shape[] shapes)
        {
            double area = 0.0D;
            foreach(var shape in shapes)
            {
                area += shape.area();
            }

            return area;
        }
    }

    public interface Shape
    {
        double area();
    }
}