using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your 10th marks: ");
            int tenthMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 12th marks: ");
            int twelfthMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your degree marks: ");
            int degreeMarks = int.Parse(Console.ReadLine());

            if (tenthMarks >= 60)
            {
                if (twelfthMarks >= 60)
                {
                    if (degreeMarks >= 60)
                    {
                        Console.WriteLine("Candidate is eligible for the job.");
                    }
                    else
                    {
                        Console.WriteLine("Candidate is not eligible for the job.");
                    }
                }
                else
                {
                    Console.WriteLine("Candidate is not eligible for the job.");
                }
            }
            else
            {
                Console.WriteLine("Candidate is not eligible for the job.");
            }
        }
    }
}
