using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    abstract class Operation
    {
        public abstract Regex GetRegex { get; }

        public abstract char Symbol { get; }

        public abstract OperationHandle Do { get; }

        public delegate double OperationHandle(double op1, double op2);
    }
}
