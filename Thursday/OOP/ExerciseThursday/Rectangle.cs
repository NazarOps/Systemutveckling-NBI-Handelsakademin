namespace ExerciseThursday
{
    public class Rectangle : Shape
    {
        public string Length;
        public string Height;
        public int Area;

        public override void CalculateArea()
        {
            Console.WriteLine("\nPlease input the dimensions for the length of a rectangle");
            Length = Console.ReadLine();

            Console.WriteLine("Now input the dimensions for the height of the rectangle");
            Height = Console.ReadLine();

            Area = Convert.ToInt32(Length) * Convert.ToInt32(Height);
            Console.WriteLine($"{Length} * {Height}");
            Console.WriteLine($"Area of rectangle is: {Area}");
        }
    }
}
