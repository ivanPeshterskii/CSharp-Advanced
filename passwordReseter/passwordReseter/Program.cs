namespace passwordReseter;
class Program
{
    static string Password { get; set; }

    static void Main(string[] args)
    {
        Password = Console.ReadLine();

        string command = string.Empty;
        while((command = Console.ReadLine())!= "Done")
        {
            string[] parts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (parts[0])
            {
                case "TakeOdd":
                    TakeOdd();
                    break;

                case "Cut":
                    Cut(int.Parse(parts[1]), int.Parse(parts[2]));
                    break;

                case "Substitute":
                    Substitute(parts[1], parts[2]);
                    break;

            }
        }


        Console.WriteLine($"Your password is: {Password}");
        Console.ReadKey();
    }


    static void TakeOdd()
    {
        for(int i = 0; i < Password.Length; i++)
        {
            string newPassword = string.Empty;
            if (i % 2 != 0)
            {
                newPassword += Password[i];
            }
            Password = newPassword;
            Console.WriteLine(Password);
        }
    }

    static void Cut(int index, int length)
    {
        Password = Password.Remove(index,length);
        Console.WriteLine(Password);
    }

    static void Substitute(string substring, string substitude)
    {
        if (Password.Contains(substring))
        {
            Password = Password.Replace(substring, substitude);
            Console.WriteLine(Password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
    }
}

