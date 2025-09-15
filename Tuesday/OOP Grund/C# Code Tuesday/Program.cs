using C__Code_Tuesday;
using System;

namespace C__Code_Tuesday
{
    public class Bank
    {
        string Bankaccount;

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