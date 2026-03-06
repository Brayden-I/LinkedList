// BRAYDEN IMADA
namespace LLNoder;

public class LLNode<T>
{
    public T data { get; set; }
    public LLNode<T>? next { get; set; }

    public LLNode(T d)
    {
        data = d; // value in the node
        next = null; // null by default; no reference
    }
}

public class LLinkedList<T> where T : IEquatable<T>
{
    //FIELDS
    private LLNode<T>? head;

    // CONSTRUCTOR
    public LLinkedList()
    {
        this.head = null;
    }

    // METHODS
    public void AddNode(T value)
    {
        LLNode<T> newNode = new LLNode<T>(value);

        if (head == null) // If the list is empty, the new node becomes the head
        {
            head = newNode;
            return;
        }

        LLNode<T> current = head;
        while (current.next != null)
        {
            current = current.next; // Move to next node
        }

        // Attach the new node after the last node
        current.next = newNode;
    }

    public void DeleteNode(T value)
    {
        // Case 1: The list is empty
        if (head == null) // If the list is empty, there is no node to delete (duh)
        {
            return;
        }

        // Case 2: The head is the target value
        if (head.data.Equals(value)) // If the current head equals the target
        {
            head = head.next; // Garbage Collection will collect the old head node
            return;
        }

        // Case 3: We search the rest of the list
        LLNode<T> previous = head;
        LLNode<T> current = head.next;

        while (current != null)
        {
            if (current.data.Equals(value))
            {
                // Bridge the previous node to the next node
                previous.next = current.next;
                return;
            }

            // Advance to the next node
            previous = current;
            current = current.next;
        }
    }

    public int Search(T value)
    {
        LLNode<T> current = head;
        int index = 0; // Track position

        while ( current != null)
        {
            if (current.data.Equals(value))
            {
                Console.WriteLine($"[Search] '{value}' found at index {index}");
                return index; // End the search
            }
            current = current.next;
            index++;
        }

        Console.WriteLine($"[Search] '{value}' was not found");
        return -1;
    }

    // print
    public void Print()
    {
        // Case 1: The list is empty
        if (head == null) // If the list is empty, there is no node to delete (duh)
        {
            Console.WriteLine("LList is empty");
            return;
        }

        Console.Write("[HEAD]");

        LLNode<T>? current = head;
        while (current != null)
        {
            Console.Write($" -> {current.data}");
            current = current.next; // Advance to the next
        }

        Console.WriteLine(" -> NULL"); // Mark the end of the list
    }
}
