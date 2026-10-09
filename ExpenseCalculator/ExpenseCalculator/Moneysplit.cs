using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMoneySplit01
{
    public class PerPersonExpense
    {
        decimal perPersonExpense, tusharExpense, nishantExpense, ajayExpense;
        decimal tusharProfitAmount, tusharLossAmount;
        decimal nishantProfitAmount, nishantLossAmount;
        decimal ajayProfitAmount, ajayLossAmount;
        int tusharFlag = 0;
        int nishantFlag = 0;
        int ajayFlag = 0;

        public void setExpenseData(decimal tusharExpenseData, decimal nishantExpenseData, decimal ajayExpenseData)
        {
            tusharExpense = tusharExpenseData;
            nishantExpense = nishantExpenseData;
            ajayExpense = ajayExpenseData;
        }
        public void CalculatePerPersonExpense()
        {
            perPersonExpense = (tusharExpense + nishantExpense + ajayExpense) / 3;
            Console.WriteLine($"Per person expense: {perPersonExpense}");

        }
        public void CalculateTusharExpense()
        {
            if (tusharExpense > perPersonExpense)
            {
                tusharProfitAmount = tusharExpense - perPersonExpense;
                Console.WriteLine($"Tushar profit: {tusharProfitAmount}");

            }
            else if (tusharExpense < perPersonExpense)
            {
                tusharLossAmount = perPersonExpense - tusharExpense;
                Console.WriteLine($"Tushar loss: {tusharLossAmount}");
                tusharFlag = 1;
            }
        }
        public void CalculateNishantExpense()
        {
            if (nishantExpense > perPersonExpense)
            {
                nishantProfitAmount = nishantExpense - perPersonExpense;
                Console.WriteLine($"Nishant profit: {nishantProfitAmount}");

            }
            else if (nishantExpense < perPersonExpense)
            {
                nishantLossAmount = perPersonExpense - nishantExpense;
                Console.WriteLine($"Nishant loss: {nishantLossAmount}");
                nishantFlag = 1;
            }
        }
        public void CalculateAjayExpense()
        {
            if (ajayExpense > perPersonExpense)
            {
                ajayProfitAmount = ajayExpense - perPersonExpense;
                Console.WriteLine($"Ajay profit: {ajayProfitAmount}");

            }
            else if (ajayExpense < perPersonExpense)
            {
                ajayLossAmount = perPersonExpense - ajayExpense;
                Console.WriteLine($"Ajay loss: {ajayLossAmount}");
                ajayFlag = 1;
            }
        }

        public void CalculateFinalSettlement()
        {
            if (tusharFlag == 1)
            {
                if (nishantFlag == 1)
                {
                    decimal finalTusharProfit = nishantLossAmount - tusharProfitAmount;
                    Console.WriteLine($"Nishant will give Tushar: {finalTusharProfit}");
                }
                else if (ajayFlag == 1)
                {
                    decimal finalTusharProfit = ajayLossAmount - tusharProfitAmount;
                    Console.WriteLine($"Ajay will give Tushar: {finalTusharProfit}");
                }
            }
             if (nishantFlag == 1)
            {
                if (tusharFlag == 1)
                {
                    decimal finalNishantProfit = tusharLossAmount - nishantProfitAmount;
                    Console.WriteLine($"Tushar will give Nishant: {finalNishantProfit}");
                }
                else if (ajayFlag == 1)
                {
                    decimal finalNishantProfit = ajayLossAmount - nishantProfitAmount;
                    Console.WriteLine($"Ajay will give Nishant: {finalNishantProfit}");
                }
            }
             if (ajayFlag == 1)
            {
                if (tusharFlag == 1)
                {
                    decimal finalAjayProfit = tusharLossAmount - ajayProfitAmount;
                    Console.WriteLine($"Tushar will give Ajay: {finalAjayProfit}");
                }
                else if (nishantFlag == 1)
                {
                    decimal finalAjayProfit = nishantLossAmount - ajayProfitAmount;
                    Console.WriteLine($"Nishant will give Ajay: {finalAjayProfit}");
                }
            }
        }

        public void CalculateFinalSettlementOfTushar()
        {
            if (ajayFlag == 1)
            {
                decimal finalTusharProfit = ajayLossAmount - tusharProfitAmount;
                Console.WriteLine($"Ajay will give Tushar: {finalTusharProfit}");
            }
            else if (nishantFlag == 1)
            {
                decimal finalTusharProfit = nishantLossAmount - tusharProfitAmount;
                Console.WriteLine($"Nishant will give Tushar: {finalTusharProfit}");
            }
        }

        public void CalculateFinalSettlementOfNishant()
        {
            if (ajayFlag == 1)
            {
                decimal finalNishantProfit = ajayLossAmount - nishantProfitAmount;
                Console.WriteLine($"Ajay will give Nishant: {finalNishantProfit}");
            }
            else if (tusharFlag == 1)
            {
                decimal finalNishantProfit = tusharLossAmount - nishantProfitAmount;
                Console.WriteLine($"Tushar will give Nishant: {finalNishantProfit}");
            }
        }
        public void CalculateFinalSettlementOfAjay()
        {
            if (nishantFlag == 1)
            {
                decimal finalAjayProfit = nishantLossAmount - ajayProfitAmount;
                Console.WriteLine($"Nishant will give Ajay: {finalAjayProfit}");
            }
            else if (tusharFlag == 1)
            {
                decimal finalAjayProfit = tusharLossAmount - ajayProfitAmount;
                Console.WriteLine($"Tushar will give Ajay: {finalAjayProfit}");
            }
        }


















































































        //public void CalculateFinalSettlementOfTushar()
        //{
        //    if (ajayFlag == 1)
        //    {
        //        decimal finalTusharProfit = ajayLossAmount - tusharProfitAmount;
        //        Console.WriteLine($"Ajay will give Tushar: {finalTusharProfit}");

        //    }
        //    else if (nishantFlag == 1)
        //    {
        //        decimal finalTusharProfit = nishantLossAmount - tusharProfitAmount;
        //        Console.WriteLine($"Nishant will give Tushar: {finalTusharProfit}");
        //    }
        //}
        //public void CalculateFinalSettlementOfNishant()
        //{
        //    if (ajayFlag == 1)
        //    {
        //        decimal finalNishantProfit = ajayLossAmount - nishantProfitAmount;
        //        Console.WriteLine($"Ajay will give Nishant: {finalNishantProfit}");

        //    }
        //    else if (tusharFlag == 1)
        //    {
        //        decimal finalNishantProfit = tusharLossAmount - nishantProfitAmount;
        //        Console.WriteLine($"Tushar will give Nishant: {finalNishantProfit}");
        //    }
        //}
        //public void CalculateFinalSettlementOfAjay()
        //{
        //    if (nishantFlag == 1)
        //    {
        //        decimal finalAjayProfit = nishantLossAmount - ajayProfitAmount;
        //        Console.WriteLine($"Nishant will give Ajay: {finalAjayProfit}");

        //    }
        //    else if (tusharFlag == 1)
        //    {
        //        decimal finalAjayProfit = tusharLossAmount - ajayProfitAmount;
        //        Console.WriteLine($"Tushar will give Ajay: {finalAjayProfit}");
        //    }
        //}
    }
}