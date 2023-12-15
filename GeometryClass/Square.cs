using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClass
{
   public class Square : Rectangle
    {
        private double sideLength;

        public override double Height
        {
            get
            {
                return sideLength;
            }

            set
            {
                sideLength = value;
            }
        }

        public override double Width
        {
            get
            {
                return sideLength;
            }

            set
            {
                sideLength = value;
            }
        }

        public Square(double length)
        {
            Type = ShapeType.Square;
            sideLength = length;
        }

        public override double Area()
        {
            return Height * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Height + Width);
        }
    }
}
