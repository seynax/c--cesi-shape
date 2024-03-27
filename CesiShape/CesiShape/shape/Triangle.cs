using System.Runtime.ConstrainedExecution;

namespace CesiShape.Shape
{
    public class Triangle : Shape
    {
        public double Side0;
        public double Side1;
        public double Side2;


        public Triangle(double side0, double side1, double side2)
        {
            this.Side0 = side0;
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double area()
        {
            var semiPerimeter = (this.Side0 + this.Side1 + this.Side2) / 2.0D;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - this.Side0) * (semiPerimeter - this.Side1) * (semiPerimeter - this.Side1) * (semiPerimeter - this.Side2));
            return area;
        }
    }
}