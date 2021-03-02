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

            System.Console.WriteLine("Enter investment period (months):");
            var investmentTimeMonths = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter investment frequency (months):");
            var investmentFrequencyMonths = Convert.ToInt32(Console.ReadLine());

            SharesiesInvestment sharesies = new SharesiesInvestment();
            HatchInvestment hatch = new HatchInvestment();
            StakeInvestment stake = new StakeInvestment();

            List<Investment> investments = new List<Investment>();
            investments.Add(sharesies);
            investments.Add(hatch);
            investments.Add(stake);

            System.Console.WriteLine($"\n{regularInvestmentAmount:c}NZD, every {investmentFrequencyMonths} months, for {investmentTimeMonths} months ({investmentTimeMonths/12} years):");

            foreach (Investment inv in investments)
            {
                inv.Simulate(investmentTimeMonths, investmentFrequencyMonths, regularInvestmentAmount);
                System.Console.WriteLine();
            }
        }
    }
}
