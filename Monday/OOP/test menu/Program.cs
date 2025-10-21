namespace test_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("[] choice two");
            Console.WriteLine("[] choice three");
            Console.WriteLine("[] choice four");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);

            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.DownArrow:
                    Console.WriteLine("[X] choice one");
                    break;


            }
            
        }
    }
}
