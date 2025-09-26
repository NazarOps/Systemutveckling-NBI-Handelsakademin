namespace ExerciseThursday
{
    public class Circle : Shape 
    {
        public override void CalculateArea()
        {
            Console.WriteLine("\nPlease input the dimensions for the radius of a circle");
            string radius = Console.ReadLine();
            float pi = 3.14f;

            float area = pi * Convert.ToInt32(radius) * Convert.ToInt32(radius);
            Console.WriteLine($"{pi} * {radius} * {radius}");
            Console.WriteLine($"Area of a circle is: {area}");
        }
    }
}
