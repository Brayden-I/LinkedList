using System.Security.Cryptography.X509Certificates;

namespace LLNoder;

public class LLNode
{
    public int data;
    public LLNode next;

    public LLNode(int d)
    {
        data = d; // value in the node
        next = null; // null by default; no reference
    }
}

public class LinkedList
{
    //FIELDS
    public LLNode head;

    // CONSTRUCTOR
    public LinkedList()
    {
        this.head = null;
    }

    // METHODS
    public void addNode(int d)
    {
        LLNode newNode = new LLNode(d);
        newNode.next = head; // link new node to old head
        head = newNode; // change head to new node
    }
}
