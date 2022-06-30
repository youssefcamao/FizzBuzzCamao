using FizzBuzz.Cl;
using System;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzz_Successful(int number, string expectedResult)
        {
            var fizzBuzzManager = new FizzBuzzManager();
            var result = fizzBuzzManager.GetFizzBuzzForm(number);
            Assert.Equal(expectedResult, result);
        }
    }
}
