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
}