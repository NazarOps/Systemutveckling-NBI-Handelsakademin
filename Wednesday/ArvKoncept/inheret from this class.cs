namespace ArvKoncept
{
    internal class inheret_from_this_class
    {
    }

    public class Animal
    {
        int Legs = 4;
        string Color = "Orange";
        string Size = "Big";

        public void ShowInfo()
        {
            Console.WriteLine($"Legs: {Legs}, Color: {Color}, Size: {Size}");
        }
    }
}
