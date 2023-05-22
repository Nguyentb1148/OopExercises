using System;
using System.Collections.Generic;
using System.Globalization;

namespace OOPCSharpExercises.Bank.Person
{
    public class Startup
    {
        public static void PersonMain()
        {
            BankAccount firstAccount = new BankAccount();
            firstAccount.Id = 1;
            firstAccount.Balance = 100;
            
            BankAccount secondAccount = new BankAccount();
            secondAccount.Id = 2;
            secondAccount.Balance = 200;

            List<BankAccount> accounts = new List<BankAccount> { firstAccount,secondAccount};
            Person person = new Person("Ben", 21, accounts);
            Console.WriteLine($"Name: {person.Name}, age:{person.Age}, total balance: {person.GetBalance():F2}");
        }
    }
}