using System;

namespace H2BankTwo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bank bank = new Bank();


            Console.WriteLine("********* Velkommen til {0} - Bank 1 *********",bank.BankName);
            Console.WriteLine("Ny konto oprettet til Katja med saldoen kr. {0}",bank.CreateAccount("Katja").Balance);
            Console.WriteLine("Kontoens saldo efter indsæt: kr. {0}",bank.Deposit(500));
            decimal withdraw = 300;
            Console.WriteLine("Kontoens saldo efter hævet {0} kr.: {1} kr.",withdraw,bank.Withdraw(withdraw));
            Console.WriteLine("Kontens saldo: kr. {0}",bank.Balance());


        }
    }
}
