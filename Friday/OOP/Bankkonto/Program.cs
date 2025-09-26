namespace Bankkonto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit();
            account.ShowBalance();
        }
    }
}