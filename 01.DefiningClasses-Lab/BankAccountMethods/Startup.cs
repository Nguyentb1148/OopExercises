using System;
using OOPCSharpExercises.DefiningClasses_Lab.TestClient;

namespace OOPCSharpExercises.DefiningClasses_Lab.BankAccountMethods
{
    public class Startup
    {
        public static void BankAccountMethodMain()
        {
            BackAccount account = new BackAccount();
            account.Id = 1;
            account.Deposit(100);
            account.WithDraw(25);
            Console.WriteLine(account.ToString());
        }
    }
}