using Microsoft.VisualBasic;
using System.ComponentModel;

namespace If_ElseExercise
{
    public class User
    {
        public string Name;
        public int Age;
        public string License;

        public void UserInput()
        {
            Console.WriteLine("How old are you?");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have a valid Driver's license?");
            License = Console.ReadLine();

            if (Age >= 18 && License == "Yes")
            {
                Console.WriteLine("You are old enough for a license");
                Console.WriteLine("You own a license");
            }

            else
            {
                Console.WriteLine("You are not old enough for a Driver's license");

            }

        }
    }
}


