namespace Inlämningsuppgift_1
{
    public class Bat
    {
        public string Name;
        public int Age;
        public string Ability;
        public virtual void Fly()
        {
            Console.WriteLine("This animal is a bat and can fly");

            Console.WriteLine("Bat is a night creature");
        }       
    }

    public class Bird : Bat
    {
        public override void Fly()
        {
            Console.WriteLine("This Animal is a bird and can fly");

            Console.WriteLine("Bird is not a night creature");
        }
    }
}
