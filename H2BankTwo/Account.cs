﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo
{
    abstract class Account
    {
        public Account()
        {

        }
        public string Name { get; protected set; }

        public decimal Balance { get; set; }
        public int AccountNumber { get; protected set; }

        public Account(string name, int accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }

        public abstract void ChargeInterest();
    }
}
