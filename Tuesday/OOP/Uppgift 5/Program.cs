Console.ForegroundColor = ConsoleColor.Blue;
string text = Console.ReadLine();
Console.WriteLine(text);

Console.ForegroundColor = ConsoleColor.Red;
string textTwo = Console.ReadLine();
Console.WriteLine(text + " " + textTwo);
Console.ResetColor();