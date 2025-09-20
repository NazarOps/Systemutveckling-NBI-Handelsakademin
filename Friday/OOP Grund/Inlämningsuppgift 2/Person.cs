public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
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