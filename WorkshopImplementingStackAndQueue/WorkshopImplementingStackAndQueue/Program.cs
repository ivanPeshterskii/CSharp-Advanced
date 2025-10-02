namespace WorkshopImplementingStackAndQueue.CustomStack;
class Program
{
    static void Main(string[] args)
    {
        CustomStack stack = new CustomStack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);

        stack.ForEach(e => Console.WriteLine(e));

        Console.ReadKey();

    }
}

