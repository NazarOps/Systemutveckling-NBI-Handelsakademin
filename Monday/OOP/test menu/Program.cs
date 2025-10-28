using System;
using System.Collections.Generic;
using Spectre.Console;

namespace test_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> choices = new List<string>
            {
                "Start Game",
                "Options",
                "Credits",
                "Exit"
            };

           

            int selectedIndex = 0;
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("   _____ _   _____    __ __ ______   _________    __  _________\r\n  / ___// | / /   |  / //_// ____/  / ____/   |  /  |/  / ____/\r\n  \\__ \\/  |/ / /| | / ,<  / __/    / / __/ /| | / /|_/ / __/   \r\n ___/ / /|  / ___ |/ /| |/ /___   / /_/ / ___ |/ /  / / /___   \r\n/____/_/ |_/_/  |_/_/ |_/_____/   \\____/_/  |_/_/  /_/_____/   \r\n                                                               ");
                // Draw menu
                for (int i = 0; i < choices.Count; i++)
                {
                    if (i == selectedIndex)
                        AnsiConsole.MarkupLine($"[slowblink][green]{choices[i]}[/][/]"); // Highlight current selection
                    else
                        Console.WriteLine($"{choices[i]}");
                }

                // Read key without showing it
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        selectedIndex++;
                        if (selectedIndex >= choices.Count)
                            selectedIndex = 0; // Wrap around
                        break;

                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        selectedIndex--;
                        if (selectedIndex < 0)
                            selectedIndex = choices.Count - 1; // Wrap around
                        break;

                    case ConsoleKey.Enter:
                        
                        if(selectedIndex == 0)
                        {
                            // play game
                        }

                        if(selectedIndex == 1)
                        {
                            // options
                        }

                        if(selectedIndex == 2)
                        {
                            // show credits
                        }

                        if(selectedIndex == 3)
                        {
                            isRunning = false;
                        }
                        break;
                }
            }


        }
    }
}
