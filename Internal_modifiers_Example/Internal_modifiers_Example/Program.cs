using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLCalculator;

namespace Internal_modifiers_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal calobj = new Cal();
            calobj.Add(10, 20);
        }
    }
}
