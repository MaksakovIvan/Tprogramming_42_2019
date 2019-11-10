using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.Matem(0.0, 0.0);
            Xunit.Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            var mass = new double[0];
            var res = Program.TaskB(2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
            var res = Program.TaskB(2.5, x);
            var expy = new double[] { 0.750082078454372, 0.639743913195054, 0.504058298008105, 0.699366948598495, 0.381615534970301 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}