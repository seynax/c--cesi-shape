using System.Runtime.ConstrainedExecution;

namespace CesiShape.Shape
{
    public class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}