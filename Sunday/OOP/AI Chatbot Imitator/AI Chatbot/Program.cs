namespace AI_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            bot.userInput();
            bot.generateAnswer();
        }
    }
}
