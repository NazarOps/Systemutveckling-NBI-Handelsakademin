namespace Bankkonto
{
    public class BankAccount
    {
        // private field
        private int _balance;

        // constructor
        public BankAccount()
        {
            _balance = 0;
        }
        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        // deposit money
        public void Deposit()
        {
            Console.Write("How much do you want to deposit?: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput < 0)
            {
                Console.WriteLine("\nBalance can't be negative");
                Balance = 0;
                
                Console.WriteLine("Please try again");
            }

            else
            {
                Balance += userInput;
            }
        }

        // show balance
        public void ShowBalance()
        {
            Console.WriteLine($"\nYour balance is {Balance}");
        }
    }
}
