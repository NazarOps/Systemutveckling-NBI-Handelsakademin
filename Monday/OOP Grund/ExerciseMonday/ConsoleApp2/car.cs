namespace ConsoleApp2
{
    public class car
    {
        public string Name;
        public string model;
        public int year;


        public void info()
        {
            Console.WriteLine($"This car is a {Name}, the model is {model} and it was launched year {year}");
        }
    }


}
