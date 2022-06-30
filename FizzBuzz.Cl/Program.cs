using System;
using System.Linq;

namespace FizzBuzz.Cl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersList = Enumerable.Range(0, 100).ToList();
            var fizzBuzzManager = new FizzBuzzManager();
            numbersList.ForEach(x => Console.WriteLine(fizzBuzzManager.GetFizzBuzzFromNumber(x)));
        }
    }
}
