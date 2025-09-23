Console.WriteLine("Type in an integer");
string Number = Console.ReadLine();
int Number2 = Convert.ToInt32(Number);

Console.WriteLine("Type in a float");
string decimaltal = Console.ReadLine();
float decimalTal = Convert.ToSingle(decimaltal);

Console.WriteLine("Type in a boolean value");
string boolean = Console.ReadLine();
bool booleanValue = Convert.ToBoolean(boolean);

Console.WriteLine($"You typed in {Number}, {decimaltal}, {booleanValue}");
