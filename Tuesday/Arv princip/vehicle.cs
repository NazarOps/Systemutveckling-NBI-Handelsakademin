namespace Arv_princip
{

    internal class Program
    {

        static void Main(string[] args)
        {
            // app runs here
            Vehicle vehicle1 = new Vehicle();
            vehicle1.StartaMotor();

            Bil bil = new Bil();
            bil.StartaMotor();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.StartaMotor();
        }
    }
}
