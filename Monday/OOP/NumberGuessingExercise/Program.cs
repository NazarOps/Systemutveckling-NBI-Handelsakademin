namespace NumberGuessingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            user Userinput = new user();
            Userinput.StartGame();
            Userinput.UserGuess();

            Random random = new Random();
            int Target = random.Next(1, 100);


        }
    }
}
