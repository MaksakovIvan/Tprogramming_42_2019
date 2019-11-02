using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 2, 1)]
        [InlineData(1, 2, 1)]
        public void TestFunctionCalculationVal(double b, double x, double exp)
        {
            var res = Program.Matem(b, x);
            Assert.Equal(exp, res, 3);
        }
    }
}
