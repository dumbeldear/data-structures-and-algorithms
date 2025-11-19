namespace DataStructuresAndAlgorithms.DataStructures.LinkedList;

/// <summary>
/// Making Node class internal - only LinkedList class should be able to see / use Nodes
/// </summary>
/// <typeparam name="T"></typeparam>
internal class Node<T>
{
    public T Value { get; }
    public Node<T>? Next { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}