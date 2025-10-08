using System;
using System.Collections.Generic;
using System.Threading;

namespace UserGradeCollection
{
    public class Grades
    {
        public string name;
        public int grade;

        Dictionary<string, int> Students = new Dictionary<string, int>();

        bool isRunning = true;

        public void Menu()
        {
            while (isRunning = true)
            {
                Console.WriteLine("Welcome to school");
                Console.WriteLine("\nWhat would you like to do today?");
                Console.WriteLine("a) Add a new student");
                Console.WriteLine("b) Update student grade");
                Console.WriteLine("c) Show all students and grades");
                Console.WriteLine("d) Calculate average grade");
                Console.WriteLine("\nType Exit to quit program");

                Console.Write("\nUser: ");
                string UserInput = Console.ReadLine();

                if (UserInput == "a")
                {
                    Add();
                }

                if (UserInput == "b")
                {
                    UpdateGrade();
                }
                if (UserInput == "Exit")
                {
                    break;
                }
            }
        }

        public void Add()
        {
          
                Console.Write("What's the student's name?: ");
                name = Console.ReadLine();

                Console.Write("What's the student's grade?: ");
                grade = Convert.ToInt32(Console.ReadLine());

                Students.Add(name, grade);

                Console.WriteLine($"\nStudent {name} has been added with the grade {grade}\n");
                

                Console.WriteLine("Would you like to add another student y/n?");
                Console.Write("\nUser: ");

                string UserInput = Console.ReadLine();

                if(UserInput == "y")
                {
                    Add();
                }

                if(UserInput == "n")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                }
            
        }

        public void UpdateGrade()
        {
            Console.WriteLine("Which student's grade do you want to update?");
            string UserInput = Console.ReadLine();

            if (Students.ContainsKey(UserInput))
            {
                Console.WriteLine($"{UserInput} is in the list");
                Console.WriteLine($"What grade would you like to change {UserInput}'s to?: ");
            }

            else
            {
                Console.WriteLine($"{UserInput} is not on the list");
            }
        }
    }
}

