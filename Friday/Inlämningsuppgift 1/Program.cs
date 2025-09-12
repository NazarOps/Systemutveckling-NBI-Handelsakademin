namespace Inlämningsuppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Här inne skapar vi ett objekt av klassen Animal
            Animal myAnimal = new Animal();
            myAnimal.Size = "Big";
            myAnimal.Color = "Orange";
            myAnimal.Type = "Cat";
            myAnimal.Age = 11;

            myAnimal.info();       

        }
    }

    
}

