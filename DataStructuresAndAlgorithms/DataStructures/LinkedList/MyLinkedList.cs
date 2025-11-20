using System.Security.AccessControl;
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

    public void AddLast(T value)
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
            // head is the newest
            // tail is the oldest
            // next is going from newest to oldest 
            // so when adding last get the tail node and set next to the new one
            tail.Next = newNode;
            tail = newNode;
        }
        _count++;
    }

    public void RemoveFirst()
    {
        if (head != null)
        {
            head = head.Next;
            _count--;
        }
    }

    public bool Remove(T value)
    {

        if (head == null)
        {
            return false;
        }

        if (EqualityComparer<T>.Default.Equals(head.Value, value))
        {
            head = head.Next;
            _count--;

            if (head == null)
                tail = null;

            return true;
        }

        var current = head;

        while (current.Next != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Next.Value, value))
            {
                if (current.Next == tail)
                {
                    tail = current;
                }

                current.Next = current.Next.Next;

                _count--;
                return true;
            }

            current = current.Next;
        }

        return false;
    }
    
    public void Clear()
    {
        head = null;
        tail = null;
        _count = 0;
    }

    public bool Contains(T value)
    {
        var current = head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
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

