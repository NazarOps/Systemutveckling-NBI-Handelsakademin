using System;

class Cat
{
    private string name = "Fluffy boi";
    private string word = "Meooow!";

    static void Main(string[] args)
    {
        Cat myCat = new Cat();
        Console.WriteLine(myCat.name + " says " + myCat.word);
    }
}
