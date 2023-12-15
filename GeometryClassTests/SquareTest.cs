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
            double Edge = 10;
            Rectangle square = new Square(Edge);

            // act
            double AreaAns = Edge * Edge;

            // assert
            Assert.AreEqual(AreaAns, square.Area());
        }

        [TestMethod()]
        public void SquarePerimeter()
        {
            // arrange
            double Edge = 10;
            Rectangle square = new Square(Edge);

            // act
            double PerimeterAns = Edge * 4;

            // assert
            Assert.AreEqual(PerimeterAns, square.Perimeter());
        }

        [TestMethod()]
        public void SquareToString()
        {
            // arrange
            double Edge = 10;
            Rectangle square = new Square(Edge);

            // act
            string ToStringAns = "Type: Square, Perimeter: 40, Area: 100";

            // assert
            Assert.AreEqual(ToStringAns, square.ToString());
        }

        [TestMethod()]
        public void SquareSetEdge()
        {
            // arrange
            double Edge = 10;
            Rectangle square = new Square(Edge);

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