# Fee calculation

## Steps to trade stocks

### Platform fees
- What one off fees are there?
- Is there a subscription fee?

### Deposit money

### Exchange to USD
- Calculate how much USD you will get on each platform
- `investmentAmount * (interbankRate - (interbankRate * platformExchangeRate))`

### Buy stocks (for each order)
- Subtract the brokerage fee from the USD
- Sharesies: `investmentAmount *= (1 - 0.005)`
- Hatch: `investmentAmount -= 3`
- Stake: `free`

### Hold
- The stock will hopefully go up in value, but for this calculation we just want to see what each platform would charge relative to the others, so this can be neglected

### Sell stocks (for each order)
- Subtract the brokerage fee from the USD after selling
- Sharesies: `investmentAmount *= (1 - 0.005)`
- Hatch: `investmentAmount -= 3`
- Stake: `free`

### Exchange to NZD
- Calculate how much NZD you will get on each platform
- `// TODO: find out what this calculation is`

### Withdraw money
- Are there any fees for withdrawing money?
- Sharesies: `// TODO: find out`
- Hatch: `// TODO: find out`
- Stake: `$2USD`