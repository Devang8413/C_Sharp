
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseIf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
           // Console.WriteLine(number);

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }


            // with switch case 

            switch (number)
            {
                
            }
        }
    }
}
