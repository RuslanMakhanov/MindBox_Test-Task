using NUnit.Framework;
using ShapeLibrary;
using System;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class ShapeTests
    {
         public void RectangleAreaTest()
    {
        double width = 4;
        double height = 5;
        IShape rectangle = ShapeFactory.CreateRectangle(width, height);
        double expectedArea = width * height;
        Assert.AreEqual(expectedArea, rectangle.CalculateArea(), 1e-10);
    }
        [Test]
        public void CircleAreaTest()
        {
            double radius = 5;
            IShape circle = ShapeFactory.CreateCircle(radius);
            double expectedArea = Math.PI * radius * radius;
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 1e-10);
        }

        [Test]
        public void TriangleAreaTest()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            IShape triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            double s = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 1e-10);
        }

        [Test]
        public void RightTriangleTest()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = (Triangle)ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void NonRightTriangleTest()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;
            Triangle triangle = (Triangle)ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}
