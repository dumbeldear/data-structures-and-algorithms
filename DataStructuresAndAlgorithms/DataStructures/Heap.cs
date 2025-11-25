namespace DataStructuresAndAlgorithms.DataStructures.Heap;

public interface IHeap<T>
{
    int Count { get; }
    bool IsEmpty { get; }
    void Insert(T value);
    T Pop();
    T Peek();
}

public class Heap<T> : IHeap<T>
{
    private List<T> _elements;
    private readonly Comparison<T> _compare;
    public int Count => _elements.Count;
    public bool IsEmpty => Count == 0;

    public Heap(Comparison<T> comparison = null)
    {
        _elements = new List<T>();
        _compare = comparison ?? Comparer<T>.Default.Compare;
    }

    public void Insert(T value)
    {

    }

    public T Pop()
    {

    }
    
    public T Peek()
    {

    }
}