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
    }

    public T Get(int index)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Index cannot be less than zero.");
        }
        else if (index >= Length)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
        else
        {
            return _storage[index]; 
        }
    }
}