using System;
using System.Collections.Generic;
using System.Text;
namespace InvestmentPlatformComparison.Investments
{
    abstract class Investment
    {
        public const decimal INTERBANK_NZ2US = 0.74m; // TODO: make variable
        public const decimal INTERBANK_US2NZ = 1.36m; // TODO: calculate from INTERBANK_NZ2US?
        protected decimal _initialInvestment { get; set; }
        protected decimal _investmentAmount { get; set; }
        protected decimal _exchangeFee { get; set; }
        protected bool _isUSD { get; set; }
        // List<decimal> otherFees();
        public abstract void ChargeBrokerageFee();
        public abstract string PlatformName();
        public void ExchangeToUSD()
        {
            _investmentAmount *= (INTERBANK_NZ2US - (INTERBANK_NZ2US * _exchangeFee));
            _isUSD = true;
        }
        public void ExchangeToNZD()
        {
            _investmentAmount *= (INTERBANK_US2NZ - (INTERBANK_US2NZ * _exchangeFee));
            _isUSD = false;
        }
        public void DisplayResults()
        {
            var fees = _initialInvestment - _investmentAmount; // TODO: is there a better place to calculate this? add method?
            Console.WriteLine($"{PlatformName()}: {_investmentAmount:c}{(_isUSD ? "USD" : "NZD")} -> Total fees:{fees:c}");
        }
    }
}