using System;
using System.Text.RegularExpressions;
namespace Homework6_1_Calculator
{
    internal class Program
    {
      
        static double Calculator(double a, double b, string Operator)
        {
            switch (Operator)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                case "x":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            double a, b;
            double result = 0;
            string mathOperator;
            string expression;
            int iteration = 0;
            do
            {
                expression = Console.ReadLine();
                if (iteration == 0)
                {
                    string[] splitExpression = Regex.Split(expression, @"([\d.-]+)([+\-*/x])([\d.-]+)");
                    a = Convert.ToDouble(splitExpression[1]);
                    b = Convert.ToDouble(splitExpression[3]);
                    mathOperator = splitExpression[2];
                    result = Calculator(a, b, mathOperator);
                    

                }
                else if (expression != "c")
                {
                    string[] splitExpression = Regex.Split(expression, @"([+\-*/x])([\d.-]+)");
                    a = result;
                    b = Convert.ToDouble(splitExpression[2]);
                    mathOperator = splitExpression[1];
                    result = Calculator(a, b, mathOperator);
                    
                }
                else
                {
                    break;
                }
                iteration++;
                Console.Write($"{iteration}: {result}");

            }
            while (expression != "c");
            Console.WriteLine("0");
        }
    }
}