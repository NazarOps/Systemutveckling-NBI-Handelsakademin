using System.Xml.Schema;

namespace Klass___Objekt
{
    public class Car
    {
        public int Model;
        public string Brand;
        public int ProductionYear;

        public void printinfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Year: {ProductionYear}");
        }
    
    }   
}
