using System;
using System.Collections.Generic;
using System.Threading;

namespace UserGradeCollection
{
    public class Grades
    {
        public string name;
        public int grade;
        public int total;

        
        Dictionary<string, int> Students = new Dictionary<string, int>(); // create a dictionary before intializing it for student grades

        bool isRunning = true; // wrap the menu in a while loop

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
                string UserInput = Console.ReadLine(); // Ask for user's choice

                if (UserInput == "a") // If user chooses a then add a new student by calling method
                {
                    AddStudent();
                }

                if (UserInput == "b") // If user chooses b then update an existing student's grade
                {
                    UpdateGrade();
                }

                if (UserInput == "c") 
                {
                    ShowStudents();
                }

                if (UserInput == "d")
                {
                    Console.WriteLine("Calculating...");
                    Thread.Sleep(1000);
                    CalculateAverageGrade();
                }
                
                if (UserInput == "Exit") // If user types in "Exit" then the application will end
                {
                    break;
                }
            }
        }

        public void AddStudent()
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
                    AddStudent();
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
                grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Grade has been successfully changed");
                Thread.Sleep(500);
                Console.Clear();
            }

            else
            {
                Console.WriteLine($"{UserInput} is not on the list \n");
                Thread.Sleep(500);
                Console.Clear();
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine("List of students and their grades:\n");

            foreach (KeyValuePair<string, int> student in Students)
            {
                Console.WriteLine($"Name: {student.Key}, Grade: {student.Value}");
                
            }

            Thread.Sleep(500);
            Console.Clear();
        }

        public void CalculateAverageGrade()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students have been added yet.\n");
                Thread.Sleep(500);
                Console.Clear();
                return;
            }

            total = 0;

            foreach (int grade in Students.Values)
            {
                total += grade;
            }

            double average = (double)total / Students.Count;

            Console.WriteLine($"\nThe average grade is {average:F2}\n");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}

