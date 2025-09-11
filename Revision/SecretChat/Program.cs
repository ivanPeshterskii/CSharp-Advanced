using System;
using System.Linq;
namespace SecretChat;
class Program
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();

        string command = "";

        while((command = Console.ReadLine()) != "Reveal")
        {
            string[] tokens = command.
                Split(":|:", StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "InsertSpace":
                    int index = int.Parse(tokens[1]);
                    message = message.Insert(index," ");
                    break;

                case "Reverse":
                    string substring = tokens[1];
                    int subIndex = message.IndexOf(substring);
                    if (subIndex != -1)
                    {
                        
                        message = message.Remove(subIndex, substring.Length);

                        
                        char[] arr = substring.ToCharArray();
                        Array.Reverse(arr);
                        string reversed = new string(arr);

                        
                        message += reversed;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "ChangeAll":
                    string newSubstring = tokens[1];
                    string replacement = tokens[2];
                    message = message.Replace(newSubstring, replacement);
                    break;
            }
        }

        Console.WriteLine($"You have a new text message: {message}");
        Console.ReadKey();
    }
}

