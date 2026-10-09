using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discount_if_else_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the purchase amount:");
            decimal purchaseAmount = decimal.Parse(Console.ReadLine());

            decimal discount = default;

            if (purchaseAmount > 10000)
            {
                discount = (purchaseAmount * 20) / 100; // 20% discount
            }
            else if (purchaseAmount > 5000)
            {
                discount = (purchaseAmount * 10) / 100; // 10% discount
            }
            else
            {
                Console.WriteLine("No discount on your purchase.");
            }

            decimal finalAmount = purchaseAmount - discount;

            Console.WriteLine("Final amount after discount: "+ finalAmount);
        }
    }
}
