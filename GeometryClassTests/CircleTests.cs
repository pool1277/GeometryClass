using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryClass.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleArea()
        {
            // arrange
            double radius = 5;
            CircularSector circle = new Circle(radius);

            // act
            double areaAns = radius * radius * Math.PI;

            // assert
            Assert.AreEqual(areaAns, circle.Area());
        }

        [TestMethod()]
        public void CirclePerimeter()
        {
            // arrange
            double radius = 5;
            CircularSector circle = new Circle(radius);

            // act
            double perimeterAns = 2 * Math.PI * radius;

            // assert
            Assert.AreEqual(perimeterAns, circle.Perimeter());
        }

        [TestMethod()]
        public void CircleToString()
        {
            // arrange
            double radius = 5;
            CircularSector circle = new Circle(radius); 

            // act
            string toStringAns = "Type: Circle, Perimeter: 31.4159265358979, Area: 78.5398163397448";

            // assert
            Assert.AreEqual(toStringAns, circle.ToString());
        }

        [TestMethod()]
        public void CircleSetAngle()
        {
            // arrange
            double radius = 5;
            CircularSector circle = new Circle(radius);

            // act
            circle.Angle = 180;

            // assert
            Assert.AreEqual(circle.Angle, 360);
        }

        [TestMethod()]
        public void CirculaSetRadius()
        {
            // arrange
            double radius = 5;
            CircularSector circle = new Circle(radius);

            // act
            circle.Radius = 10;

            // assert
            Assert.AreEqual(circle.Radius, 10);
            Assert.AreEqual(circle.Area(), 10 * 10 * Math.PI);
            Assert.AreEqual(circle.Perimeter(), 2 * 10 * Math.PI);
        }

    }
}