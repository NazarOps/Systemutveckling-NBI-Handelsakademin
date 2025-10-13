using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExercise
{
    public class ListReverse
    {
        List<int> myList = new List<int>(); // create list of ints



        public void Input()
        {
            Console.WriteLine("What numbers do you want to store in the list?");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            myList.Add(UserInput);
        }

        public void Output()
        {
            while (myList.Count < 5)
            {
                Input();

                if (myList.Count == 5)
                {
                    myList.Reverse(); // reverse the list

                    Console.WriteLine("\n");

                    foreach (var number in myList)
                    {
                        Console.WriteLine($"{number}");
                    }

                    if (myList.Count == 5)
                    {
                        break;
                    }
                }
            }

        }

    }
}
