using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill_If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter units : ");
            int units = Convert.ToInt32(Console.ReadLine());

            if(units <= 100)
            {
                Console.WriteLine("Your Elictrcity Bill : " + (5 * units));
            }
            else if(units >= 101 && units <= 200)
            {
                Console.WriteLine("Your Elictrcity Bill : " + (7 * units));
            }
            else if(units >= 200)
            {
                Console.WriteLine("Your Elictrcity Bill : " + (18 * units));
            }
        }
    }
}
