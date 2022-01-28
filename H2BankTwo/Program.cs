using System;
using System.Threading;
using H2BankTwo.Repository;
using H2BankTwo.Models;


namespace H2BankTwo
{
    class Program
    {
       
        static void Main(string[] args)
        {

            
            Bank bank = new Bank();
            bank.WriteToLog("Bank Program started");
            string valg = "";
            while (!valg.Equals("x"))
            {
                Menu();
                valg = Console.ReadLine();

                switch (valg)
                {
                    case "m":

                        break;

                    case "k":
                        {
                            string _accountType ="";
                            do
                            {
                                AccountTypeMenu();
                                _accountType = Console.ReadLine().ToLower();
                            } while (!_accountType.Equals("m") && !_accountType.Equals("q") && !_accountType.Equals("c"));

                            Console.WriteLine("Konto navn");
                            string navn = Console.ReadLine();
                            Account acc = bank.CreateAccount(navn,_accountType);

                            Console.WriteLine("konto oprettet med konto nummer: {0}", acc.AccountNumber);
                            Thread.Sleep(2000);
                        }
                        break;

                    case "i":
                        {
                            Console.Write("indtast konto nummer:");
                            int kontoNummer = int.Parse(Console.ReadLine());
                            Console.WriteLine("indtast beløb til indsæt");
                            int indsaet = int.Parse(Console.ReadLine());
                            Console.WriteLine("balance er nu: {0}", bank.Deposit(kontoNummer, indsaet));
                            Thread.Sleep(2000);
                        }
                        break;

                    case "h":
                        {
                            Console.Write("indtast konto nummer:");
                            int kontoNummer = int.Parse(Console.ReadLine());
                            Console.WriteLine(bank.Balance(kontoNummer) + "kr.");
                            Console.WriteLine("indstast beløb der skal hæves");
                            int hæve = int.Parse(Console.ReadLine());
                            Console.WriteLine("balance er nu: {0}", bank.Withdraw(kontoNummer, hæve));
                            Thread.Sleep(2000);
                        }
                        break;

                    case "s":
                        {
                            Console.Write("indtast konto nummer:");
                            int kontoNummer = int.Parse(Console.ReadLine());
                            Console.WriteLine("saldo er: {0}", bank.Balance(kontoNummer));
                            Thread.Sleep(2000);
                        }
                        break;

                    case "b":
                        Console.WriteLine("Denne bank er: " + bank.BankName);
                        Console.WriteLine("Bankens beholding er: {0}", bank.BankBeholder);
                        Thread.Sleep(2000);
                        break;

                    case "g":
                        Console.WriteLine("Log..");
                        Console.WriteLine(bank.ReadFromLog());
                        Console.WriteLine("press any key to constinue..");
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }

            }




        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Velkommen til banken - Bank2 *");
            Console.WriteLine("*---------------------------------------------------*");
            Console.WriteLine("* Vælg venlist... \t\t\t\t    *");
            Console.WriteLine("* m = Menu \t\t\t\t\t    *");
            Console.WriteLine("* k = Konto oprettes \t\t\t\t    *");
            Console.WriteLine("* i = Indsæt beløb \t\t\t\t    *");
            Console.WriteLine("* h = Hæv beløb \t\t\t\t    *");
            Console.WriteLine("* s = Vis Saldo \t\t\t\t    *");
            Console.WriteLine("* b = Vis bank \t\t\t\t\t    *");
            Console.WriteLine("* g = Vis log \t\t\t\t\t    *");
            Console.WriteLine("* x = Afslut \t\t\t\t\t    *");
            Console.WriteLine("*****************************************************");
        }

        static void AccountTypeMenu()
        {
            Console.Clear();
            Console.WriteLine("Vælg Konto Type.");
            Console.WriteLine("c: for Checking konto.");
            Console.WriteLine("m: for MasterCard konto.");
            Console.WriteLine("q: for Savings konto");

        }


    }
}
