namespace GeneriskRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // skapa objekt av listan av strängar
            GenericRepo<string> generiskRepo = new GenericRepo<string>();
            generiskRepo.Add("Student Nazar");
            generiskRepo.Add("Student Nemo");
            List<string> AllanamnsominnehallerNemo = generiskRepo.Find(name => name.Contains("Nemo"));
            foreach (var item in AllanamnsominnehallerNemo)
            {
                Console.WriteLine(item);
            }
            GenericRepo<int> generiskrepomedints = new GenericRepo<int>();
            generiskrepomedints.Add(1);
            generiskrepomedints.Add(2);
            generiskrepomedints.Add(3);

            List<int>NummerStörreÄnEtt = generiskrepomedints.Find(number => number > 1);
            foreach (var item in NummerStörreÄnEtt)
            {
                Console.WriteLine(item); 
            }
            

            

        }
    }
}
