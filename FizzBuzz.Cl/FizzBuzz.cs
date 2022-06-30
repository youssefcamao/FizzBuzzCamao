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
            return (IsFizz ? "Fizz" : string.Empty) + (IsBuzz ? "Buzz" : string.Empty) + (!IsBuzz && !IsFizz ? $"{Number}" : string.Empty);
        }
    }
}
