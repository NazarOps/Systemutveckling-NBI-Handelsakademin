namespace ExerciseThursday
{
    public class Square : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("Please input the dimensions of square");
            string side = Console.ReadLine();

            int sum = Convert.ToInt32(side) * Convert.ToInt32(side);
            Console.WriteLine($"{side} * {side}");
            Console.WriteLine($"The area of a square is: {sum}cm");
            
            
        }
    }
}
