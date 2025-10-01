using System.ComponentModel.Design;

namespace BankAccountSimulation
{
    public static class MenuHelper
    {
        // Here we are going to use static intengers because the class is also static
        public static int UserInput;
        public static int Balance;
        public static int DepositMoney;
        public static int Withdraw;

        // call the method ShowMenu which displays the menu and the 4 alternatives you can do
        public static void ShowMenu()
        {
            Console.WriteLine("Hello! What would you like to do today?");
            Console.WriteLine("1) Deposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Show Balance");
            Console.WriteLine("4) Log Out");
        }

        // this is a separate method for userinteraction with the console
        public static void UserInteraction()
        {
            Console.Write("\nUser: ");
            UserInput = Convert.ToInt32(Console.ReadLine()); // takes in user input and converts it to integer

            // below here are the 4 alternatives the user can choose from, if user pressed 1, it will display deposit, if 2 then withdraw etc
            // if user inputs a number that's not from 1-4 then the application will close

            if (UserInput == 1)
            {
                Console.Write("How much would you like to deposit?: ");
                DepositMoney = Convert.ToInt32(Console.ReadLine());
                Console.Clear(); // added console.clear to keep the console clean and not confuse the user with old inputs
                

                if (DepositMoney <= 0)
                {
                    Console.WriteLine("Balance can't be negative!");
                    Console.WriteLine("No money has been deposited\n");
                    ShowMenu();
                    UserInteraction();
                }

                else if (DepositMoney > 0)
                {
                    Balance += DepositMoney; // the amount that user inputs will be added, if it was minus instead then it would be withdrawing
                    Console.WriteLine($"Deposit successful, new balance: {Balance}\n");
                    ShowMenu();
                    UserInteraction();
                }
            }

            if (UserInput == 2)
            {
                Console.Write("How much would you like to withdraw: ");
                Withdraw = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                if (Withdraw <= Balance)
                {
                    Balance -= Withdraw;
                    Console.WriteLine($"Successfully withdrawn: {Withdraw}");
                    Console.WriteLine($"New balance: {Balance}\n");
                }

                else if (Withdraw > Balance)
                {
                    Console.WriteLine("You can't withdraw more than you have!");
                    Console.WriteLine($"Your balance: {Balance}");
                }

                ShowMenu();
                UserInteraction();

            }

            if (UserInput == 3)
            {
                Console.WriteLine($"Your balance is {Balance}\n");
                ShowMenu();
                UserInteraction();
            }

            else if (UserInput == 4)
            {
                Console.WriteLine("Goodbye, have a nice day!");
                return;
            }

            else
            {
                Console.WriteLine("You have inputted the wrong keys");
                Console.WriteLine("This application will end");
                Console.WriteLine("Goodbye");
            }
        }
    }
}
