namespace GenericBoxExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericBox<string> boxwithstrings = new GenericBox<string>();
            GenericBox<int> boxwithints = new GenericBox<int>();
            GenericBox<double> boxwithdoubles = new GenericBox<double>();

            boxwithstrings.SetValue("String 1");
            boxwithstrings.SetValue("String 2");
            boxwithstrings.SetValue("String 3");

            boxwithints.SetValue(1);
            boxwithints.SetValue(2);
            boxwithints.SetValue(3);

            boxwithdoubles.SetValue(1.0f);
            boxwithdoubles.SetValue(2.0f);
            boxwithdoubles.SetValue(3.0f);

            boxwithdoubles.GetValue();
        }
    }
}
