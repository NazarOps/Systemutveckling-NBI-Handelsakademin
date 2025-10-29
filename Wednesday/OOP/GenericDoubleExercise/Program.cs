using System.Security.Cryptography.X509Certificates;

namespace GenericDoubleExercise
{
    internal class Program
    {

 //       Skapa en generisk metod Duplicate<T>(T item) som returnerar en lista med två kopior av objektet.
 //       💡 Ex: Duplicate("Hej") → lista med "Hej", "Hej"

        static void Main(string[] args)
        {
            
            GenericList listofgenerics = new GenericList();
            
            var duplicatedlist = listofgenerics.Duplicate("Hej");

            foreach (var thingy in duplicatedlist)
            {
                Console.WriteLine(thingy);
            }
        }


       
    }
}
