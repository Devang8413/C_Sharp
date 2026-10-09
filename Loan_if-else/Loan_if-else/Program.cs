using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your salary : ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Your CIBIL score : ");
            int cibilscore = Convert.ToInt32(Console.ReadLine());

            bool checkAge = age >= 21;
            bool checkSalary = salary >= 30000;
            bool checkScore = cibilscore >= 700;

            if(checkAge && checkSalary && checkScore)
            {
                Console.WriteLine("Eligible for loan ");
            }
            else
            {
                Console.WriteLine("not eligible for loan");
            }
               
        }
    }
}
