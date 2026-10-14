using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceManagement1;
namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter the principal amount:");
            int userPrincipleAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculated Interest Rate For City Bank "+bank.CityBank(userPrincipleAmount));
            Console.WriteLine("Calculated Interest Rate For HDFC Bank "+bank.Hdfc(userPrincipleAmount));
            Console.ReadLine();


        }
    }
}
