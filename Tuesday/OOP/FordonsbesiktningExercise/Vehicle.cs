namespace FordonsbesiktningExercise
{
    public class Vehicle
    {
        public int VehicleAge;
        public string HasInsurance;


        public void Inspection()
        {
            Console.WriteLine("Do you have valid insurance?");
            HasInsurance = Console.ReadLine().ToLower(); // convert all user inputs to lowercase so that the code doesnt break
            Console.WriteLine("How old is your car?");
            VehicleAge = Convert.ToInt32(Console.ReadLine());
        }

        public void CheckInspection()
        {
            if (VehicleAge < 5 && HasInsurance == "yes") 
            {
                Console.WriteLine("Your car is cleared of inspection");
            }

            else if (VehicleAge > 5 && HasInsurance == "no")
            {
                Console.WriteLine("Your car has not been cleared");
            }

            else
            {
                Console.WriteLine("Your insurance must be supplemented");
                Console.WriteLine("Your car has not been cleared");
            }
        }
    }
}
