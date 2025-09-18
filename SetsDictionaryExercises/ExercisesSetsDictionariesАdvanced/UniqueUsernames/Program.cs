using System;
using System.Collections.Generic;

namespace UniqueUsernames;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> usernames = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (!usernames.Contains(input))
            {
                usernames.Add(input);
            }
        }

        foreach (var user in usernames)
        {
            Console.WriteLine(user);
        }
    }
}

