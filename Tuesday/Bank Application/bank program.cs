using System;

namespace Bank Application
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

