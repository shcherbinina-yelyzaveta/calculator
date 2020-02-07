using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    static class Initializer
    {
        public static Dictionary<char, Operation> InitialOperations;

        static Initializer()
        {
            InitialOperations = new Dictionary<char, Operation>();
        }

        public static Dictionary<char, Operation> Init()
        {
            AddOperation(new DivOperation());
            AddOperation(new MultiplyOperation());
            AddOperation(new SubOperation());
            AddOperation(new SumOperation());

            return InitialOperations;
        }

        public static void AddOperation(Operation operation)
        {
            InitialOperations.Add(operation.Symbol, operation);
        }
    }
}
