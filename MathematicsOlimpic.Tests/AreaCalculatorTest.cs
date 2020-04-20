using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathematicsOlimpic.Figures.Primitives;

namespace MathematicsOlimpic.Tests
{
    [TestFixture]
    public class AreaCalculatorTest
    {
        [Test]
        public void CircleNegativeRadiusTest()
        {
            // Тестируем отрицательный радиус круга
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));

            // Тестируем отрицательные стороны треугольника
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-6, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -5, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-7, -7, -7));
        }

        // Тестируем вычисление площади круга
        [Test]
        public void CircleSqrCalculationTest()
        {
            // Arrange
            var circle = new Circle(10);

            // Act
            var circleArea = circle.Area;

            // Assert
            Assert.AreEqual(314.15926535897931, circleArea);
        }

        // Тестируем вычисление площади треугольника
        [Test]
        public void TriangleSqrCalculatorTest()
        {
            // Arrange
            var triangle = new Triangle(5, 5, 8);

            // Act
            var triangleArea = triangle.Area;

            // Assert
            Assert.AreEqual(12, triangleArea);
        }

        // Тестируем прямоугольный треугольник
        [Test]
        public void RightAngleTriangleTest()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isTriangleRightAngled = triangle.IsRightAngle;

            // Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        // Тестируем не прямоугольный треугольник
        [Test]
        public void NotRightAngleTriangleTest()
        {
            // Arrange
            var triangle = new Triangle(6, 2, 5);

            // Act
            var isTriangleRightAngled = triangle.IsRightAngle;

            // Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
