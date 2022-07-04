using FizzBuzz.Core;
using FizzBuzz.Core.FizzBuzzLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Cl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersList = Enumerable.Range(0, 100).ToList();
            var fizzBuzzLogicList = new List<ILogic>()
            {
                new FizzLogic(),
                new BuzzLogic()
            };
            var fizzBuzzManager = new FizzBuzzManager(fizzBuzzLogicList, new DefaultLogic());
            numbersList.ForEach(x => Console.WriteLine(fizzBuzzManager.GetFizzBuzzFromNumber(x)));
        }
    }
}
