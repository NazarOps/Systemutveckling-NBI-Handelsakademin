namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> GenericListWithStrings = new GenericList<string>();
            GenericList<int> GenericListWithInts = new GenericList<int>();

            GenericListWithStrings.Add("ThingOne");
            GenericListWithStrings.Add("ThingTwo");
            GenericListWithStrings.Add("ThingThree");

            GenericListWithInts.Add(1);
            GenericListWithInts.Add(2);
            GenericListWithInts.Add(3);

            var RetrieveStrings = GenericListWithStrings.Get(2);
            var RetrieveInts = GenericListWithInts.Get(0);

            Console.WriteLine(RetrieveStrings);
            Console.WriteLine(RetrieveInts);
           

        }
    }
}
