namespace OOPCSharpExercises.DefiningClasses_Lab.TestClient
{
    public class BackAccount
    {
        private int _id;
        private decimal _balance;

        public decimal Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
        }
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
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
            return $"Account {this.Id},balance {this.Balance}";
        }
    }
}