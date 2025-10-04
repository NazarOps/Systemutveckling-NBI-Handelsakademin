namespace LoginandRegisterSimulation
{
    public class Account
    {
        public string username { get; set; } // make a constructor with get; set;
        public string password { get; set; }

        public string UserLogin;            // make a string for user login and pass that
        public string UserPass;             // compares values between username and password, if true then login

        public Account() { }                // constructor

        public Account(string Username, string Password)        // constructor with attributes added
        {
            username = Username;
            password = Password;
        }

        bool isValid = false;                                   // made a boolean value that's false and used later
        public void Register()
        {
            Console.WriteLine("Enter your username and password to register");
            Console.Write("Username: ");
            username = Console.ReadLine();                     // assign readline to username and password

            Console.WriteLine("Now enter a password");
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        public void Login()                                 // login method
        {
            while (isValid == true)                         // using the while loop to prompt user to enter correct credentials
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("=== Login ===");
                Console.Write("Username: ");
                UserLogin = Console.ReadLine();
                Console.Write("Password: ");
                UserPass = Console.ReadLine();

                if (UserLogin == username && UserPass == password)
                {
                    Console.WriteLine("Login successful!");
                    Thread.Sleep(600);
                    break;                          // loop breaks if credentials are correct
                }

                else
                {
                    Console.WriteLine("Username and/or password is incorrect");
                }
            }
        }

        public void CheckPsswdStrngth()
        {
            while (isValid == false)            //here the code will check for strong password, if password weak then
            {                                   // isValid is false and loop will continue looping
                if (password.Length <= 6)
                {
                    Console.WriteLine("Your password must be at least 6 characters");
                    Register();

                }

                if (char.IsDigit(password[0]))
                {
                    Console.WriteLine("Your password can not start with a number!");
                    Register();
                }

                if (!password.Any(char.IsDigit)) // Any checks if a string contains a number or letter
                {
                    Console.WriteLine("your password must contain at least a number");
                    Register();
                }

                if (!password.Any(ch => char.IsSymbol(ch) || char.IsPunctuation(ch)))
                {
                    Console.WriteLine("Password must contain at least one special character (e.g. @, #, $, %, !)");
                    Register();

                }

                if (!password.Any(char.IsUpper))
                {
                    Console.WriteLine("your password must contain at least one capital letter");
                    Register();

                }

                //if (password.Length >= 6 && password.Any(char.IsDigit) && password.Any(ch => !char.IsLetterOrDigit(ch)) && password.Any(char.IsSymbol));
                //{
                //    Console.WriteLine("Register successful!");
                //    isValid = true;
                // }

                if (password == username)
                {
                    Console.WriteLine("your password can't be the same as your username!");
                    Register();
                }

                if (password.Any(ch => char.IsSymbol(ch) || char.IsPunctuation(ch) || char.IsUpper(ch))) // all conditions must be met
                {
                    Console.WriteLine("Register successful!");
                    isValid = true;                     // ending the loop here
                    Thread.Sleep(600);
                }
            }
        }
    }
}
