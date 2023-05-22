using System.Collections.Generic;
using System.Linq;

namespace OOPCSharpExercises.DefiningClasses_Lab.Person
{
    public class Person
    {
        private string _name;
        private int _age;
        private List<BankAccount> _accounts;

        public Person(string name, int age): this(name,age,new List<BankAccount>())
        {
            
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this._name = name;
            this._age = age;
            this._accounts = accounts;
        }

        public List<BankAccount> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        public decimal GetBalance()
        {
            decimal balance = this._accounts.Sum(a => a.Balance);
            return balance;
        }
    }
}