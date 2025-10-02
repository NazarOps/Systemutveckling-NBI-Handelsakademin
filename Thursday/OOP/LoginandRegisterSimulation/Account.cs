namespace LoginandRegisterSimulation
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        
        public Account() { }

        public Account (string Username, string Password)
        {
            username = Username;
            password = Password;
        }
        public void Register()
        {
            Console.WriteLine("Enter your username and password to register");
            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.WriteLine("Now enter a password");
            Console.Write("Password: ");
            password = Console.ReadLine();

            if (password.Length <= 6)
            {
                Console.WriteLine("Your password must be at least or longer than 6 characters");
            }

            else if (char.IsDigit(password[0]))
            {
                Console.WriteLine("Your password can not start with a number!");
            }

            else if (password.Any(char.IsDigit)) // Any checks if a string contains a number or letter
            {
                Console.WriteLine("your password contains a number");
            }

            else if (password.Any(char.IsSymbol))
            {
                Console.WriteLine("your password contains a symbol");

            }

            else if (password.Any(char.IsSymbol && char.IsDigit))
            {
                Console.WriteLine("Register successful!");
            }

        }

        public void Login()
        {

        }

        public void CheckPsswdStrngth()
        {

        }

    }
}
