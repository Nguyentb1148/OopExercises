using System;
using System.Collections.Generic;

namespace OOPCSharpExercises.Bank.TestClient
{
    public class Startup
    {
        public static void ClientMain()
        {
         Dictionary<int, BackAccount> bank = new Dictionary<int, BackAccount>();

        string input = Console.ReadLine();//Initialize by formula: Action id amount
            
        while( input !="End")
        {
            string[] inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = inputParts[0];
            switch (command)
            {
                case "Create"://Initialize by formula: Action id 
                    Create(bank, inputParts);
                    break;
                case "Deposit"://Initialize by formula: Action id amount
                    Deposit(bank,inputParts);
                    break;
                case "WithDraw" ://Initialize by formula: Action id amount
                    WithDraw(bank,inputParts);
                    break;
                case "Print"://Initialize by formula: Action id 
                    Print(bank,inputParts);
                    break;
            }

            input = Console.ReadLine();
        }
        }

        private static void Print(Dictionary<int, BackAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);
            if (bank.TryGetValue(id, out var value))
            {
                Console.WriteLine($"Account Id {id}, balance {value.Balance:F2}");
            }
            else
            {
                Console.WriteLine("Account dose not exist");
            }
        }

        private static void WithDraw(Dictionary<int, BackAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);
            decimal amount = decimal.Parse(inputParts[2]);
            if (bank.ContainsKey(id))
            {
                if (amount > bank[id].Balance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    bank[id].WithDraw(amount);
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(Dictionary<int, BackAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);
            decimal amount = decimal.Parse(inputParts[2]);
            if (bank.TryGetValue(id, out var value))
            {
                value.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(Dictionary<int, BackAccount> bank, string[] inputParts)
        {
            int id = int.Parse(inputParts[1]);
            if (!bank.ContainsKey(id))
            {
                BackAccount account = new BackAccount();
                account.Id = id;
                bank[id] = account;
            }
            else
            {
                Console.WriteLine("Account already exist");
            }
        }
    }
}