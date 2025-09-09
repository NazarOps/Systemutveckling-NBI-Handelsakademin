namespace Arv_princip
{
    // Arv exempel: en class ärver attributer och metoder från en annan class

    // Detta blir huvudklassen
    public class Animal
    {
        // Attributer av klassen Animal
        public string Namn;

        public int Age;

        // Metoder av klassen Animal

        public void Eat()
        {
            Console.WriteLine("This animal eats");
        }
        public void Sleep()
        {
            Console.WriteLine("This animal sleeps");
        }


    }

    // subklasser som ärver från Animal:

    public class Bat : Animal
    {
        // Nya attributer + alla attributer från animal
        public int Wingspan;

        // Nya metoder + alla metoder från animal
        public new void Sleep()
        {
            Console.WriteLine("This animal does not sleep");
        }
    }
}
