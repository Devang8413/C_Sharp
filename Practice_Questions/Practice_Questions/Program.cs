using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Write a C# program to find the largest distinct number in this array:


            //int[] numbers = { 19, 2, 3, 45, 5 };

            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }

            //}
            //Console.WriteLine("The largest Number" + max);



            // Write a C# program to count how many vowels (a, e, i, o, u) are present in a string ?

            //string text = "Hello World MY NAME IS TUSHAR ".ToLower();
            //int count = 0;

            //for(int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Count of vowels: " + count);


            //Find the first non-repeating character

            string input = "swiss";

            for (int i = 0; i < input.Length; i++)
            {
                bool repeated = false;

                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] == input[j])
                    {
                        repeated = true;
                        break;
                    }
                }

                if (!repeated)
                {
                    Console.WriteLine(input[i]);
                    break;
                }
            }
        }
    }
}
