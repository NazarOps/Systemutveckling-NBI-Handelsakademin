namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> mylistofstrings = new MyList<string>();
            mylistofstrings.PutItemsInList("Bacon");
            mylistofstrings.PutItemsInList("Hamburger");
            mylistofstrings.PutItemsInList("Pizza");

            mylistofstrings.ShowItemsInList();

            MyList<int> mylistofnumbers = new MyList<int>();
            mylistofnumbers.PutItemsInList(10);
            mylistofnumbers.PutItemsInList(20);
            mylistofnumbers.PutItemsInList(30);
            Console.Write("\n");

            mylistofnumbers.ShowItemsInList();
        }
    }
}
