namespace LightweightPlatformComparator.Investments
{
    class HatchInvestment : Investment
    {
        private const decimal BROKERAGE_FEE = 3;
        
        public HatchInvestment()
        {
            _platformName = "Hatch";
            _exchangeFee = 0.005m;
        }

        public override void Simulate(int investmentTimeMonths, int investmentFrequencyMonths, decimal regularInvestmentAmount)
        {
            for (int i = 0; i < investmentTimeMonths; i += investmentFrequencyMonths)
            {
                // TODO: implement yearly tax fee.
                Buy(regularInvestmentAmount);
            }
            Sell(_investmentValueUSD);
            PrintResult();
        }

        public override decimal CalculateBrokerage(decimal investmentAmountUSD)
        {
            // TODO: implement if/else for number of shares
            return BROKERAGE_FEE;
        }
    }
}