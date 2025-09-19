namespace Inlämningsuppgift_2
{
    public class Bench_press : Equipment
    {
        public void InUse()
        {
            Console.WriteLine($"This Bench press is currently in use. It's a {Brand} brand and there are {AmountofEquipment} of them.");
        }
    }
}
