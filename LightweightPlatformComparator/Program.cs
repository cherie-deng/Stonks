using System;
using LightweightPlatformComparator.Investments;
using System.Collections.Generic;

namespace LightweightPlatformComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter investment amount (NZD):");
            System.Console.Write("$");
            var regularInvestmentAmount = Convert.ToDecimal(Console.ReadLine());

            var investmentTimeMonths = 120; //Convert.ToInt32(Console.ReadLine());
            var investmentFrequencyMonths = 2;//Convert.ToInt32(Console.ReadLine());

            SharesiesInvestment sharesies = new SharesiesInvestment();
            HatchInvestment hatch = new HatchInvestment();
            StakeInvestment stake = new StakeInvestment();

            List<Investment> investments = new List<Investment>();
            investments.Add(sharesies);
            investments.Add(hatch);
            investments.Add(stake);

            foreach (Investment inv in investments)
            {
                inv.Simulate(investmentTimeMonths, investmentFrequencyMonths, regularInvestmentAmount);
            }
        }
    }
}
