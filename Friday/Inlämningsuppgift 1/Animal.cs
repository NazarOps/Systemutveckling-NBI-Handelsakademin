namespace Inlämningsuppgift_1
{
    // Här kommer vi att skapa en klass som blir vår huvudklass
    public class Animal
    {
        //Här ligger attributerna för klassen Animal, alltså egenskaper
        public string Size;
        public string Color;
        public string Type;
        public int Age;

        //Här kommer vara metoderna för klassen Animal, vad den kan göra
        public void info()
        {
            Console.WriteLine($"This animal is a {Type}, it's {Size}, has a {Color} color and is {Age} years old");
        }
        public virtual void Fly()
        {
            Console.WriteLine("This animal can not fly");
        }

    }


     
}
