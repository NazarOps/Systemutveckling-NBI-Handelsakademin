namespace Inlämningsuppgift_2
{
    public class Equipment
    {
        public string Brand;
        public string Condition;
        public string Type;
        public int AmountofEquipment;

        public void info()
        {
            Console.WriteLine($"This equipment is made by {Brand}, it's {Condition}, it's a {Type} and there are {AmountofEquipment} of them. \n");
        }
    }
}
