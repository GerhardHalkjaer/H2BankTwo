using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
