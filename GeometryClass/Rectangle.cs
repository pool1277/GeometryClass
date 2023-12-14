using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClass
{
    public class Rectangle : IGeometry
    {
        public ShapeType Type { get; protected set; } = ShapeType.Rectangle;

        public virtual double Height { get; set; }

        public virtual double Width { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public virtual double Area()
        {
            return Height * Width;
        }

        public virtual double Perimeter()
        {
            return 2 * (Height + Width);
        }

        public override string ToString()
        {
            string result = string.Format("Type: {0}, Perimeter: {1}, Area: {2}", Type.ToString(), Perimeter().ToString(), Area().ToString());
            return result;
        }
    }
}
