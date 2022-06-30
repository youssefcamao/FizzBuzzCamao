using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Cl
{
    public class FizzBuzzManager
    {
        public string GetFizzBuzzFromNumber(int number)
        {
            var fizzBuzzObj = new FizzBuzz(number);
            return fizzBuzzObj.ToString();
        }
    }
}
