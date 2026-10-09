using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print numbers from 1 to n using a for loop don't print 5 without using continue statement

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i > 6)
                {
                    break;

                }
                Console.WriteLine(i);
            }
        }
    }
}

           
