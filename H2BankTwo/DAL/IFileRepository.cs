namespace H2BankTwo.DAL
{
    interface IFileRepository
    {
        public List<Account> GetAccounts();
        public void SaveAllAccounts(List<Account> lAcc);

    }
}
