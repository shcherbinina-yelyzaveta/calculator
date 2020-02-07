using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Hello! Please enter an expression to calculate:");
            string input = Console.ReadLine().Trim();
            try
            {
                if (calculator.Validate(input))
                {
                    double result = calculator.Calculate(input);
                    Console.WriteLine($"{input}={result:F2}");
                }
                else Console.WriteLine("Oops, incorrect format!");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Oops, arithmetic error is happened - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, it seems error is happened - {ex.Message}");
            }
        }
    }
}
