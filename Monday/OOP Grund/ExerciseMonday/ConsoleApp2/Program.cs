namespace ConsoleApp2
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.Name = "Honda";
            myCar.model = "CR-V";
            myCar.year = 2010;

            myCar.info();

        }
    }
}