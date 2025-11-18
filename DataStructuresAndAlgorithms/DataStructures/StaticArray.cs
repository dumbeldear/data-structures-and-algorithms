/// <summary>
/// Represents a simple static array
/// </summary>
/// <typeparam name="T"></typeparam>
public class StaticArray<T>
{
    private int _count;
    private T[] _storage;
    public int Length => _count;
    public int Capacity => _storage.Length;

    public StaticArray(int size)
    {
        _storage = new T[size];
        _count = 0;
    }

    public T Get(int index)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Index cannot be less than zero.");
        }
        else if (index >= Length)
        {
            throw new IndexOutOfRangeException("Index exceeds array capacity.");
        }
        else
        {
            return _storage[index];
        }        
    }

    public void Set(int index, T value)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Index cannot be less than zero.");
        }
        else if (index >= Capacity)
        {
            throw new IndexOutOfRangeException("Index exceeds array capacity.");
        }
        else if (index > _count)
        {
            throw new IndexOutOfRangeException("Index is beyond the current length of the array.");
        }
        else
        {
            _storage[index] = value;
        }

        if (index == _count)
        {
            _count++;
        }
    }
}