namespace Inlämningsuppgift_2
{
    public class BenchPress : Equipment
    {
        public void InUse()
        {
            Console.WriteLine($"This Bench press is currently in use. It's a {Brand} brand and there are {AmountOfEquipment} of them.\n");
        }
    }
}
