namespace SwitchCaseExercise
{
    internal class Quiz
    {
        public string choice;
        
        public void Start()
        {
            Console.WriteLine("Question 1: what's the capital of Sweden");
            Console.WriteLine("a) Paris");
            Console.WriteLine("b) Berlin");
            Console.WriteLine("c) Stockholm");

            Console.Write("Choose your answer: ");

        }

        public void Answer()
        {
            choice = Console.ReadLine();

            switch (choice) 
            {
                case "a":
                    Console.WriteLine("Incorrect");
                    break;

                case "b":
                    Console.WriteLine("Incorrect");
                    break;

                case "c":
                    Console.WriteLine("Correct! The capital of Sweden is Stockholm");
                    break;

            }
                
            
        }



        


    }
}