using System.Text.RegularExpressions;

namespace Calculator
{
    class MultiplyOperation : Operation
    {
        public override Regex GetRegex { get; }

        public override char Symbol { get; }

        public override OperationHandle Do { get; }

        private static double Multiply(double op1, double op2) => op1 * op2;

        public MultiplyOperation()
        {
            GetRegex = new Regex(@"\-?\d+(?:[,.]\d+)?\*\d+(?:[,.]\d+)?");
            Do = Multiply;
            Symbol = '*';
        }
    }
}
