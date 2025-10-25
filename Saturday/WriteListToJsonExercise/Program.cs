using System.Text.Json;

namespace WriteListToJsonExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> myList = new List<string>();
            //myList.Add("Item 1");
            //myList.Add("Item 2");
            //myList.Add("Item 3");


            //string saveJson = JsonSerializer.Serialize(myList);

            //File.WriteAllText("myList.json", saveJson);

            //Console.WriteLine("List saved to json");

            string FileToRead = "myList.json";
            string readJson = File.ReadAllText(FileToRead);

            Console.WriteLine(readJson);
        }
    }
}
