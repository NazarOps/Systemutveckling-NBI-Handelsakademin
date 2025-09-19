namespace Inlämningsuppgift_2
{
    public class Person
    {
        private string Name;
        private int Age;
        private string Gender;

        public Person(string namn) 
        {
            Name = namn;
        }
        public string Namn
        {
            get { return Name; }
            set { Name = value; }
        }

        public Person(int age)
        {
            Age = age;
        }
        public int Ålder
        {
            get { return Age; }
            set { Age = value; }
        }
        public string Kön
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public void InfoAboutPerson()
        {
            Console.WriteLine($"This persons name is {Namn}, person is {Ålder} years old and persons gender is {Kön}");
        }

        public Person()
        { 
        }
    }
}
