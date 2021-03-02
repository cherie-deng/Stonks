namespace LightweightPlatformComparator.Investments
{
    class SharesiesInvestment : Investment
    {
        private const decimal BROKERAGE_RATE = 0.005m;
        private decimal _subscriptionFees = 0; // TODO: need = 0?

        public SharesiesInvestment()
        {
            _platformName = "Sharesies";
            _exchangeFee = 0.004m;
        }

        public override void Simulate(int investmentTimeMonths, int investmentFrequencyMonths, decimal regularInvestmentAmount)
        {
            for (int i = 0; i < investmentTimeMonths; i += investmentFrequencyMonths)
            {
                if (i % 12 == 0) { ChargeSubscriptionFee(); }
                Buy(regularInvestmentAmount);
            }
            Sell(_investmentValueUSD);
            _walletValueNZD -= _subscriptionFees;
            PrintResult();
            System.Console.WriteLine($"Incl. subscription fees: {_subscriptionFees:c}NZD");
        }

        public override decimal CalculateBrokerage(decimal investmentAmountUSD)
        {
            return investmentAmountUSD * BROKERAGE_RATE;
        }

        public void ChargeSubscriptionFee()
        {
            _subscriptionFees += 30;
        }
    }
}