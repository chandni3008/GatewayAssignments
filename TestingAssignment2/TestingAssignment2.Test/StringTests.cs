using System;
using System.Linq;
using Xunit;
using TestingAssignment2;


namespace TestingAssignment2.Test
{
    public class StringTests
    {
       
        [Theory]
        [InlineData("Upper", "upper")]
        [InlineData("UPPER", "upper")]
        [InlineData("lower", "LOWER")]
        public void Test_ChangeCase(string inputString, string result)
        {

            // Act
            var newString = inputString.ChangeCase();

            // Assert
            Assert.Equal(newString, result);

        }

        [Theory]
        [InlineData("test for title case", "Test For Title Case")]
        [InlineData("Test foR titLE case", "Test For Title Case")]
        [InlineData("TEST FOR TITLE CASE", "Test For Title Case")]
        public void Test_ChangeToTitleCase(string inputString, string result)
        {

            // Act
            var newString = inputString.ChangeToTitleCase();

            // Assert
            Assert.Equal(newString, result);

        }

        [Fact]
        public void Test_IsLowerOrUpper(string inputString, string result)
        {

            // Arrange
            
            

            // Act
            

            // Assert
            

        }


        [Fact]
        public void Test_Capitalize()
        {

            // Arrange
            var inputString = "user";
            var outputString = "User";

            // Act
            var newString = inputString.Capitalize();

            // Assert
            Assert.Equal(newString, outputString);

        }

        [Theory]
        [InlineData("1234", true)]
        [InlineData("123c", false)]
        [InlineData("2288", true)]
        [InlineData("abcd", false)]
        public void Test_NumericValue(string inputString, bool result)
        {

            // Act
            var newString = inputString.NumericValue();

            // Assert
            Assert.Equal(newString, result);

        }

        [Theory]
        [InlineData("abcd", "abc")]
        [InlineData("1234", "123")]
        [InlineData("QWE", "QW")]
        public void Test_RemoveLastCharacter(string inputString, string result)
        {

            // Act
            var newString = inputString.RemoveLastCharacter();

            // Assert
            Assert.Equal(newString, result);

        }

        [Theory]
        [InlineData("abcd", 1)]
        [InlineData("Count words", 2)]
        [InlineData("Test is running", 3)]
        public void Test_WordCount(string inputString, int count)
        {

            // Act
            var newString = inputString.WordCount();

            // Assert
            Assert.Equal(newString, count);

        }

        [Fact]
        public void Test_StringToInteger()
        {

            // Arrange
            var inputString = "123";
            var output = 123;

            // Act
            var newString = inputString.StringToInteger();

            // Assert
            Assert.Equal(newString, output);

        }
    }
}

