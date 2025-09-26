namespace ExerciseThursday
{
    public class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("\nPlease input the dimensions for the length of a rectangle");
            string bas = Console.ReadLine();

            Console.WriteLine("Now input the dimensions for the height of the rectangle");
            string höjd = Console.ReadLine();

            int area = Convert.ToInt32(bas) * Convert.ToInt32(höjd);
            Console.WriteLine($"{bas} * {höjd}");
            Console.WriteLine($"Area of rectangle is: {area}");
        }
    }
}
