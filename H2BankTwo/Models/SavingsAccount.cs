namespace H2BankTwo.Models
{
    class SavingsAccount : Account
    {
        public SavingsAccount(string name, int id)
        {
            Name = name;
            AccountNumber = id;
            Balance = 0;
        }


        public override void ChargeInterest()
        {
            if (Balance >= 100000M)
            {
                Balance *= 1.03M;
            }
            else if (Balance > 50000M)
            {
                Balance *= 1.02M;
            }
            else
            {
                Balance *= 1.01M;
            }
            
        }

        decimal _balance;
        public override decimal Balance
        {
            get => _balance;
            set
            {
                if (value < 0)
                { //throw an exception if attemp to draw more money then the account has.
                    throw new OverdraftException("can't draw more then you have savings account");

                }
                _balance = value;

            }
        }
    }
}
