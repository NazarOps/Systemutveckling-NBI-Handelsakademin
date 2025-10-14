namespace Assignment_1___Job_Aplication_Tracker__Linq__OOP__Github_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool MenuLoop = true;

            while (MenuLoop)
            {
                Console.WriteLine("Job Application Tracker\n");
                Console.WriteLine("1) Apply for a new job");
                Console.WriteLine("2) Show all applications");
                Console.WriteLine("3) Filter by status");
                Console.WriteLine("4) Sort by date");
                Console.WriteLine("5) Show statistics");
                Console.WriteLine("Type 6 to quit the application");


                Console.Write("\nuser: ");
                int userinput = Convert.ToInt32(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        Console.WriteLine("hello");
                        break;

                    case 2:
                        Console.WriteLine("goodbye");
                        break;
                }

                if (userinput == 10)
                {
                    break;
                }
            }
        }
    }
}
