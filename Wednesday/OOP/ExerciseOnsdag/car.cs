namespace ExerciseOnsdag
{
    public class Car
    {
        // Vi skapar en klass som heter Car
        public string Brand;
        public string Model;
        public int ModelNumber;

        // Vi samlar in information med metoden collectInfo()
        public void collectInfo()
        {
            // Clean Code
            // Här behöver vi inte skriva Car.Brand osv för att vi har redan deklarerat
            // Vi tar in användarinput som information för brand, model och modelnumber

            Console.WriteLine("\nPlease provide a car brand");
            Brand = Console.ReadLine();

            Console.WriteLine("Please provide a car model");
            Model = Console.ReadLine();

            Console.WriteLine("Please provide a modellnumber");
            ModelNumber = Convert.ToInt32(Console.ReadLine());
        }   

        public void printInfo()
        {
            // Här inne printar vi ut information som vanligt
            Console.WriteLine($"This car is a {Brand}, the model is {Model} and the number is {ModelNumber}");
        }   
    }
}
