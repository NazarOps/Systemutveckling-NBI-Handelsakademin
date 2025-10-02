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

        bool isValid = false;
        public void Register()
        {
            Console.WriteLine("Enter your username and password to register");
            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.WriteLine("Now enter a password");
            Console.Write("Password: ");
            password = Console.ReadLine();

           

        }

        public void Login()
        {

        }

        public void CheckPsswdStrngth()
        {
            if (password.Length <= 6)
            {
                Console.WriteLine("Your password must be at least 6 characters");
                isValid = false;
            }

            if (char.IsDigit(password[0]))
            {
                Console.WriteLine("Your password can not start with a number!");
                isValid = true;
            }

            if (!password.Any(char.IsDigit)) // Any checks if a string contains a number or letter
            {
                Console.WriteLine("your password must contain at least a number");
                isValid = false;
            }

            if (!password.Any(char.IsSymbol))
            {
                Console.WriteLine("your password must contain at least one symbol");
                isValid = false;

            }

            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("your password must contain at least one capital letter");
                isValid = false;

            }

            if (password.Length >= 6 && password.Any(char.IsDigit) && password.Any(ch => !char.IsLetterOrDigit(ch)) && password.Any(char.IsSymbol));
            {
                Console.WriteLine("Register successful!");
                isValid = true;
            }
        }

            

}
}
