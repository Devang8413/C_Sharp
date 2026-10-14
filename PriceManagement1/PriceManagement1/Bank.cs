using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceManagement1
{
    public class Bank
    {
        decimal rbiRepoRate = 5.50m;
        public decimal Hdfc(decimal principleAmount)
        {
            decimal hdfcRate = 2.0m;
            decimal totalInterest=rbiRepoRate + hdfcRate;
            decimal totalInterestAmount = (principleAmount * totalInterest) / 100;
            return totalInterestAmount;
        }
        public decimal CityBank(decimal principleAmount)
        {
            decimal hdfcRate = 2.5m;
            decimal totalInterest = rbiRepoRate + hdfcRate;
            decimal totalInterestAmount = (principleAmount * totalInterest) / 100;
            return totalInterestAmount;
        }

    }
}
