namespace MultiplicationTableExercise
{
    public class loop
    {
        public string userInput;


    
    public void Start()
        {
            Console.WriteLine("Welcome to the multiplication table exercise");
            Console.WriteLine("Enter a number that you want the multiplication table for");

            userInput = Console.ReadLine();

            for (int userInput = 0; userInput < 9; userInput++)
            {
                Console.WriteLine(userInput * 1);
            }
        }
    }
}
