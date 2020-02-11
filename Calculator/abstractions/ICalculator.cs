namespace Calculator
{
    interface ICalculator
    {
        void Init();

        bool Validate(string input);

        double Calculate(string input);
    }
}
