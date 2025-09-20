public class Person
{
    private string Name { get; set; }
    private int Age { get; set; }
    private string Gender { get; set; }
    public Person() { }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public void InfoAboutPerson()
    {
        Console.WriteLine($"This person's name is {Name}, they are {Age} years old and their gender is {Gender}\n");
    }
}