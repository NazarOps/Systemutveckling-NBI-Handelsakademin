namespace Thermometer_exercise_condition_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Thermometer thermometer = new Thermometer();
            thermometer.InputTemperature();
            thermometer.CheckTemperature();
        }
    }
}
