namespace ExerciseThursday
{
    public class Square : Shape
    {
        public string side;
        public int area;

        public override void CalculateArea()
        {
            Console.WriteLine("Please input the dimensions of square");
            side = Console.ReadLine();

            area = Convert.ToInt32(side) * Convert.ToInt32(side);
            Console.WriteLine($"{side} * {side}");
            Console.WriteLine($"The area of a square is: {area}cm");
            
        }
    }
}
