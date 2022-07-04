using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.FizzBuzzLogic;
public class BuzzLogic : ILogic
{
    public string? GetLogicString(int number)
    {
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        return null;
    }
}
