using InvestmentPlatformComparison.Investments;
using System;
using System.Collections.Generic;
namespace InvestmentPlatformComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Compare();
        }
        static void Compare()
        {
            while (true)
            {
                Console.WriteLine("Enter investment amount (NZD):");
                Console.Write("$");
                var investmentAmount = Convert.ToDecimal(Console.ReadLine());
                SharesiesInvestment sharesies = new SharesiesInvestment(investmentAmount);
                HatchInvestment hatch = new HatchInvestment(investmentAmount);
                StakeInvestment stake = new StakeInvestment(investmentAmount);
                List<Investment> investments = new List<Investment>();
                investments.Add(sharesies);
                investments.Add(hatch);
                investments.Add(stake);
                foreach (Investment inv in investments)
                {
                    inv.ExchangeToUSD();
                    inv.ChargeBrokerageFee(); // Buy.
                    inv.ChargeBrokerageFee(); // Sell.
                    inv.ExchangeToNZD();
                    inv.DisplayResults();
                }
                Console.WriteLine();
            }
        }
    }
}