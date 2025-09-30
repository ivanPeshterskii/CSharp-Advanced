namespace CustomDoublyLinkedList;
class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList list = new DoublyLinkedList();

        list.AddFirstElement(3);
        list.AddFirstElement(10);
        list.AddFirstElement(1);

        list.RemoveFirst(1);

        Console.WriteLine(string.Join(", ", list.ToArray()));
        Console.ReadKey();
    }
}

