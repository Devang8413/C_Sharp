using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                { 4, 2, 7 },
                { 4, 8, 6 }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
