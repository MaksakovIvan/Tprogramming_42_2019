using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CatTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Cat();
            Assert.Equal(0, item.Age);
            Assert.Equal("Unnamed", item.Name);
            Assert.Equal("male", item.Gender);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Cat();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Cat();
            item.Age = -5;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Cat();
            item.Age = 10;
            item.Age = -5;
            Assert.Equal(10, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetGender()
        {
            var item = new Cat();
            item.Gender = "female";
            item.Gender = "demale";
            Assert.Equal("female", item.Gender);
        }
    }
}