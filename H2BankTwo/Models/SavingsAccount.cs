using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
