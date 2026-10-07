using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Example
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Calculators(10, 20, '+');
        }
    }
}
