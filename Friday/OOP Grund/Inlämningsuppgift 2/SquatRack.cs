namespace Inlämningsuppgift_2
{
    public class SquatRack : Equipment
    {
        public void InUse()
        {
            Console.WriteLine($"This squat rack is currently not in use. The brand is {Brand}, there are {AmountOfEquipment} and most of them are {Condition}\n");
        }
    }
}
