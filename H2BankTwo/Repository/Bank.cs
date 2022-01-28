using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2BankTwo.Models;
using H2BankTwo.Utilities;

namespace H2BankTwo.Repository
{
    class Bank : IBank
    {
        public string BankName { get; private set; } = "Reaper Bank";
        List<Account> _accounts = new();
        private int _accountNumberCounter = 0;
        public decimal BankBeholder { get; private set; } = 0;


        public Account CreateAccount(string name, string type)
        {
            Account account;

            if (type.Equals("c"))
            {//checking
                account = new CheckingAccount(name, ++_accountNumberCounter);
            }
            else if (type.Equals("m"))
            {//master
                account = new MasterCardAccount(name, ++_accountNumberCounter);
            }
            else
            {//savings
                account = new SavingsAccount(name, ++_accountNumberCounter);
            }
            _accounts.Add(account);
            FileLogger.WrithToLog("new account created with id: " + account.AccountNumber);
            return account;
        }

        public decimal Deposit(int accountNumber, decimal amount)
        {
            Account acc = _accounts.Find(x => accountNumber == x.AccountNumber);
            acc.Balance += Math.Abs(amount);
            BankBeholder += Math.Abs(amount);
            FileLogger.WrithToLog("new deposit on account: " + acc.AccountNumber);
            return acc.Balance;
        }

        public decimal Withdraw(int accountNumber, decimal amount)
        {
            

            Account acc = _accounts.Find(x => accountNumber == x.AccountNumber);
            
            try
            {
                acc.Balance -= Math.Abs(amount);
                BankBeholder -= Math.Abs(amount);
                FileLogger.WrithToLog("new withdrawl on account: " + acc.AccountNumber);
            }
            catch (Exception e)
            {
                FileLogger.WrithToLog("error withdrawing money");
                Console.WriteLine(e.Message);
            }
            return acc.Balance;
        }

        public decimal Balance(int accountNumber)
        {
            Account acc = _accounts.Find(x => accountNumber == x.AccountNumber);
            return acc.Balance;
        }

        public List<AccountListItem> GetAccountList()
        {
            List<AccountListItem> _accLI = new();
            foreach (Account item in _accounts)
            {
                AccountListItem _acc = new();
                _acc.Id = item.AccountNumber;
                _acc.Name = item.Name;
                _acc.Balance = item.Balance;
                _acc.AccountType = item.GetType();
                _accLI.Add(_acc);
            }


            return _accLI;
        }

        public string ReadFromLog()
        {
            return FileLogger.ReadFromLog();
        }

        public void WriteToLog(string msg)
        {
            FileLogger.WrithToLog(msg);
        }


    }

}
