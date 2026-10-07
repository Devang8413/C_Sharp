using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Eligible for voting.");
            }
            else
            {
                Console.WriteLine("You are not eligible for voting");
            }
        }
    }
}
