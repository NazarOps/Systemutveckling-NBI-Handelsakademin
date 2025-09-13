namespace Inlämningsuppgift_1
{
    //Subklassen som ärver från Animal
    public class Monkey : Animal
    {
        //Nya attributer och metoder samt att vi ärver allt från Animal klassen

        public string Size;

        // Nya metoder och gamla metoder från Animal
        public new void Jump()
        {
            Console.WriteLine("This Animal can jump");
        }
    }
}
