using System.Text.RegularExpressions;

namespace Calculator
{
    class Validator
    {
        public Regex GetRegex { get;}

        public Validator(Regex regex)
        {
            GetRegex = regex;
        }

        public bool IsValid(string input)
        {
            return GetRegex.IsMatch(input);
        }
    }
}
