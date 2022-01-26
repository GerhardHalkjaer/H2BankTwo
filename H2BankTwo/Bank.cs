using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo
{
    class Bank
    {
        public string BankName = "Reaper Bank";
        Account account;

       

        public Account CreateAccount(string name)
        {
            account = new Account(name);
            return account;
        }

        public decimal Deposit(decimal amount)
        {
            account.Balance += amount;
            return account.Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            account.Balance -= amount;
            return account.Balance;
        }

        public decimal Balance()
        {
            return account.Balance;
        }

    }
}
