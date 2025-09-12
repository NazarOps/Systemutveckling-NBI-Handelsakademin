namespace Inlämningsuppgift_1
{
    // Här kommer vi att skapa en klass
    public class Animal
    {
        //Här ligger attributerna för klassen Animal, alltså egenskaper
        public string Size;
        public string Color;
        public string Type;
        public int Age;

        //Här kommer vara en metod för klassen Animal, vad den kan göra
        public void info()
        {
            Console.WriteLine("This animal can walk");
            Console.WriteLine($"This animal's color is {Color}");
            Console.WriteLine($"This animal is a {Type}");
            Console.WriteLine($"This animal is {Age} years old");
        }
    }
}
