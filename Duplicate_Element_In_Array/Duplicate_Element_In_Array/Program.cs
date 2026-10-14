using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Element_In_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 2, 8, 5, 8, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
    }
}
