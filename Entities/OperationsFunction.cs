using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWUIS.Entities
{
    internal class OperationsFunction
    {
        public static double PerformOperation(double number1, double number2, string operation)
        {
            return operation switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" => number1 / number2,
                "+%" => number1 + (number1 * (number2 / 100)),
                "-%" => number1 - (number1 * (number2 / 100)),
                "x" => Math.Pow(number1, number2),
                "v2" => Math.Sqrt(number1),
                "v3" => Math.Cbrt(number1),
                _ => 0.00,
            };
        }

        public static string GetOperationName(string operation)
        {
            return operation switch
            {
                "+" => "Sum",
                "-" => "Subtraction",
                "*" => "Multiplication",
                "/" => "Division",
                "+%" => "Sum Percentage",
                "-%" => "Subtraction Percentage",
                "x" => "Exponentiation",
                "v2" => "Square root",
                "v3" => "Cube root",
                _ => "",
            };
        }
    }
}