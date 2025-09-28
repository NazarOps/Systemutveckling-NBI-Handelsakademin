namespace Calculator
{
    public class Calculator
    {
        public int addition;
        public int multiplication;
        public int division;
        public int subtraction;


        public void Calculate()
        {
            Console.WriteLine("Hello, what would you like to calculate today?\n");
            Console.Write("\nUser: ");
            string numberOne = Console.ReadLine();
            Console.Write("User: ");
            string numberTwo = Console.ReadLine();
            
            Console.WriteLine($"\nAddition: {addition = Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo)}");
            Console.WriteLine($"Subtraction: {subtraction = Convert.ToInt32(numberOne) - Convert.ToInt32(numberTwo)}");
            Console.WriteLine($"Division: {division = Convert.ToInt32(numberOne) / Convert.ToInt32(numberTwo)}");
            Console.WriteLine($"Multiplication: { multiplication = Convert.ToInt32(numberOne) * Convert.ToInt32(numberTwo)}");
        }

    }
}   
