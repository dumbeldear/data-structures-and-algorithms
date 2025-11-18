/// <summary>
/// Represents a simple static array
/// </summary>
/// <typeparam name="T"></typeparam>
namespace DataStructuresAndAlgorithms.DataStructures;
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
            throw new IndexOutOfRangeException("Index exceeds the number of assigned elements.");
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

    public void Append(T value)
    {
        if (Length == Capacity)
        {
            Resize(Capacity * 2);
        }
        Set(Length, value);
    }

    public void RemoveAt(int index)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Index cannot be less than zero.");
        }
        else if (index >= Length)
        {
            throw new IndexOutOfRangeException("Index exceeds the number of assigned elements.");
        }
        else
        {
            if (index == Length - 1)
            {
                _storage[index] = default!;
            }
            else
            {
                for (int i = index; i < Length - 1; i++)
                {
                    _storage[i] = _storage[i + 1];
                }
            }
            // decrease counter
            _count--;
            // Clear last element
            _storage[_count] = default!;
        }
    }

    public override string ToString()
    {
        var tempArray = new T[Length];
        for (int i = 0; i < Length; i++)
        {
            tempArray[i] = _storage[i];
        }
        return "[" + string.Join(", ", tempArray) + "]";        
    }
    
    private void Resize(int newCapacity)
    {
        // Create new storage
        var newArray = new T[newCapacity];

        // Copy old values into new array
        for (int i = 0; i < Length; i++)
        {
            newArray[i] = _storage[i];
        }

        // Assign storage to new array
        _storage = newArray;
    }
}