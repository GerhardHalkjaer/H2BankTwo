using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo
{
    class SavingsAccount : Account
    {
        public SavingsAccount(string name, int id)
        {

        }


        public override void ChargeInterest()
        {
            throw new NotImplementedException();
        }
    }
}
