namespace TryCatch_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try    //try block checks for wrong input
                {
                    Console.Write("User: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input is a number");
                    Console.WriteLine("Closing application...");
                    break;
                }



                catch (FormatException) //catch catches the wrong input and throws and error
                {
                    Console.WriteLine("You must type in a number!");
                }
            }
        }
    }
}
