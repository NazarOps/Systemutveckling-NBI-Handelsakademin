namespace Calculator
{
    public class Calculator
    {
        public int sum;
        public int product;
        public int remainder;
        public int sub;


        public void Calculate()
        {
            Console.WriteLine("Hello, what would you like to calculate today?\n");
            Console.Write("\nUser: ");
            string numberOne = Console.ReadLine();
            Console.Write("User: ");
            string numberTwo = Console.ReadLine();

            sum = Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo);
            sub = Convert.ToInt32(numberOne) - Convert.ToInt32(numberTwo);
            remainder = Convert.ToInt32(numberOne) / Convert.ToInt32(numberTwo);
            product = Convert.ToInt32(numberOne) * Convert.ToInt32(numberTwo);

            Console.WriteLine($"\nAddition: {sum}");
            Console.WriteLine($"Subtraction: {sub}");
            Console.WriteLine($"Division: {remainder}");
            Console.WriteLine($"Multiplication: {product}");
        }

    }
}   
