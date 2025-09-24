using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = ReadPeople(n);

        string condition = Console.ReadLine();
        int ageThreshold = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();

        Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
        Action<Person> printer = CreatePrinter(format);

        PrintFilteredPeople(people,filter, printer);
    }

    static List<Person> ReadPeople(int n)
    {
        List<Person> people = new();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            people.Add(new Person
            {
                Name = parts[0],
                Age = int.Parse(parts[1])
            });
        }

        return people;
    }

    static Func<Person, bool> CreateFilter(string condition, int age)
    {
        if(condition == "younger")
        {
            return p => p.Age < age;
        }
        else
        {
            return p => p.Age >= age;
        }
    }

    static Action<Person> CreatePrinter(string format)
    {
        if(format == "name")
        {
            return p => Console.WriteLine(p.Name);
        }
        else if(format == "age")
        {
            return p => Console.WriteLine(p.Age);
        }
        else
        {
            return p => Console.WriteLine($"{p.Name} - {p.Age}");
        }
    }

    static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
    {
        foreach (var person in people)
        {
            if (filter(person))
            {
                printer(person);
            }
        }
    }

}