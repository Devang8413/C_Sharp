using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter Any Language : ");
            string language = Console.ReadLine();

            string[] techSkills = { "C", "C++", "Python", "C#", language };

            //techSkills = techSkills.Append(language).ToArray();
            foreach (string skill in techSkills)
            {
                Console.WriteLine(skill);
            }

            ArrayList mixValues = new ArrayList();

            mixValues.Add("BMW");
            mixValues.Add(123);
            mixValues.Add(true);

            foreach(var value in mixValues)
            {
                Console.WriteLine(value);
            }
        }
    }

}
