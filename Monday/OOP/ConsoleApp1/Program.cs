/* Console.WriteLine("Please Enter your name");
string name = Console.ReadLine();
Console.WriteLine("Please enter your favourite color");
string color = Console.ReadLine();
Console.WriteLine($"Hi {name}! Your favourite color is {color}!"); */

/*
// Vi tar in input som en sträng
Console.WriteLine("Write your first number: ");
string Number = Console.ReadLine();
Console.WriteLine("Write your second number: ");
string Number2 = Console.ReadLine();

// Här konverterar vi strängen till int
int num1 = int.Parse(Number);
int num2 = int.Parse(Number2);

//skriver ut resultatet
int sum = num1 + num2;
Console.WriteLine($"Result: {sum}");

*/

/* 
const decimal moms = 0.12m;
Console.WriteLine($"Moms: {moms}");
Console.WriteLine("skriv in antal pizzor: ");
string input = Console.ReadLine();

Console.WriteLine("skriv in pris per pizza: ");
string inputTwo = Console.ReadLine();

int antalPizzor = Convert.ToInt32(input);
int prisPerPizza = Convert.ToInt32(inputTwo);

decimal totalUtanMoms = antalPizzor * prisPerPizza;
decimal totalMedMoms = totalUtanMoms * (1 * moms);

Console.WriteLine($"Med moms: {totalMedMoms}");
Console.WriteLine($"Utan moms: {totalUtanMoms}");

*/

Random rnd = new Random();
int number = rnd.Next(1, 7); // 1 till 6
Console.WriteLine($"Du kastade på tärning 1: {number}");
int numberTwo = rnd.Next(1, 7); // nästa tärning 1 till 6 också
Console.WriteLine($"Du kastade på tärning 2: {numberTwo}");
Console.WriteLine($"Total summa: {number + numberTwo}");