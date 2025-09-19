namespace Inlämningsuppgift_2
{
    public class Employee : Person
    {
        public int NumberofStaff;
        public int WorkExperience;


        public void info()
        {
            Console.WriteLine($"There are currently {NumberofStaff} staff members working at the gym. Most of them have {WorkExperience} years of work experience. \n");
        }
    }
}
