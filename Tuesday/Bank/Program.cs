using System;

namespace Bank
{
    public class Bank
    {
        string BankAccount;
        string User;
        string Admin;
        int Money;

        public void Start()
        {
            Console.WriteLine("Welcome to bank");
            Console.WriteLine("How is your day?");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank account = new Bank();
            account.Start();
        }
    }
}

