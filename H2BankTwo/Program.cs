using System;
using System.Threading;

namespace H2BankTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
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
                        Console.WriteLine("Konto navn");
                        string navn = Console.ReadLine();
                        bank.CreateAccount(navn);
                        
                        Console.WriteLine("konto oprettet");
                        Thread.Sleep(2000);
                        break;

                    case "i":
                        Console.WriteLine("indtast beløb til indsæt");
                        int indsaet = int.Parse(Console.ReadLine());
                        Console.WriteLine("balance er nu: " + bank.Deposit(indsaet));
                        Thread.Sleep(2000);
                        break;

                    case "h":
                        Console.WriteLine(bank.Balance() + "kr.");
                        Console.WriteLine("indstast beløb der skal hæves");
                        int hæve = int.Parse(Console.ReadLine());
                        Console.WriteLine("balance er nu: " + bank.Withdraw(hæve));
                        Thread.Sleep(2000);
                        break;

                    case "s":
                        Console.WriteLine("saldo er: " + bank.Balance());
                        Thread.Sleep(2000);
                        break;

                    case "b":
                        Console.WriteLine("Denne bank er: " + bank.BankName);
                        Thread.Sleep(2000);
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
            Console.WriteLine("* Velkommen til EUC Syd banken - Bank2 *");
            Console.WriteLine("*---------------------------------------------------*");
            Console.WriteLine("* Vælg venlist... \t\t\t\t    *");
            Console.WriteLine("* m = Menu \t\t\t\t\t    *");
            Console.WriteLine("* k = Konto oprettes \t\t\t\t    *");
            Console.WriteLine("* i = Indsæt beløb \t\t\t\t    *");
            Console.WriteLine("* h = Hæv beløb \t\t\t\t    *");
            Console.WriteLine("* s = Vis Saldo \t\t\t\t    *");
            Console.WriteLine("* b = Vis bank \t\t\t\t\t    *");
            Console.WriteLine("* x = Afslut \t\t\t\t\t    *");
            Console.WriteLine("*****************************************************");
        }



    }
}
