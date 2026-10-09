using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMoneySplit01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerPersonExpense perPersonExpense = new PerPersonExpense();
            perPersonExpense.setExpenseData(1000, 500, 0);
            perPersonExpense.CalculatePerPersonExpense();
            perPersonExpense.CalculateTusharExpense();
            perPersonExpense.CalculateNishantExpense();
            perPersonExpense.CalculateAjayExpense();

            Console.WriteLine("*****");

            perPersonExpense.CalculateFinalSettlement();
            perPersonExpense.CalculateFinalSettlementOfTushar();
            perPersonExpense.CalculateFinalSettlementOfNishant();
            perPersonExpense.CalculateFinalSettlementOfAjay();



            //perPersonExpense.CalculateFinalSettlementOfTushar();
            //perPersonExpense.CalculateFinalSettlementOfNishant();
            //perPersonExpense.CalculateFinalSettlementOfAjay();
        }
    }
}