using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClass
{
    public class Circle : CircularSector
    {
        public override double Angle
        {
            get
            {
                return angle;
            }
             set
            {
                throw new Exception();
            }
        }

        public Circle(double radius)
        {
            Type = ShapeType.Circle;
            Radius = radius; 
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

    }
}
