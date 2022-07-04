using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.FizzBuzzLogic;
public class FizzBuzzExtraLogic : ILogic
{
    public string? GetLogicString(int number)
    {
        var numberString = number.ToString();
        var result = string.Empty;
        if (numberString.Contains("3"))
        {
            result += "Fizz";
        }
        if (numberString.Contains("5"))
        {
            result += "Buzz";
        }
        if (!string.IsNullOrEmpty(result))
        {
            return result;
        }
        return null;
    }
}
