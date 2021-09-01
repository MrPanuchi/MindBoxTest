using System;
using TestLibruaryMindBox;
using Xunit;

namespace Tests
{
    public class CircleSuitCase
    {
        [Theory]
        [InlineData(1f)]
        [InlineData(12345f)]
        [InlineData(140300f)]
        private void CircleRightCreation(float radius)
        {
            try
            {
                Circle circle = new Circle(radius);
                Assert.True(true);
            }
            catch
            {
                Assert.True(false, "Something is wrong.");
            }
        }
        [Theory]
        [InlineData(-1f)]
        [InlineData(0)]
        private void CircleRadiusException(float radius)
        {
            try
            {
                Circle circle = new Circle(radius);
                Assert.True(false, "Exception didn't throw");
            }
            catch (CircleCreateException)
            {
                Assert.True(true);
            }
        }
        [Theory]
        [InlineData(1f, 3.142f, 3)]
        [InlineData(11.1f, 387.08f, 2)]
        private void CircleRightArea(float radius, float rightAnswer, int digitsAfterPoint)
        {
            Circle circle = new Circle(radius);
            Assert.Equal(MathF.Round(circle.GetArea(), digitsAfterPoint), rightAnswer);
        }
    }
}
