using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class DivOperation : Operation
    {
        public override Regex GetRegex { get; }

        public override char Symbol { get; }

        public override OperationHandle Do { get; }

        private static double Div(double op1, double op2) => op2 != 0 ? op1 / op2 : throw new ArithmeticException("Division by zero is not allowed");

        public DivOperation()
        {
            GetRegex = new Regex(@"\-?\d+(?:[,.]\d+)?\/\d+(?:[,.]\d+)?");
            Do = Div;
            Symbol = '/';
        }
    }
}
