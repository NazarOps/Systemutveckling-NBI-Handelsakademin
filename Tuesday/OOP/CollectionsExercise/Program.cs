using System.Runtime.InteropServices;

namespace CollectionsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Övning 1
            //List<string> ListOfUserInputs = new List<string>();

            //while (ListOfUserInputs.Count < 5)
            //{
            //    Console.Write("User: ");
            //    string userinput = Console.ReadLine();

            //    ListOfUserInputs.Add(userinput);

            //    if (ListOfUserInputs.Count == 5)
            //    {
            //        ListOfUserInputs.Reverse();     // reverse needs to be outside loop

            //        foreach (var i in ListOfUserInputs)     // use a variable to print out items from list
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}


            // Övning 2

            List<string> ListOfNames = new List<string>();      // create a list of strings

            Console.WriteLine("Please input 5 names");

            while (ListOfNames.Count < 5)       // while list contains less than 5 strings
            {
                Console.Write("User: ");
                string UserInput = Console.ReadLine();

                ListOfNames.Add(UserInput);  // keep adding until list reaches 5 strings

                if (ListOfNames.Count == 5)
                {
                    break;
                }
            }

            Console.WriteLine("\nRemoved duplicates\n ");

            var DistinctNames = ListOfNames.Distinct();     // removes duplicates

            Console.WriteLine(string.Join(", ", DistinctNames));
            
        }
    }
}
