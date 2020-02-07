using System.Text.RegularExpressions;

namespace Calculator
{
    class SumOperation : Operation
    {
        public override Regex GetRegex { get; }

        public override char Symbol { get; }

        public override OperationHandle Do { get; }

        private static double Sum(double op1, double op2) => op1 + op2;

        public SumOperation()
        {
            GetRegex = new Regex(@"\-?\d+(?:[,.]\d+)?\+\d+(?:[,.]\d+)?");
            Do = Sum;
            Symbol = '+';
        }

    }
}
