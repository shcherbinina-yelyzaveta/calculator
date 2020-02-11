using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Calculator : ICalculator
    {
        public Validator ValidatorObj { get; set; }

        public CalculationMethod CalcMethod { get; set; }

        public Calculator()
        {
            Init();
        }

        public void Init()
        {
            CalcMethod = new CalculationMethod(Initializer.Init());
            ValidatorObj = new Validator(new Regex(@"^\-?(\d+(?:[,.]\d+)?[+\-*/])+\d+(?:[,.]\d+)?$"));
        }

        public bool Validate(string input) => ValidatorObj.IsValid(input);

        public double Calculate(string input) => CalcMethod.ParseAndCalculate(new StringBuilder(input));
    }
}
