using System.ComponentModel.Design;

namespace BankAccountSimulation
{
    public static class MenuHelper
    {

        public static int UserInput;
        public static int Balance;
        public static int Deposit;

        public static void ShowMenu()
        {
            Console.WriteLine("Hello! What would you like to do today?");
            Console.WriteLine("1) Deposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Show Balance");
            Console.WriteLine("4) Log Out");
        }

        public static void deposit()
        {
            Console.Write("\nUser: ");
            UserInput = Convert.ToInt32(Console.ReadLine());

            while (UserInput == 1)
            {
                Console.Write("How much would you like to deposit?: ");
                Deposit = Convert.ToInt32(Console.ReadLine());
                Balance += Deposit;
                Console.WriteLine($"\nDeposit successful, new balance: {Balance}\n");
                break;
            }

        }

        public static void Withdraw()
        {
            while (UserInput == 2) 
            {
                Console.Write("How much would you like to withdraw?: ");
                Console.ReadLine();
            }
        }

        /* if (UserInput == 2)
            {
                Console.WriteLine("How much would you like to withdraw?");
            }

            else if (UserInput == 3)
            {
                Console.WriteLine($"You currently have: {Balance}");
            }

            else
{
    Console.WriteLine("We hope to see your again");
}

        */

    }
}
