using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2BankTwo.Models;
namespace H2BankTwo.DAL
{
    interface IFileRepository
    {
        public List<Account> GetAccounts();
        public void SaveAllAccounts(List<Account> lAcc);

    }
}
