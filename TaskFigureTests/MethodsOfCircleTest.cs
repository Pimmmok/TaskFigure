using NUnit.Framework;
using TaskFigure;
namespace TaskFigureTests
{
    public class MethodsOfCircleTest
    {
        [TestCase(1, 0.01, 3.14)]
        [TestCase(2, 0.01, 12.57)]
        [TestCase(12, 0.01, 452.39)]
        public void СalculateArea_Area_ShouldBeCalculatedCorrectly(double radius, double precision, double expected)
        {
            Circle circle = new Circle(radius);
            double actual = circle.СalculateArea();
            Assert.AreEqual(expected, actual, precision);
        }
    }
}
