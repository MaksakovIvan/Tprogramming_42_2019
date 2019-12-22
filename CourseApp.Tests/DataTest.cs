using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DataTest
    {
        [Fact]
        public void TestAgeVchera()
        {
            string st = $"Вам 10 лет, 0 месяцев и 1 дня";
            Assert.Equal(st, Data.Age());
        }

        [Theory]
        [InlineData(7,7,7,9,9,9)]
        public void TestAgeToday()
        {
            string st = $"Вам 8 лет, 0 месяцев и 0 дня";
            Assert.Equal(st, Data.Age());
        }

        [Fact]
        public void TestAgeTommorow()
        {
            string st = $"Вам 10 лет, 0 месяцев и 0 дня";
            Assert.Equal(st, Data.Age());
        }
    }
}