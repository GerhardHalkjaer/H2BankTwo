using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo.Models
{
    class MasterCardAccount : Account
    {
        public MasterCardAccount(string name, int id)
        {
            Name = name;
            AccountNumber = id;
            Balance = 0;
        }

        public override void ChargeInterest()
        {
            if (Balance > 0)
            {
                Balance *= 1.001M;
            }
            else if (Balance < 0)
            {
                Balance *= 1.2M;
            }
        }
    }
}
