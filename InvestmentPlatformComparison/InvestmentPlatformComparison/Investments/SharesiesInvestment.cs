using System;
using System.Collections.Generic;
using System.Text;
namespace InvestmentPlatformComparison.Investments
{
    class SharesiesInvestment : Investment
    {
        public SharesiesInvestment(decimal investmentAmount)
        {
            _initialInvestment = investmentAmount;
            _investmentAmount = investmentAmount;
            _exchangeFee = 0.004m;
            _isUSD = false;
        }
        public override void ChargeBrokerageFee()
        {
            _investmentAmount *= 0.995m; // 1 - 0.005
        }
        public override string PlatformName()
        {
            return "Sharesies";
        }
    }
}