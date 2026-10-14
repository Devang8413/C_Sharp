using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 90, 80, 70, 60, 50 };

            foreach(int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}
