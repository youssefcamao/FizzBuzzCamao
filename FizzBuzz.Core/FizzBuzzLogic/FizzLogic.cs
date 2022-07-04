using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.FizzBuzzLogic;
public class FizzLogic : ILogic
{
    public string? GetLogicString(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        return null;
    }
}
