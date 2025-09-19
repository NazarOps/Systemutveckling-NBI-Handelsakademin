namespace Inlämningsuppgift_2
{
    public class Squat_racks : Equipment
    {
        public void InUse()
        {
            Console.WriteLine($"This squat rack is currently not in use. The brand is {Brand}, there are {AmountofEquipment} and most of them are {Condition}\n");
        }
    }
}
