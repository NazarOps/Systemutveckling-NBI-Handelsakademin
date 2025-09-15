namespace Klass___Objekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car CarTwo = new Car();
            CarTwo.Brand = "Toyota";
            CarTwo.Model = 500;
            CarTwo.ProductionYear = 1996;

            CarTwo.printinfo();
        }
    }
}
