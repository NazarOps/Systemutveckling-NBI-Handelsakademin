using System.Runtime.InteropServices;

namespace ExerciseThursday
{
    public class Circle : Shape 
    {
        public string radius;
        public float pi;
        public float area;


        public override void CalculateArea()
        {
            Console.WriteLine("\nPlease input the dimensions for the radius of a circle");
            radius = Console.ReadLine();
            pi = 3.14f;

            area = pi * Convert.ToInt32(radius) * Convert.ToInt32(radius);
            Console.WriteLine($"{pi} * {radius} * {radius}");
            Console.WriteLine($"Area of a circle is: {area}");
        }
    }
}
