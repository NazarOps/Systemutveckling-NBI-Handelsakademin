namespace Inlämningsuppgift_1
{
    // Abstraktion är en klass som man kan inte göra ett objekt av
    //Huvudklassen är abstrakt

    public abstract class Chimpanzee
    {
        public abstract void jump();
        // vi har skapat en abstrakt klass som man kan inte göra ett objekt av
    }

    // alla subklasser som ärver från abstrakta klassen måste innehålla "jump()" metoden samt en egen implementering, alltså den måste skrivas över.

    // subklass

    public class Orangutang : Chimpanzee
    {
        public override void jump()
        {
            Console.WriteLine("Orangutang jumps");
        }
    }
}
