using static System.Net.Mime.MediaTypeNames;

namespace GenericBoxExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //🧩 1.En enkel Generisk Box
            //Skapa en generisk klass Box<T> som kan lagra ett värde av vilken typ som helst.
            // ✅ Lägg till metoder:
            //SetValue(T value)
            //GetValue()

            //💡 Testa med både int, string och double.

            GenericBox<string> boxwithstrings = new GenericBox<string>();
            GenericBox<int> boxwithints = new GenericBox<int>();
            GenericBox<double> boxwithdoubles = new GenericBox<double>();

            boxwithstrings.SetValue("String 1");
            boxwithstrings.SetValue("String 2");
            boxwithstrings.SetValue("String 3");

            boxwithints.SetValue(1);
            boxwithints.SetValue(2);
            boxwithints.SetValue(3);

            boxwithdoubles.SetValue(1.2f);
            boxwithdoubles.SetValue(2.4f);
            boxwithdoubles.SetValue(3.6f);

            Console.WriteLine(boxwithdoubles.GetValue());
            Console.WriteLine(boxwithstrings.GetValue());
            Console.WriteLine(boxwithints.GetValue());
        }
    }
}
