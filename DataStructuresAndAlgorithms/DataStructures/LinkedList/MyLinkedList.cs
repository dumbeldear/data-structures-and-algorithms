using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList;

public class LinkedList<T>
{
    // head is the newest item and tail is the oldest item
    private Node<T>? head;
    private Node<T>? tail;
    private int _count = 0;

    public void AddFirst(T value)
    {
        var newNode = new Node<T>(value);

        // If list is empty
        if (head == null)
        {
            // Sets tail and head to the newly added Node
            head = newNode;
            tail = newNode;
        }
        else
        {
            // point the newly added node to the previous head node
            newNode.Next = head;
            // set the new node as the head node
            head = newNode;
        }
        _count++;
    }

    public override string ToString()
    {
        if (head == null)
        {
            return "Linked List is empty.";
        }

        var sb = new StringBuilder();
        var current = head;

        while (current != null)
        {
            sb.Append(current.Value);
            sb.Append(" -> ");
            current = current.Next;
        }

        sb.Append("null");
        return sb.ToString();
    }
}

