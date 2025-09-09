namespace Arv_princip
{
    // Polymorphism exempel

    // Huvudklassen
    public class Vehicle
    {
        public string Namn;

        public string Modell;

        public virtual void StartaMotor()
        {
            Console.WriteLine("Vehicle motor start");
        }
    }

    public class Bil : Vehicle
    {
        public override void StartaMotor()
        {
            Console.WriteLine("Bilmotor start");
        }
    }
    public class Motorcycle : Vehicle
    {
        public override void StartaMotor()
        {
            Console.WriteLine("Motorcykel start");
        }
    }

}


