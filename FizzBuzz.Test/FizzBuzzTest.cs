using FizzBuzz.Cl;
using FizzBuzz.Core.FizzBuzzLogic;
using FizzBuzz.Core;
using System;
using System.Collections.Generic;
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
        [InlineData(52, "Buzz")]
        [InlineData(13, "Fizz")]
        [InlineData(53, "FizzBuzz")]
        public void FizzBuzz_Successful(int number, string expectedResult)
        {
            var fizzBuzzLogicList = new List<ILogic>()
            {
                new FizzLogic(),
                new BuzzLogic(),
                new FizzBuzzExtraLogic()
            };
            var fizzBuzzManager = new FizzBuzzManager(fizzBuzzLogicList, new DefaultLogic());
            var result = fizzBuzzManager.GetFizzBuzzFromNumber(number);
            Assert.Equal(expectedResult, result);
        }
    }
}
