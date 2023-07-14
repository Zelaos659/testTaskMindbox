using System.Globalization;
using System.Runtime.Serialization;
using Shapes;

namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public void SimpleTest_CalculateCircleArea()
        {
            try
            {
                // Arrange
                double expected = 3.14;

                // Act
                IShape shape = new Circle(1);
                double actual = Math.Round(ShapesOperations.CalculateShapeArea(shape),2);

                // Assert
                Assert.Equal(expected, actual);
            }
            catch (ArgumentException)
            {
                throw new Exception("Неверный ввод");
            }

}
        [Fact]
        public void SimpleTest_CalculateTriangleArea()
        {

            try
            {
                // Arrange
                double expected = 0.97;

                // Act
                IShape shape = new Triangle(2, 1, 2);
                double actual = Math.Round(ShapesOperations.CalculateShapeArea(shape),2);

                // Assert
                Assert.Equal(expected, actual);
            }
            catch (ArgumentException)
            {
                throw new Exception("Неверный ввод");
            }
        }
        [Fact]
        public void SimpleTest_CalculateTriangleIsRectangle()
        {
            try
            {
                // Arrange
                bool expected = true;

                // Act
                Triangle triangle = new Triangle(5, 4, 3);
                bool actual = ShapesOperations.IsRectangle(triangle);

                // Assert
                Assert.Equal(expected, actual);
            }
            catch (ArgumentException)
            {
                throw new Exception("Неверный ввод");
            }
        }
    }
}