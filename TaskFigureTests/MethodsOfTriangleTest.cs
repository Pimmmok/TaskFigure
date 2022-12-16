using NUnit.Framework;
using TaskFigure;

namespace TaskFigureTests
{
    public class MethodsOfTriangleTest
    {
        [TestCase(3, 4, 5, 0.001, 6)]
        [TestCase(5, 5, 6, 0.001, 12)]
        [TestCase(11, 11, 11, 0.001, 52.395)]
        public void ÑalculateArea_Area_ShouldBeCalculatedCorrectly(double sideOne, double sideTwo, double sideThree, double precision, double expected)
        {
            Triangle triangle = new Triangle(sideOne, sideTwo, sideThree);
            double actual = triangle.ÑalculateArea();
            Assert.AreEqual(expected, actual, precision);
        }

        [TestCase(4, 3, 10, ExpectedResult = false)]
        [TestCase(0, 0, 1, ExpectedResult = false)]
        [TestCase(0, 0, 0, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(10, 10, 10, ExpectedResult = true)]
        public bool Exists_ÑorrectnessOfTheSides_ShouldBeTrue(double sideOne, double sideTwo, double sideThree)
        {
            return Triangle.Exists(sideOne, sideTwo, sideThree);
        }

        [TestCase(10, 10, 10, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(12, 35, 37, ExpectedResult = true)]
        public bool CheckTriangleAsRectangular_ÑorrectnessOfTheSides_ShouldBeTrue(double sideOne, double sideTwo, double sideThree)
        {
            Triangle triangle = new Triangle(sideOne, sideTwo, sideThree);
            return triangle.CheckTriangleAsRectangular();
        }

       [Test]
        public void Constructor_TestException_ShouldBeTriangleException()
        {
            TriangleException triangleException = Assert.Throws<TriangleException>(() => new Triangle(177, 1, 3));
            Assert.That(triangleException.Message, Is.EqualTo("Triangle with these sides doesnt exist"));
        }
        [Test]
        public void SetSides_TestException_ShouldBeTriangleException()
        {
            Triangle triangle = new Triangle();
            TriangleException triangleException = Assert.Throws<TriangleException>(() => triangle.SetSide(17, 3, 9));
            Assert.That(triangleException.Message, Is.EqualTo("Triangle with these sides doesnt exist"));
        }
    }
}