namespace BankAccount
{
    class BankAccountDetails
    {
        public string AccountHolder;
        public double Balance;

        public BankAccountDetails(string name, double balance)
        {
            AccountHolder = name;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine(AccountHolder + " deposited " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine(AccountHolder + " withdrew " + amount);
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount");
            }

        }
    }
}
