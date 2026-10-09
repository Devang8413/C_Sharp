using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ternaryexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // even odd using ternary
            
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = (number % 2 == 0) ? "Even" : "Odd";

            Console.WriteLine("Result: " + result);
        }
    }
}
