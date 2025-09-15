namespace NewOnsdagExercise
{
    public class PersonOne
    {
        public int Height;
        public string Name;
        public string EyeColor;


        public void DisplayInfoAboutThisPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"EyeColor: {EyeColor}");
        }
    }
}
