namespace NewOnsdagExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonOne PersonTwo = new PersonOne();
            PersonTwo.Height = 180;
            PersonTwo.EyeColor = "Brown";
            PersonTwo.Name = "John Doe";

            PersonTwo.DisplayInfoAboutThisPerson();


        }
    }

}
