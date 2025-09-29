namespace NumberGuessingExercise
{
    public class user
    {
        public int Target;

        public void StartGame()
        {
            Console.WriteLine("Guess a number");
        }

        public void UserGuess()
        {

            int User = Convert.ToInt32(Console.ReadLine());

            while (User != Target)
            {
                if (User < Target)
                {
                    Console.WriteLine("Too low, try again!");
                }
                else if (User > Target)
                {
                    Console.WriteLine("Too high, try again!");
                }
                else (User = Target);
                {
                    Console.WriteLine("Congratulations, you guessed right!");
                }
            } 
        }
    }
}
