using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLCalculator
{
    public class Cal
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The result of adding {a} and {b} is: {result}");
        }
    }
}
