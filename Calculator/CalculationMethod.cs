using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class CalculationMethod
    {
        public Dictionary<char, Operation> Operations { get; }

        public CalculationMethod(Dictionary<char, Operation> operations)
        {
            Operations = operations ?? new Dictionary<char, Operation>();
        }

        public double CalculateOne(string expression)
        {
            foreach(char c in Operations.Keys)
            {
                int i = expression.Contains(c) ? expression.IndexOf(c) : -1;
                if (i > 0)
                {
                    double op1 = Double.Parse(expression.Substring(0, i));
                    double op2 = Double.Parse(expression.Substring(i + 1, expression.Length - i - 1));

                    return Operations[c].Do(op1, op2);
                }
            }
            throw new ArithmeticException("The operation in your expression is not supported");
        }

        public double ParseAndCalculate(StringBuilder input)
        {
            Match match;
            double result;
            foreach (Operation operation in this.Operations.Values)
            {
                while (operation.GetRegex.IsMatch(input.ToString()))
                {
                    match = operation.GetRegex.Match(input.ToString());
                    result = this.CalculateOne(match.Value);
                    input.Replace(match.Value, result.ToString(), match.Index, match.Value.Length);
                }
            }

            return Double.Parse(input.ToString());
        }
    }
}
