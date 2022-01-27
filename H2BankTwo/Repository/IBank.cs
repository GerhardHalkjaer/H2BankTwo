using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2BankTwo.Models;

namespace H2BankTwo.Repository
{
    interface IBank
    {
        public string BankName { get; }
        public decimal BankBeholder { get; }

        public Account CreateAccount(string name,string type);
        public decimal Deposit(int accountNumber, decimal amount);
        public decimal Withdraw(int accountNumber, decimal amount);
        public decimal Balance(int accountNumber);
        public List<AccountListItem> GetAccountList();



    }
}
