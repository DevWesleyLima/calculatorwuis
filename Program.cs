using System;
using CalculatorWUIS.Entities;
using System.Globalization;

namespace CalculatorWUIS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calculator 
            Console.WriteLine("Welcome to your calculator program!!!");
            Console.WriteLine("*************************************");

            Console.Write("Type the 1st number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Type the operator:");
            string operation = Console.ReadLine();

            if (operation.ToLower().Substring(0, 1) != "v")
            {
                Console.Write("Type the 2nd number:");
                int number2 = int.Parse(Console.ReadLine());

                double result = OperationsFunction.PerformOperation(number1, number2, operation);
                string operationName = OperationsFunction.GetOperationName(operation);
                Console.WriteLine(GetResultDisplayString(operationName, result));
            }
            else
            {
                double result = OperationsFunction.PerformOperation(number1, -1, operation);
                string operationName = OperationsFunction.GetOperationName(operation);
                Console.WriteLine(GetResultDisplayString(operationName, result));
            }
        }
        public static string GetResultDisplayString(string operationName, double result)
        {

            return "Operation: " + operationName
                + '\n'
                + "Result: " + result.ToString("0,0.00", CultureInfo.InvariantCulture);
        }
    }
}


