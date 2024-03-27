using System.Runtime.ConstrainedExecution;

namespace CesiShape.Shape
{
    public class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double area()
        {
            return this.Width * this.Height;
        }
    }
}