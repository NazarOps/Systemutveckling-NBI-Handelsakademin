namespace ExerciseThursday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.CalculateArea();

            Rectangle rectangle = new Rectangle();
            rectangle.CalculateArea();

            Circle circle = new Circle();
            circle.CalculateArea();
        }
    }
}
