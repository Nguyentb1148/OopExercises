using System;

namespace OOPCSharpExercises.Bank.BankAccount
{
    public class Startup
    {
        public static void BankAccountMain()
        {
            BankAccount account = new BankAccount();
            account.Id = 1;
            account.Balance = 100;

            Console.WriteLine($"Account {account.Id}, balance {account.Balance}");
        }
    }
}