﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo
{
    class Account
    {
        public Account()
        {

        }
        public string Name { get; }

        public decimal Balance { get; set; }
        public int AccountNumber { get; }

        public Account(string name, int accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }
    }
}
