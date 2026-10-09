using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //take two nubers from user and the operator and perform the operation using switch case

            Console.WriteLine("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /): ");
            char operatorSymbol = Convert.ToChar(Console.ReadLine());

            double result = 0;
            switch (operatorSymbol)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;

                case '-':
                    result = firstNumber - secondNumber;
                    break;

                case '*':
                    result = firstNumber * secondNumber;
                    break;

                case '/':
                    result = firstNumber / secondNumber;
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
            Console.WriteLine($"Result: "+ result);
        }
    }
}
