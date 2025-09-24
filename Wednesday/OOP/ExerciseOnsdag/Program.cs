namespace ExerciseOnsdag
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Här inne skapar vi objekt med mindre rad kod

            //Bil nummer 1
            Car carOne = new Car();
            carOne.collectInfo();
            carOne.printInfo();


            // Bil nummer 2
            Car carTwo = new Car();
            carTwo.collectInfo();
            carTwo.printInfo();


        }
    }
}
