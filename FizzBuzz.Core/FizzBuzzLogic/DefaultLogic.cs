using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.FizzBuzzLogic;
public class DefaultLogic : ILogic
{
    public string? GetLogicString(int number)
    {
        return number.ToString();
    }
}
