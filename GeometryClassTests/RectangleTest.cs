using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryClass.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleArea()
        {
            // arrange
            double Width = 10;
            double Height = 30;
            Rectangle rectangle = new Rectangle(Width, Height);

            // act
            double AreaAns = Width * Height;

            // assert
            Assert.AreEqual(AreaAns, rectangle.Area());
        }

        [TestMethod()]
        public void RectanglePerimeter()
        {
            // arrange
            double Width = 10;
            double Height = 30;
            Rectangle rectangle = new Rectangle(Width, Height);

            // act
            double PerimeterAns = 2 * (Width+ Height);

            // assert
            Assert.AreEqual(PerimeterAns, rectangle.Perimeter());
        }

        [TestMethod()]
        public void RectangleToString()
        {
            // arrange
            double Width = 10;
            double Height = 30;
            Rectangle rectangle = new Rectangle(Width, Height);

            // act
            string ToStringAns = "Type: Rectangle, Perimeter: 80, Area: 300";

            // assert
            Assert.AreEqual(ToStringAns, rectangle.ToString());
        }

        [TestMethod()]
        public void RectangleSetHeight()
        {
            // arrange
            double Width = 10;
            double Height = 30;
            Rectangle rectangle = new Rectangle(Width, Height);

            // act
            rectangle.Height = 180;

            // assert
            Assert.AreEqual(rectangle.Height, 180);
            Assert.AreEqual(rectangle.Area(), 1800);
            Assert.AreEqual(rectangle.Perimeter(), 380);
        }

        [TestMethod()]
        public void RectangleSetWidth()
        {
            // arrange
            double Width = 10;
            double Height = 30;
            Rectangle rectangle = new Rectangle(Width, Height);

            // act
            rectangle.Width = 180;

            // assert
            Assert.AreEqual(rectangle.Width, 180);
            Assert.AreEqual(rectangle.Area(), 5400);
            Assert.AreEqual(rectangle.Perimeter(), 420);
        }


    }
}