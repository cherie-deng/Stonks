using System;
using System.Collections.Generic;
using System.Text;
namespace InvestmentPlatformComparison.Investments
{
    class StakeInvestment : Investment
    {
        public StakeInvestment(decimal investmentAmount)
        {
            _initialInvestment = investmentAmount;
            _investmentAmount = investmentAmount;
            _exchangeFee = 0.01m;
            _isUSD = false;
        }
        public override void ChargeBrokerageFee()
        {
            _investmentAmount -= 0;
        }
        public override string PlatformName()
        {
            return "Stake";
        }
    }
}