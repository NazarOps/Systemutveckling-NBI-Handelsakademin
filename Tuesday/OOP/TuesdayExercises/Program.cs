Console.WriteLine("Hello, what's your name?");
string name = Console.ReadLine();

Console.WriteLine("How old are you?");
string age = Console.ReadLine();
int userAge = Convert.ToInt32(age);
const int currentYear = 2025;
int birthYear = currentYear - userAge;

Console.WriteLine($"Hello {name}, you were born year {birthYear}.\nHope you will have a nice Tuesday!");

