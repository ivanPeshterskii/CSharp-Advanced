using System;

namespace ObjectsAndClasses;
class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string breed = Console.ReadLine();
        

        Dog dog = new Dog
        {
            Name = name,
            Breed = breed
        };

        Console.WriteLine($"Name is {dog.Name}");
        Console.WriteLine($"Its breed is {dog.Breed}");
        Console.WriteLine($"It {dog.Action("bark")}");
        Console.ReadKey();
    }
}

public class Dog
{
    public string Name { get; set; }

    public string Breed { get; set; }

    public string Action(string text)
    {
        return text;
    }
}