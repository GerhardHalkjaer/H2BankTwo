using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using H2BankTwo.Models;
using System.IO;

namespace H2BankTwo.DAL
{
    class FileRepository : IFileRepository
    {
        string fileName = "accounts.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
        public List<Account> GetAccounts()
        {
            if (File.Exists(fileName))
            {
                List<Account> tempAcc;
                using (Stream reader = new FileStream(fileName, FileMode.Open))
                {
                    tempAcc = (List<Account>)serializer.Deserialize(reader);
                }
                return tempAcc;
            }
            else
            {

                return new List<Account>();
            }

        }

        public void SaveAllAccounts(List<Account> lAcc)
        {
            using (Stream writer = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(writer, lAcc);
            }
        }

        public void SaveAccount(Account acc)
        {
            List<Account> accounts = GetAccounts();
            accounts.Add(acc);
            SaveAllAccounts(accounts);
        }

        public void UpdateAccount(Account acc)
        {
            List<Account> accounts = GetAccounts();
            accounts[accounts.FindIndex(x => x.AccountNumber == acc.AccountNumber)] = acc;

            SaveAllAccounts(accounts);
        }


    }
}
