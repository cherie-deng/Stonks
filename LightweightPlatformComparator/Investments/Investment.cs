using System;

namespace LightweightPlatformComparator.Investments
{
    abstract class Investment
    {
        public const decimal INTERBANK_NZ2US = 0.74m; // TODO: make variable
        public const decimal INTERBANK_US2NZ = 1.36m; // TODO: calculate from INTERBANK_NZ2US?
        
        protected string _platformName { get; set; }
        protected decimal _exchangeFee { get; set; }
        protected decimal _walletValueNZD { get; set; } // TODO: default to 0?
        protected decimal _investmentValueUSD { get; set; }

        protected decimal _totalInputNZD { get; set; }
        // TODO: add total tracking so can show cost breakdown
        // protected decimal _totalExchangeFees { get; set; }
        // protected decimal _totalBrokerageFees { get; set; }
        
        public abstract decimal CalculateBrokerage(decimal investmentAmountUSD);

        public abstract void Simulate(int investmentTimeMonths, int investmentFrequencyMonths, decimal regularInvestmentAmount);

        public void Buy(decimal amountNZD)
        {
            // Assume buy exchanges money to USD immediately.
            _totalInputNZD += amountNZD;
            var availableUSD = ExchangeToUSD(amountNZD);
            _investmentValueUSD += (availableUSD - CalculateBrokerage(availableUSD));
        }

        // public void IncreaseValue(){ // To simulate growth. }

        public void Sell(decimal amountUSD)
        {
            _investmentValueUSD -= amountUSD; // Remove investment from portfolio.
            var availableUSD = amountUSD - CalculateBrokerage(amountUSD);
            _walletValueNZD += ExchangeToNZD(availableUSD);
        }

        public decimal ExchangeToUSD(decimal amountNZD)
        {
            return amountNZD * (INTERBANK_NZ2US - (INTERBANK_NZ2US * _exchangeFee));
        }

        public decimal ExchangeToNZD(decimal amountUSD)
        {
            return amountUSD * (INTERBANK_US2NZ - (INTERBANK_US2NZ * _exchangeFee));
        }

        public void PrintResult()
        {
            // TODO: need System. ? remove if not
            System.Console.WriteLine($"\n{_platformName}:");
            System.Console.WriteLine($"Total money invested: {_totalInputNZD:c}NZD");
            // System.Console.WriteLine($"Investment value: {_investmentValueUSD:c}USD");
            System.Console.WriteLine($"Wallet value: {_walletValueNZD:c}NZD");
            System.Console.WriteLine($"Total fees: {_totalInputNZD - _walletValueNZD:c}NZD"); // "Difference:"
        }
    }
}