Console.WriteLine("Hello, please type in a number");
string number = Console.ReadLine();

Console.WriteLine("Please type in another number");
string numberTwo = Console.ReadLine();

int sum = Convert.ToInt32(numberTwo) + Convert.ToInt32(number);
int product = Convert.ToInt32(numberTwo) * Convert.ToInt32(number);
Console.WriteLine($"\nYour total sum is {sum}");
Console.WriteLine($"Your product is {product}\n");
