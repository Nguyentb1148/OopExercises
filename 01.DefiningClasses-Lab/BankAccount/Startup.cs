using System;

namespace OOPCSharpExercises.DefiningClasses_Lab.BankAccount
{
    public class Startup
    {
        public static void BankAccountMain()
        {
            DefiningClasses_Lab.BankAccount.BankAccount account = new DefiningClasses_Lab.BankAccount.BankAccount();
            account.Id = 1;
            account.Balance = 100;

            Console.WriteLine($"Account {account.Id}, balance {account.Balance}");
        }
    }
}