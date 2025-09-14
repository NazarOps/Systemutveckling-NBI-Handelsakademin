namespace Inlämningsuppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Här inne skapar vi en instans av klassen Animal
            Animal myAnimal = new Animal();
            myAnimal.Size = "Big";
            myAnimal.Color = "Orange";
            myAnimal.Type = "Cat";
            myAnimal.Age = 11;

            myAnimal.info();    
            
            // Polymorphism
            Bat bat1 = new Bat();
            bat1.Fly();

            // Inkapsling hämtar namn data från strängen person 
            Person personNazar = new Person("Nazar");

            // Abstraktion
            Orangutang orangutang = new Orangutang();
            orangutang.jump();

            // Arv
            Animal animalOne = new Animal();
            animalOne.Jump();

            Monkey monkeyOne = new Monkey();
            monkeyOne.Jump();
                    

        }
    }

    
}

