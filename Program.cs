// BRAYDEN IMADA
using LLNoder;

namespace LinkedListApp;

class Program
{
    static void Main(string[] args)
    {
        LLinkedList<int> linkedList = new LLinkedList<int>();

        linkedList.AddNode(15);
        linkedList.AddNode(25);
        linkedList.AddNode(65);

        linkedList.Print();

        Console.WriteLine($"{linkedList.Search(25)}");

        linkedList.DeleteNode(25);
        linkedList.AddNode(65);

        linkedList.Print();

        Console.WriteLine($"{linkedList.Search(65)}");

        linkedList.DeleteNode(65);
        linkedList.DeleteNode(65);
        linkedList.DeleteNode(65);

        linkedList.Print();
    }
}
