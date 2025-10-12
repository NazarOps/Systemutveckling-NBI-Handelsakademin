using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExercise
{
    public class QueueProgram
    {
        public string UserInput;

        bool isRunning = true; // create a loop for later

        // create a queue
        Queue<string> customerQueue = new Queue<string>();

        public void Run()
        {
            // ASCI text
            Console.WriteLine("   ____                           ______                    _         \r\n  / __ \\__  _____  __  _____     / ____/  _____  __________(_)_______ \r\n / / / / / / / _ \\/ / / / _ \\   / __/ | |/_/ _ \\/ ___/ ___/ / ___/ _ \\\r\n/ /_/ / /_/ /  __/ /_/ /  __/  / /____>  </  __/ /  / /__/ (__  )  __/\r\n\\___\\_\\__,_/\\___/\\__,_/\\___/  /_____/_/|_|\\___/_/   \\___/_/____/\\___/ \r\n                                                                      ");
            Console.WriteLine("1.) Add new information to the queue");
            Console.WriteLine("2.) Show next information");
            Console.WriteLine("3.) Finish a task");
            Console.WriteLine("4.) Show remaining");
            Console.WriteLine("5.) Quit program");
        }

        public void UserChoice()
        {
            Console.Write("\nUser: ");
            UserInput = Console.ReadLine();

            
                if (UserInput == "1")
                {
                        // Add information (to the end of queue)
                        Console.WriteLine("\nAdd information to the queue");
                        Console.Write("User: ");
                        string UserInputTwo = Console.ReadLine();

                        if (!string.IsNullOrEmpty(UserInputTwo)) // check that input is NOT empty
                        {
                            customerQueue.Enqueue(UserInputTwo);
                            Console.WriteLine($"Added '{UserInputTwo}' to the queue.");
                            Thread.Sleep(600);
                            Console.Clear();
                            
                        }
                        
                }
            
                if (UserInput == "2")
                {
                    Console.WriteLine($"Next in queue {customerQueue.Peek()}");
                    Thread.Sleep(600);
                    Console.Clear();
                   
                }

                if (UserInput == "3")
                {
                    Console.WriteLine($"{customerQueue.Dequeue()} has been dequeued.");
                    Thread.Sleep(600);
                    Console.Clear();
                }
                    
                if (UserInput == "4")
                {
                    foreach (string i in customerQueue)
                    {
                        Console.WriteLine($"\nQueue left: {i}");
                        
                    }
                    Thread.Sleep(600);
                    Console.Clear();
                }
        }
        
            
        public void Start()
        {   
            while (isRunning)
            {
                Run();
                UserChoice();

                if (UserInput == "5")
                {
                    break;
                }
            }
            
        }

        //public void Enqueue()
        //{
        //    // Add information (to the end of queue)
        //    Console.WriteLine("\nAdd information to the queue");
        //    Console.Write("User: ");
        //    UserInput = Console.ReadLine();

        //    if (!string.IsNullOrEmpty(UserInput)) // check that input is NOT empty
        //    {
        //        customerQueue.Enqueue(UserInput);
        //        Console.WriteLine($"Added '{UserInput}' to the queue.");
        //        Thread.Sleep(600);
        //        Console.WriteLine("Would you like to add something else?");
        //    }
        //    else
        //    {
        //    //    Console.WriteLine("Input cannot be empty. Please try again.");
        //    //}
        //}

        //public void QueueInformation()
        //{
       
        //}

        //public void Dequeue()
        //{
            
        //}

    }
}
