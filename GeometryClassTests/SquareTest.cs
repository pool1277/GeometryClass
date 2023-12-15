using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryClass.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void SquareArea()
        {
            // arrange
            double sideLenth = 10;
            Rectangle square = new Square(sideLenth);

            // act
            double AreaAns = sideLenth * sideLenth;

            // assert
            Assert.AreEqual(AreaAns, square.Area());
        }

        [TestMethod()]
        public void SquarePerimeter()
        {
            // arrange
            double sideLength = 10;
            Rectangle square = new Square(sideLength);

            // act
            double PerimeterAns = sideLength * 4;

            // assert
            Assert.AreEqual(PerimeterAns, square.Perimeter());
        }

        [TestMethod()]
        public void SquareToString()
        {
            // arrange
            double sideLength = 10;
            Rectangle square = new Square(sideLength);

            // act
            string ToStringAns = "Type: Square, Perimeter: 40, Area: 100";

            // assert
            Assert.AreEqual(ToStringAns, square.ToString());
        }

        [TestMethod()]
        public void SquareSetEdge()
        {
            // arrange
            double sideLength = 10;
            Rectangle square = new Square(sideLength);

            // act
            square.Width = 180;

            // assert
            Assert.AreEqual(square.Width, square.Height);
            Assert.AreEqual(square.Height, 180);
            Assert.AreEqual(square.Area(), 32400);
            Assert.AreEqual(square.Perimeter(), 720);

        }


    }
}