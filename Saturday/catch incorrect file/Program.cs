using System.Runtime.InteropServices;
using System.Text.Json;

namespace catch_incorrect_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = "FileDoesNotExist.json";
                string readjson = File.ReadAllText("file");

                Console.WriteLine("File Content: ");
                Console.WriteLine(readjson);
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File does not exist!!!!");
            }

        }
    }
}
