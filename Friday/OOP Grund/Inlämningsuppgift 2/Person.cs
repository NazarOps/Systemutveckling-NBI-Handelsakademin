public class Person
{
    // Properties instead of private fields
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    // Default constructor
    public Person() { }

    // Constructor with parameters
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    // Constructor with just name
    public Person(string name)
    {
        Name = name;
    }

    public void InfoAboutPerson()
    {
        Console.WriteLine($"This person's name is {Name}, they are {Age} years old and their gender is {Gender}");
    }
}