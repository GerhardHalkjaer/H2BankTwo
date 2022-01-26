﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo
{
    class Bank
    {
        public string BankName = "Reaper Bank";
        List<Account> accounts = new List<Account>();
        private int _accountNumberCounter = 0;
        public decimal BankBeholder { get; private set; } = 0;


        public Account CreateAccount(string name)
        {
            Account account = new Account(name, ++_accountNumberCounter);
            accounts.Add(account);
            return account;
        }

        public decimal Deposit(int accountNumber, decimal amount)
        {
            Account acc = accounts.Find(x => accountNumber == x.AccountNumber);
            acc.Balance += amount;
            BankBeholder += amount;
            return acc.Balance;
        }

        public decimal Withdraw(int accountNumber,decimal amount)
        {
            Account acc = accounts.Find(x => accountNumber == x.AccountNumber);
            acc.Balance -= amount;
            BankBeholder -= amount;
            return acc.Balance;
        }

        public decimal Balance(int accountNumber)
        {
            Account acc = accounts.Find(x => accountNumber == x.AccountNumber);
            return acc.Balance;
        }

    }
}
