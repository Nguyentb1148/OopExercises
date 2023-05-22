namespace OOPCSharpExercises.Bank.BankAccountMethods
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }
    }
}