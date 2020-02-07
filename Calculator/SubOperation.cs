using System.Text.RegularExpressions;

namespace Calculator
{
    class SubOperation : Operation
    {
        public override Regex GetRegex { get; }

        public override char Symbol { get; }

        public override OperationHandle Do { get; }

        private static double Sub(double op1, double op2) => op1 - op2;

        public SubOperation()
        {
            GetRegex = new Regex(@"\-?\d+(?:[,.]\d+)?\-\d+(?:[,.]\d+)?");
            Do = Sub;
            Symbol = '-';
        }
    }
}
