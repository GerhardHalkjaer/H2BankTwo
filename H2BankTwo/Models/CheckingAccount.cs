namespace H2BankTwo.Models
{
    class CheckingAccount : Account
    {
        public CheckingAccount(string name, int id)
        {
            Name = name;
            AccountNumber = id;
            Balance = 0;
        }

        public override void ChargeInterest()
        {
            if (Balance > 0)
            {
                //0.5%
                Balance *= 1.005M;
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
                    throw new OverdraftException("can't draw more then you have on your Checking Account");

                }
                _balance = value;

            }
        }

    }
}
