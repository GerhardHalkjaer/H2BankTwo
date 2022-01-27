using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2BankTwo.Models
{
    class AccountListItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public Type AccountType { get; set; }


    }
}
