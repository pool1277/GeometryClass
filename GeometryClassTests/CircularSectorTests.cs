using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryClass.Tests
{
    [TestClass()]
    public class CircularSectorTests
    {
        [TestMethod()]
        public void CircularSectorArea()
        {
            // arrange
            double Radius = 10;
            double Angle = 60;
            CircularSector circularSector = new CircularSector(Radius, Angle);

            // act
            double AreaAns = Radius * Radius * Math.PI* (Angle / 360);

            // assert
            Assert.AreEqual(AreaAns, circularSector.Area());
        }

        [TestMethod()]
        public void CircularSectorPerimeter()
        {
            // arrange
            double Radius = 10;
            double Angle = 60;
            CircularSector circularSector = new CircularSector(Radius, Angle);

            // act
            double PerimeterAns = 2 * Math.PI * Radius * (Angle / 360) + 2 * Radius;

            // assert
            Assert.AreEqual(PerimeterAns, circularSector.Perimeter());
        }

        [TestMethod()]
        public void CircularSectorToString()
        {
            // arrange
            double Radius = 10;
            double Angle = 60;
            CircularSector circularSector = new CircularSector(Radius, Angle); 

            // act
            string ToStringAns = "Type: CircularSector, Perimeter: 30.471975511966, Area: 52.3598775598299";

            // assert
            Assert.AreEqual(ToStringAns, circularSector.ToString());
        }

        [TestMethod()]
        public void CircularSectorSetAngle()
        {
            // arrange
            double Radius = 10;
            double Angle = 60;
            CircularSector circularSector = new CircularSector(Radius, Angle);

            // act
            circularSector.Angle = 180;

            // assert
            Assert.AreEqual(circularSector.Angle, 180);
            Assert.AreEqual(circularSector.Area(), 10 * 10 * Math.PI * 180.0 / 360);
            Assert.AreEqual(circularSector.Perimeter(), 2 * 10 * Math.PI * (180.0 / 360) + 2 * 10);
        }

        [TestMethod()]
        public void CircularSectorSetRadius()
        {
            // arrange
            double Radius = 5;
            double Angle = 60;
            CircularSector circularSector = new CircularSector(Radius, Angle);

            // act
            circularSector.Radius = 10;

            // assert
            Assert.AreEqual(circularSector.Radius, 10);
            Assert.AreEqual(circularSector.Area(), 10 * 10 * Math.PI * 60.0 / 360);
            Assert.AreEqual(circularSector.Perimeter(), 2 * 10 * Math.PI * (60.0 / 360.0) + 2 * 10);
        }

    }
}