namespace FizzBuzz.Core
{
    public class FizzBuzzManager
    {
        private readonly IList<ILogic> _fizzBuzzLogicList;
        private readonly ILogic _defaultLogic;

        public FizzBuzzManager(IList<ILogic> fizzBuzzLogicList, ILogic defaultLogic)
        {
            _fizzBuzzLogicList = fizzBuzzLogicList;
            _defaultLogic = defaultLogic;
        }
        public string GetFizzBuzzFromNumber(int number)
        {
            var result = string.Empty;
            foreach (var logic in _fizzBuzzLogicList)
            {
                var logicString = logic.GetLogicString(number) ?? string.Empty;
                if (!result.Contains(logicString))
                {
                    result += logicString;
                }
            }
            if (string.IsNullOrEmpty(result))
            {
                result = _defaultLogic.GetLogicString(number);
            }
            return result;
        }
    }
}
