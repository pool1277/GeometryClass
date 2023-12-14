using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClass
{
    public interface IGeometry
    {
        ShapeType Type { get;}
        double Perimeter();
        double Area();
    }

     public enum ShapeType
    {
        CircularSector,
        Circle,
        Rectangle,
        Square
    }
}
