namespace Inlämningsuppgift_2
{
    public class Machines : Equipment
    {
            public void InUse()
            {
                Console.WriteLine($"This Machine is currently not in use. It's a {Brand} brand. It's in {Condition} condition and there are {AmountofEquipment} of them.");
            }
    }
}
