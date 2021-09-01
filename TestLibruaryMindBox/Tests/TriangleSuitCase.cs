using System;
using Xunit;
using TestLibruaryMindBox;

namespace Tests
{
    public class TriangleSuitCase
    {
        [Theory]
        [InlineData(new float[] { 2, 3, 4 })]
        [InlineData(new float[] { 3, 5, 4 })]
        [InlineData(new float[] { 10, 10, 12 })]
        private void TriangleCreateWithoutException(float[] edges)
        {
            Triangle triangle = new Triangle(edges);
            Assert.True(true);
        }
        [Theory]
        [InlineData(new float[] { 2, 3 })]
        [InlineData(new float[] { 3, 5, 4, 4 })]
        private void TriangleEdgeCountException(float[] edges)
        {
            try
            {
                Triangle triangle = new Triangle(edges);
                Assert.True(false, "Exception didn't throw");
            }
            catch (TriangleCreateException exception)
            {
                Assert.Equal(TriangleCreateException.ExceptionType.EdgeCountException, exception.Type);
            }
        }
        [Theory]
        [InlineData(new float[] { 2, 3, 0 })]
        [InlineData(new float[] { 3, -1, 2 })]
        [InlineData(new float[] { -3, 21, 2 })]
        private void TriangleEdgeLengthException(float[] edges)
        {
            try
            {
                Triangle triangle = new Triangle(edges);
                Assert.True(false, "Exception didn't throw");
            }
            catch (TriangleCreateException exception)
            {
                Assert.Equal(TriangleCreateException.ExceptionType.EdgeLengthException, exception.Type);
            }
        }
        [Theory]
        [InlineData(new float[] { 2, 3, 9 })]
        [InlineData(new float[] { 3, 8, 2 })]
        [InlineData(new float[] { 21, 3, 2 })]
        private void TriangleNotExsitsException(float[] edges)
        {
            try
            {
                Triangle triangle = new Triangle(edges);
                Assert.True(false, "Exception didn't throw");
            }
            catch (TriangleCreateException exception)
            {
                Assert.Equal(TriangleCreateException.ExceptionType.TriangleNotExistException, exception.Type);
            }
        }
        [Theory]
        [InlineData((double)2.9, new float[] { 2, 3, 4 }, 1)]
        [InlineData((double)2.83, new float[] { 2, 3, 3 }, 2)]
        private void TriangleAreaCalculation(double expectedArea, float[] edges, int digitsAfterPoint)
        {
            Triangle triangle = new Triangle(edges);
            double result = Math.Round(triangle.GetArea(), digitsAfterPoint);
            Assert.Equal(expectedArea, result);
        }
        [Fact]
        private void TestRightTriangle()
        {
            float a = 2f;
            float b = 3f;
            float c = (float)Math.Sqrt(a * a + b * b);
            Triangle triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsRightTriangle());
        }
    }
}
