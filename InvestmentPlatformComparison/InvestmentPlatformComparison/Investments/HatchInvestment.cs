using System;
using System.Collections.Generic;
using System.Text;
namespace InvestmentPlatformComparison.Investments
{
    class HatchInvestment : Investment
    {
        public HatchInvestment(decimal investmentAmount)
        {
            _initialInvestment = investmentAmount;
            _investmentAmount = investmentAmount;
            _exchangeFee = 0.005m;
            _isUSD = false;
        }
        public override void ChargeBrokerageFee()
        {
            _investmentAmount -= 3;
        }
        public override string PlatformName()
        {
            return "Hatch";
        }
    }
}