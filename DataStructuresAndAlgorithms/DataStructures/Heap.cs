using System.ComponentModel.Design;

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
        _elements.Add(value);
        BubbleUp(_elements.Count - 1);
    }

    private void BubbleUp(int index)
    {
        if (Count > 1)
        {
            int currentIndex = index;
            bool correctPosition = false;
            while (!correctPosition && currentIndex > 0)
            {
                // Check with parent node
                if (HasHigherPriority(currentIndex, Parent(currentIndex)))
                {
                    T currentElement = _elements[currentIndex];
                    T parentElement = _elements[Parent(currentIndex)];
                    // Swap 
                    _elements[currentIndex] = parentElement;
                    _elements[Parent(currentIndex)] = currentElement;
                    currentIndex = Parent(currentIndex);
                }
                else
                {
                    correctPosition = true;
                }
            }
        }
    }

    public T Pop()
    {

    }

    public T Peek()
    {

    }

    public int Parent(int index)
    {
        return (index - 1) / 2;
    }

    public int LeftChild(int index)
    {
        return index * 2 + 1;
    }

    public int RightChild(int index)
    {
        return index * 2 + 2;
    }
    
    bool HasHigherPriority(int a, int b)
    {
        return  _compare(_elements[a], _elements[b]) > 0;
    }
}