using System.Reflection.Metadata;

namespace Bankkonto
{
    public class BankAccount
    {
        private int Balance {  get; set; }
        public BankAccount() 
        { 
            Balance = 0;    
        }

        public BankAccount(int balance) 
        { 
            Balance = balance;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void showBalance()
        {
            Console.WriteLine($"Your balance {Balance}");
        }
    }
}
