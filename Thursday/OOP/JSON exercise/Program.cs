using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.IO;
using System.Text.Json;

namespace JSON_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<(string Name, int Price)> items = new List<(string, int)>
            //{
            //    ("Milk", 40),
            //    ("Bacon", 20),
            //    ("Cottage Cheese", 50),
            //    ("Hamburger", 130),
            //    ("Steak", 100),
            //    ("Beef", 120)
            //};

            //// sort items that cost 50 or greater
            //var filtered = items.Where(items => items.Price >= 50);

            //var sortbydescending = filtered.OrderByDescending(item => item.Price);

            //foreach (var item in sortbydescending) {
            //    Console.WriteLine($"{item.Name} - {item.Price}");
            //}
            

            //List<(string Name, int Grade)> StudentGrades = new List<(string Name, int Grade)>
            //{
            //    ("Bob", 20),
            //    ("Dylan", 20),
            //    ("Kyle", 50),
            //    ("Andrew",79),
            //    ("Emily", 100),
            //    ("Jake", 120),
            //    ("John", 20)
            //};

            ////sort after grades
            //var grouped = StudentGrades
            //    .GroupBy(x => x.Grade)
            //    .Select(g => new { Grade = g.Key, Count = g.Count() });

            //foreach (var student in grouped)
            //{
            //    Console.WriteLine($"Students with {student}");
            //}    
                
            //List<(string Name, int Salary)> Employees = new List<(string Name, int Salary)>
            //{
            //    ("Bob", 5300),
            //    ("Dylan", 12400),
            //    ("Andrew", 23000),
            //    ("Derek", 27000),
            //};

            //var projection = Employees
            //    .Select(x => (x.Name, NewSalary: x.Salary * 1.1));
                

            //foreach (var employee in projection)
            //{
            //    Console.WriteLine($"{employee.Name}  New Salary: {employee.NewSalary:F2}");
            //}

            List<int> ListOfNumbers = new List<int>();
            ListOfNumbers.Add(50);
            ListOfNumbers.Add(100);
            ListOfNumbers.Add(500);
            ListOfNumbers.Add(1000);
            ListOfNumbers.Add(300);

            var sum = ListOfNumbers.Sum();
            var average = ListOfNumbers.Average();
            var lowest = ListOfNumbers.Min();
            var highest = ListOfNumbers.Max();

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {average}");
            //Console.WriteLine($"Lowest: {lowest}");
            //Console.WriteLine($"Highest: {highest}");

            string json = JsonSerializer.Serialize(sum);    
            Console.WriteLine(json);

            File.WriteAllText("sum", json);
            Console.WriteLine("File saved to JSON");
            
            

            
            
            

        }
    }
}
