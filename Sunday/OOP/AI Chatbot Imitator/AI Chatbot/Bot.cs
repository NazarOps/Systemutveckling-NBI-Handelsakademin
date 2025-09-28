namespace AI_Chatbot
{
    // make a public class called Bot
    public class Bot
    {
        // here i make a method that accepts user input
        public void userInput()
        {
            Console.WriteLine("Ask me anything!");
            string question = Console.ReadLine();
        }
        
        // make a method for the bot to generate a random answer from an array
        public void generateAnswer()
        {
            string[] answers =
            {
                "40 celcius, it's very hot!",
                "Haha, that's funny",
                "I like pizza",
                "Cats are funny"
            };

            // here we are using the random class to generate random answers from the array

            Random random = new Random();

            int index = random.Next(answers.Length);
            Console.WriteLine($"Chatbot says: " + answers[index]);

        }
    }
}
