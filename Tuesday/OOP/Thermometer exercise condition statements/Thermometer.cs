namespace Thermometer_exercise_condition_statements
{
    internal class Thermometer
    {
        public int Temperature;


        public void InputTemperature()
        {
            Console.WriteLine("What's the temperature today?");
            Temperature = Convert.ToInt32(Console.ReadLine());
        }


        public void CheckTemperature()
        {
            if (Temperature >= -14 && Temperature <= 5)
            {
                Console.WriteLine("It's kind of cold in here...");
            }

            else if (Temperature <= -15)
            {
                Console.WriteLine("Wow, it's freezing in here!");
            }

            else if (Temperature >= 20)
            {
                Console.WriteLine("It's quite hot here!");
            }

            else
            {
                Console.WriteLine("The temperature is nice and comfortable");
            }
        }
    }


    
}
