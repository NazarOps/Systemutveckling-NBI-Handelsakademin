namespace ExerciseTisdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här skapar jag ett objekt av typ spelare
            Spelare spelare1 = new Spelare();
            
            spelare1.Namn = "Nazar";
            
            spelare1.NummerPåTröjan = "1";

            spelare1.Springa();

            Console.WriteLine(spelare1.Namn);
        }
    }

    // Här skapar jag en ny klass
    public class Spelare
    {
        // Varje klass består av Attributer och Metoder

        // Attributer - Egenskaper
        public string Namn;

        public string NummerPåTröjan;

        // Metoder - Vad kan denna klassen göra
        public void Springa()
        {
            Console.WriteLine("Spelare springer");
        }

        
    }
}
