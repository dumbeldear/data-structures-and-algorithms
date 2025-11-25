namespace DataStructuresAndAlgorithms.DataStructures.Heap;

interface GenericHeap<T>
{
    int Count { get; }
    bool isEmpty { get; }
    void Insert(T value);
    void Pop();
    void Peek();
}

public class Heap<T> : GenericHeap<T>
{
    public int Count { get; }
    public bool isEmpty { get; }

    public void Insert(T value)
    {

    }

    public void Pop()
    {

    }
    
    public void Peek()
    {
        
    }
}