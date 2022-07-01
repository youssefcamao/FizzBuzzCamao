using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Cl
{
    public class FizzBuzz
    {
        public FizzBuzz(int number)
        {
            Number = number;
        }
        public int Number { get; }
        public bool IsFizz => Number % 3 == 0;
        public bool IsBuzz => Number % 5 == 0;
        public override string ToString()
        {
            //No ifs no loops
            var fizz = new List<string> { String.Empty, "Fizz" };
            var buzz = new List<string> { String.Empty, "Buzz" };
            var fizzIndex = Convert.ToInt32(IsFizz);
            var buzzIndex = Convert.ToInt32(IsBuzz);
            var result = new List<string> { fizz[fizzIndex] + buzz[buzzIndex], $"{Number}" };
            var resultIndex = string.IsNullOrEmpty(result[0]);
            return result[Convert.ToInt32(resultIndex)];
        }
    }
}
