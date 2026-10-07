using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Example
{
    internal class Calculator
    {
        public void Calculators(int firstNumber, int secondNumber, char operators)
        {
            if (operators == '+')
            {
                Console.WriteLine("Addition : " + (firstNumber + secondNumber));
            }
            else if (operators == '-')
            {
                Console.WriteLine("Subtraction : " + (firstNumber - secondNumber));
            }
            else if (operators == '*')
            {
                Console.WriteLine("Multiplication : " + (firstNumber * secondNumber));
            }
            else if (operators == '/')
            {
                Console.WriteLine("Division : " + (firstNumber / secondNumber));
            }
            else
            {
                Console.WriteLine("Enter valid operator");
            }
        }

    }
}
