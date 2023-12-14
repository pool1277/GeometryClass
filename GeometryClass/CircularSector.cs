using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClass
{
    public class CircularSector : IGeometry
    {
        protected double angle = 0;

        public ShapeType Type { get; protected set;} = ShapeType.CircularSector;
        public double Radius { get;  set; }
        public virtual double Angle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
            }
        }

        public CircularSector()
        {

        }

        public CircularSector(double radius, double angle)
        {
            Radius = radius;
            Angle = angle;
        }

        public virtual double Perimeter()
        {
            return 2 * Math.PI * Radius * (Angle / 360) + 2 * Radius;
        }

        public virtual double Area()
        {
            return Radius * Radius * Math.PI * (Angle / 360);
        }

        public override string ToString()
        {
            string result = string.Format("Type: {0}, Perimeter: {1}, Area: {2}", Type.ToString(), Perimeter().ToString(), Area().ToString());
            return result;
        }
    }



}
