using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface ICalculator
    {
        void Init();

        bool Validate(string input);

        double Calculate(string input);
    }
}
