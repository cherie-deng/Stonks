namespace LightweightPlatformComparator.Investments
{
    class StakeInvestment : Investment
    {
        public StakeInvestment()
        {
            _platformName = "Stake";
            _exchangeFee = 0.01m;
        }

        public override void Simulate(int investmentTimeMonths, int investmentFrequencyMonths, decimal regularInvestmentAmount)
        {
            for (int i = 0; i < investmentTimeMonths; i += investmentFrequencyMonths)
            {
                Buy(regularInvestmentAmount);
            }
            Sell(_investmentValueUSD);
            PrintResult();
        }

        public override decimal CalculateBrokerage(decimal investmentAmountUSD)
        {
            return 0; // Stake does not charge brokerage fees.
        }
    }
}