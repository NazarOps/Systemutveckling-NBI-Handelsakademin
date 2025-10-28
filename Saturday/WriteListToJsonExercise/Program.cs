using System.Text.Json;

namespace WriteListToJsonExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> mylist = new List<string>();
            //mylist.Add("item 1");
            //mylist.Add("item 2");
            //mylist.Add("item 3");


            //string savejson = JsonSerializer.Serialize(mylist);

            //File.WriteAllText("mylist.json", savejson);

            //Console.WriteLine("list saved to json");

            string FileToRead = "myList.json";
            string readJson = File.ReadAllText(FileToRead);

            Console.WriteLine(readJson);
        }
    }
}
