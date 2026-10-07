using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your marks (0 to 100): ");
            int marks = Convert.ToInt32(Console.ReadLine());


            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks! Please enter a number between 0 and 100.");
            }
            else if (marks <= 90 && marks >=70)
            {
                Console.WriteLine("Grade: A+ (Excellent!)");
            }
            else if (marks <= 70 && marks>=50)
            {
                Console.WriteLine("Grade: A (Very Good)");
            }
            else if (marks <= 50 && marks>=30)
            {
                Console.WriteLine("Grade: B (Pass)");
            }
            else
            {
                Console.WriteLine("Grade: F (Fail. Better luck next time!)");
            }
        }
    }
}


