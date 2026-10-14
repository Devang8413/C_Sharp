using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccerenceInString
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string input = "devangpandare";

            for(int i = 0; i < input.Length ; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        Console.WriteLine($"Double character found: {input[i]} ");
                        break;
                    }
                }
            }
        }
    }
}
