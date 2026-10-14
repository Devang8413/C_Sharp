using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // edges of pyramid is # and inside is * with 5 rows with for loop

            //int rows = 5;

            //for(int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        if (k == 1 || k == (2 * i - 1) || i == rows)
            //        {
            //            Console.Write("#");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // A to E while it is increasing in the number of letters in each row
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 65; j < 65 + i; j++)
                {
                    Console.Write((char)j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}