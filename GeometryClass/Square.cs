using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClass
{
   public class Square : Rectangle
    {

        private double EdgeSize;

        public override double Height
        {
            get
            {
                return EdgeSize;
            }

            set
            {
                EdgeSize = value;
            }
        }

        public override double Width
        {
            get
            {
                return EdgeSize;
            }
            set
            {
                EdgeSize = value;
            }
        }

        public Square(double edgeSize)
        {
            Type = ShapeType.Square;
            EdgeSize = edgeSize;
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
